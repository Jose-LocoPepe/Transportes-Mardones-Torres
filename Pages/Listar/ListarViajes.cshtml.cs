using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres.Models;
using Microsoft.EntityFrameworkCore;
namespace MyApp.Namespace
{
    public class ListarViajesModel : PageModel
    {
        public List<Viaje> ListaViajes { get; set; } = new List<Viaje>();
        public void OnGet()
        {
            TransporteContext context = new TransporteContext();
            ListaViajes = context.Viajes
                                 .Include(v => v.IdBusNavigation)
                                 .Include(v => v.IdChoferNavigation)
                                 .ToList();
        }
    }
}
