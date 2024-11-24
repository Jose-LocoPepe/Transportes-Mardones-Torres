using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// using Transportes_Mardones_Torres;

namespace MyApp.Namespace
{
    public class ActualizarChoferModel : PageModel
    {
        // public Chofer chofer { get; set; } = new Chofer();
        public void OnGet()
        {
            // TransporteContext context = new TransporteContext();
            // // Aquí se recibe el id del chofer a actualizar
            // if(!Request.Query.ContainsKey("id"))
            // {
            //     // Si no se recibe el id, se redirige a la página de inicio
            //     Response.Redirect("/");
            // }
            // chofer = context.Choferes.Find(int.Parse(Request.Query["id"]));


        }
        // public IActionResult OnPost(Chofer chofer)
        // {
        //     TransporteContext context = new TransporteContext();
        //     // Se actualiza el chofer
        //     context.Choferes.Update(chofer);
        //     context.SaveChanges();
        //     // Se redirige a la página de inicio
        //     return Redirect("/");
        // }
    }
}
