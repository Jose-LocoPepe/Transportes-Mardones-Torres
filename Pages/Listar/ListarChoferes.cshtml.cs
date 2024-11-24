using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres.Models;

namespace MyApp.Namespace
{
    public class ListarChoferesModel : PageModel
    {
        public List<Chofer> ListaChoferes { get; set; } = new List<Chofer>();
        public void OnGet()
        {
            TransporteContext context = new TransporteContext();
            ListaChoferes = context.Choferes.ToList();
        }
    }
}
