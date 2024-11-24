using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres.Models;
namespace MyApp.Namespace
{
    public class NuevoViajeModel : PageModel
    {
        public List<Bus> ListaBuses { get; set; } = new List<Bus>();
        public List<Chofer> ListaChoferes { get; set; } = new List<Chofer>();

        public void OnGet()
        {
            TransporteContext context = new TransporteContext();
            ListaBuses = context.Buses.Where(bus => bus.Disponibilidad).ToList();
            ListaChoferes = context.Choferes.Where(chofer => chofer.Disponibilidad).ToList();
        }

        public void OnPost(int bus, int chofer, DateTime fecha)
        {
            Viaje viaje = new Viaje();
            viaje.IdBus = bus;
            viaje.IdChofer = chofer;
            viaje.Fecha = fecha;

            
            //TODO: Falta hacer la tabla de kilometraje y ¿calcular? la distancia



            TransporteContext context = new TransporteContext();
            context.Viajes.Add(viaje);
            context.SaveChanges();

            Response.Redirect("/Listar/ListarViajes");
        }
    }
}
