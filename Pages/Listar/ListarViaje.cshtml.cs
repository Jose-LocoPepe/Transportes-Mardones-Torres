using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres;

namespace MyApp.Namespace
{
    public class ListarViajeModel : PageModel
    {
        public List<Viaje> ListaViajes { get; set; }
        public void OnGet()
        {
            TransporteContext context = new TransporteContext();
            ListaViajes = context.Viajes.ToList();
        }
    }
}
