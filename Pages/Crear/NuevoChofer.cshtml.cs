using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transportes_Mardones_Torres;
namespace MyApp.Namespace
{
    public class NuevoChoferModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(string nombre, string apellido, bool disponibilidad)
        {
            Chofer chofer = new Chofer();
            chofer.Nombre = nombre;
            chofer.Apellido = apellido;
            chofer.Disponibilidad = disponibilidad;
            
            TransporteContext context = new TransporteContext();
            context.Choferes.Add(chofer);
            context.SaveChanges();

            Response.Redirect("/Listar/ListarChoferes");
        }
    }
}
