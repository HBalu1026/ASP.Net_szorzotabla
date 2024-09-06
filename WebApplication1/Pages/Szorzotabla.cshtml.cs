using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class SzorzotablaModel : PageModel
    {
        [BindProperty]
        public int MaxTenyezo { get; set; }
        static public int MasikMax {  get; set; }

        public void OnGet ()
        {
        }

        public IActionResult OnPost()
        {
            //MasikMax = MaxTenyezo;
            return Page();
        }
    }
}
