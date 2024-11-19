using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres;

namespace MyApp.Namespace
{
    public class ActualizarBusModel : PageModel
    {
        public Bus bus { get; set; }
        public IActionResult OnGet(int? id)
        {
            TransporteContext context = new TransporteContext();
            // Aquí se recibe el id del bus a actualizar
            if(!id.HasValue)
            {
                // Si no se recibe el id, se redirige a la página de inicio
                Response.Redirect("/");
            }
            bus = context.Buses.Find(id);
            
            return Page();

        }
        public IActionResult OnPost(Bus bus)
        {
            TransporteContext context = new TransporteContext();
            // Se actualiza el bus
            context.Buses.Update(bus);
            context.SaveChanges();
            // Se redirige a la página de inicio
            return Redirect("/");
        }
    }
}
