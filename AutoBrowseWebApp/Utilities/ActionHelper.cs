using System;
using static AutoBrowseWebApp.Utilities.EnvironmentHelper;
using static AutoBrowseWebApp.Utilities.ExceptionHelper;
using static AutoBrowseWebApp.Utilities.HttpClientHelper;

namespace AutoBrowseWebApp.Utilities
{
    public static class ActionHelper
    {
        public static string Run()
        {
            switch (new Random().Next(1, 100))
            {
                case var n when n >= RandomMinExceptionRate && n < RandomMaxExceptionRate: // 20%
                    var ex = RandomException();
                    return $"{ex.Name}, {ex.Message}";
                case var n when n >= 1 && n < 60: // 50%
                    return "Safe";
                case var n when n >= 60 && n < 70: // 10%
                    var getResult = Get();
                    return $"Call HttpClient GET: {getResult.StatusCode}";
                case var n when n >= 70 && n < 80: // 10%
                    var postResult = Post();
                    return $"Call HttpClient POST: {postResult.StatusCode}";
                default:
                    var d = ThrowException<NotImplementedException>();
                    return $"{d.Name}, {d.Message}";
            }
        }
    }
}
