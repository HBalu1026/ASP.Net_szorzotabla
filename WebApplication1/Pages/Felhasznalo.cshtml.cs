using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class FelhasznaloModel : PageModel
    {
        [BindProperty]
        public Felhasznalo ujFelhasznalo {  get; set; } = new Felhasznalo();

        public List<Felhasznalo> felhasznalok { get; set; } = new List<Felhasznalo>();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            felhasznalok.Add(ujFelhasznalo);
            return Page();
        }
    }
}
