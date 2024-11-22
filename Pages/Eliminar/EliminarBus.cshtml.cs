using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres;
namespace MyApp.Namespace
{
    public class EliminarBusModel : PageModel
    {
        public List<Bus> ListaBuses { get; set; } = new List<Bus>();
        public void OnGet()
        {
            TransporteContext context = new TransporteContext();
            ListaBuses = context.Buses.Where(bus => !context.Viajes.Any(viaje => viaje.IdBus == bus.Id)).ToList();
        }

        public void OnPost(int IDbus)
        {
            TransporteContext context = new TransporteContext();
            Bus bus = context.Buses.Find(IDbus);
            context.Buses.Remove(bus);
            context.SaveChanges();
            OnGet();
        }
    }
}
