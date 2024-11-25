using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres.Models;
namespace MyApp.Namespace
{
    public class NuevoViajeModel : PageModel
    {
        public List<Bus> ListaBuses { get; set; } = new List<Bus>();
        public List<Chofer> ListaChoferes { get; set; } = new List<Chofer>();
        public List<Tramo> ListaTramos { get; set; } = new List<Tramo>();

        public void OnGet()
        {
            TransporteContext context = new TransporteContext();
            ListaBuses = context.Buses.Where(bus => bus.Disponibilidad).ToList();
            ListaChoferes = context.Choferes.Where(chofer => chofer.Disponibilidad).ToList();
            ListaTramos = context.Tramos.ToList();
        }

        public void OnPost(int bus, int chofer, DateTime fecha, int tramo)
        {
            Viaje viaje = new Viaje();
            viaje.IdTramo = tramo;
            viaje.IdBus = bus;
            viaje.IdChofer = chofer;
            viaje.Fecha = fecha;
            
            TransporteContext context = new TransporteContext();
            context.Viajes.Add(viaje);

            Tramo tramoEntity = context.Tramos.Find(tramo);

            Bus busEntity = context.Buses.Find(bus);
            busEntity.Kilometros += tramoEntity.Distancia;

            Chofer choferEntity = context.Choferes.Find(chofer);
            choferEntity.Kilometros += tramoEntity.Distancia;

            
            context.SaveChanges();

            Response.Redirect("/Listar/ListarViajes");
        }
    }
}
