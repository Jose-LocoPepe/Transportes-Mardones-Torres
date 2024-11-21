using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres;

namespace MyApp.Namespace
{
    public class NuevoBusModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(string patente, string codigo, bool disponibilidad)
        {
            Bus bus = new Bus();
            bus.Patente = patente;
            bus.Codigo = codigo;
            bus.Disponibilidad = disponibilidad;
            
            TransporteContext context = new TransporteContext();
            context.Buses.Add(bus);
            context.SaveChanges();

            Response.Redirect("/Listar/ListarBuses");
        }
    }
}
