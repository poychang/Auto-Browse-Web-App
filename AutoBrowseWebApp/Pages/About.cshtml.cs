using AutoBrowseWebApp.Utilities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoBrowseWebApp.Pages
{
    public class AboutModel : PageModel
    {
        public string ActionResult { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your application description page.";
            ActionResult = ActionHelper.Run();
        }
    }
}
