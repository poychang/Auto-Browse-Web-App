using System;

namespace AutoBrowseWebApp.Utilities
{
    public static class EnvironmentHelper
    {
        public static bool IsThrowOutException { get; set; } = bool.Parse(Environment.GetEnvironmentVariable("IsThrowOutException") ?? "false");
        public static int RandomMinWaiting { get; set; } = int.Parse(Environment.GetEnvironmentVariable("RandomMinWaiting") ?? "3");
        public static int RandomMaxWaiting { get; set; } = int.Parse(Environment.GetEnvironmentVariable("RandomMaxWaiting") ?? "10");
        public static int RandomMinExceptionRate { get; set; } = int.Parse(Environment.GetEnvironmentVariable("RandomMinExceptionRate") ?? "80");
        public static int RandomMaxExceptionRate { get; set; } = int.Parse(Environment.GetEnvironmentVariable("RandomMaxExceptionRate") ?? "100");
    }
}
