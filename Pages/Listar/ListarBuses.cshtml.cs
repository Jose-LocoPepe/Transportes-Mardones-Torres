using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres;

namespace MyApp.Namespace
{
    public class ListarBusesModel : PageModel
    {
        public List<Bus> ListaBuses { get; set; } = new List<Bus>();
        public void OnGet()
        {
            TransporteContext context = new TransporteContext();
            ListaBuses = context.Buses.ToList();
        }
    }
}
