﻿using EmotionTracker.Application.Requests.Mail;
using System.Threading.Tasks;

namespace EmotionTracker.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}