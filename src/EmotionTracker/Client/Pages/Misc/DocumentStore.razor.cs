﻿using EmotionTracker.Application.Features.Documents.Queries.GetAll;
using EmotionTracker.Application.Requests.Documents;
using EmotionTracker.Client.Extensions;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmotionTracker.Client.Pages.Misc
{
    public partial class DocumentStore
    {
        private IEnumerable<GetAllDocumentsResponse> pagedData;
        private MudTable<GetAllDocumentsResponse> table;
        private string CurrentUserId { get; set; }
        private int totalItems;
        private int currentPage;
        private string searchString = null;

        protected override async Task OnInitializedAsync()
        {
            var state = await _stateProvider.GetAuthenticationStateAsync();
            var user = state.User;
            if (user == null) return;
            if (user.Identity.IsAuthenticated)
            {
                CurrentUserId = user.GetUserId();
            }
        }

        private async Task<TableData<GetAllDocumentsResponse>> ServerReload(TableState state)
        {
            await LoadData(state.Page, state.PageSize);
            return new TableData<GetAllDocumentsResponse>() { TotalItems = totalItems, Items = pagedData };
        }

        private async Task LoadData(int pageNumber, int pageSize)
        {
            var request = new GetAllPagedDocumentsRequest { PageSize = pageSize, PageNumber = pageNumber + 1 };
            var response = await _documentManager.GetAllAsync(request);
            if (response.Succeeded)
            {
                totalItems = response.TotalCount;
                currentPage = response.CurrentPage;
                var data = response.Data;
                data = data.Where(element =>
                {
                    if (string.IsNullOrWhiteSpace(searchString))
                        return true;
                    if (element.Title.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        return true;
                    if (element.Description.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        return true;
                    return false;
                }).ToList();
                pagedData = data;
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(localizer[message], Severity.Error);
                }
            }
        }

        private void OnSearch(string text)
        {
            searchString = text;
            table.ReloadServerData();
        }

        private async Task InvokeModal(int id = 0)
        {
            var parameters = new DialogParameters();
            if (id != 0)
            {
                var doc = pagedData.FirstOrDefault(c => c.Id == id);
                parameters.Add("Id", doc.Id);
                parameters.Add("Title", doc.Title);
                parameters.Add("Description", doc.Description);
                parameters.Add("URL", doc.URL);
                parameters.Add("IsPublic", doc.IsPublic);
            }
            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.Medium, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<AddEditDocumentModal>("Modal", parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                OnSearch("");
            }
        }

        private async Task Delete(int id)
        {
            string deleteContent = localizer["Delete Content"];
            var parameters = new DialogParameters();
            parameters.Add("ContentText", string.Format(deleteContent, id));
            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.Small, FullWidth = true, DisableBackdropClick = true };
            var dialog = _dialogService.Show<Shared.Dialogs.DeleteConfirmation>("Delete", parameters, options);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {
                var response = await _documentManager.DeleteAsync(id);
                if (response.Succeeded)
                {
                    OnSearch("");
                    _snackBar.Add(localizer[response.Messages[0]], Severity.Success);
                }
                else
                {
                    OnSearch("");
                    foreach (var message in response.Messages)
                    {
                        _snackBar.Add(localizer[message], Severity.Error);
                    }
                }
            }
        }
    }
}