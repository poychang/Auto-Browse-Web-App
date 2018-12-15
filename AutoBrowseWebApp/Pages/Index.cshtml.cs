using AutoBrowseWebApp.Utilities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoBrowseWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string ActionResult { get; set; }

        public void OnGet()
        {
            ActionResult = ActionHelper.Run();
        }
    }
}
