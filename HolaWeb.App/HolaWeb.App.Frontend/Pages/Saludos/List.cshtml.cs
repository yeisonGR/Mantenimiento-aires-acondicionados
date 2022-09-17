using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
   
    public class ListModel : PageModel
    {
        private string[] saludos = {"Buenos días"};
        public List<string> ListaSaludos { get; set; }
        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(saludos);
        }
    }
    
}
