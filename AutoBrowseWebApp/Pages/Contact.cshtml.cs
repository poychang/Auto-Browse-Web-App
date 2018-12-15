using AutoBrowseWebApp.Utilities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoBrowseWebApp.Pages
{
    public class ContactModel : PageModel
    {
        public string ActionResult { get; set; }
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
            ActionResult = ActionHelper.Run();
        }
    }
}
