﻿using EmotionTracker.Application.Interfaces.Repositories;
using EmotionTracker.Domain.Entities;
using EmotionTracker.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace EmotionTracker.Application.Features.Documents.Commands.Delete
{
    public class DeleteDocumentCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }

        public class DeleteDocumentCommandHandler : IRequestHandler<DeleteDocumentCommand, Result<int>>
        {
            private readonly IUnitOfWork _unitOfWork;

            public DeleteDocumentCommandHandler(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public async Task<Result<int>> Handle(DeleteDocumentCommand command, CancellationToken cancellationToken)
            {
                var document = await _unitOfWork.Repository<Document>().GetByIdAsync(command.Id);
                await _unitOfWork.Repository<Document>().DeleteAsync(document);
                await _unitOfWork.Commit(cancellationToken);
                return Result<int>.Success(document.Id, "Document Deleted");
            }
        }
    }
}