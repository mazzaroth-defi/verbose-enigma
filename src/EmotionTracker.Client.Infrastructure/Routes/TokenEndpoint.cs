﻿namespace EmotionTracker.Client.Infrastructure.Routes
{
    public static class TokenEndpoint
    {
        public static string Get = "api/identity/token";
        public static string Refresh = "api/identity/token/refresh";
    }
}