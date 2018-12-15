using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using static AutoBrowseWebApp.Utilities.EnvironmentHelper;

namespace AutoBrowseWebApp.Pages.Api
{
    public class RandomRedirectModel : PageModel
    {
        public JsonResult OnGet()
        {
            return new JsonResult(new RedirectModel
            {
                RedirectTo = RedirectTo(),
                Waiting = Waiting() * 1000
            });
        }

        private static string RedirectTo()
        {
            switch (new Random().Next(1, 7))
            {
                case 1:
                    return "/";
                case 2:
                    return "About";
                case 3:
                    return "Contact";
                case 4:
                    return "Error";
                case 5:
                    return "Privacy";
                default:
                    return string.Empty; // Home
            }
        }

        private static int Waiting()
        {
            var a = RandomMinWaiting;
            var b = RandomMaxWaiting;
            return new Random().Next(a, b);
        }
    }

    public class RedirectModel
    {
        public string RedirectTo { get; set; }
        public int Waiting { get; set; }
    }
}
