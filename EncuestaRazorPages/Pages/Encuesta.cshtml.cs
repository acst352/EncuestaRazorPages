using EncuestaRazorPages.Models;
using EncuestaRazorPages.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// Técnica de inyección de dependencias por constructor para tener acceso al servicio Encuesta
namespace EncuestaRazorPages.Pages
{
    public class EncuestaModel : PageModel
    {
        private readonly ServicioEncuestas _servicioEncuesta;
        public EncuestaModel(ServicioEncuestas servicioEncuesta)
        {
            _servicioEncuesta = servicioEncuesta;
        }
        // Declaración de Objeto o propiedad Encuesta
        [BindProperty] // Permite enlazar la propiedad al enviarla al servidor mediante el método OnPost.
                       // Permite el binding automático de los datos del formulario a la propiedad Encuesta durante el POST.
        public Encuesta Encuesta { get; set; }

        // El Manejador OnGet muestra la página
        public void OnGet()
        {
        }
        // El método OnPost guarda una nueva encuesta
        public IActionResult OnPost()
        {
            _servicioEncuesta.Agregar(Encuesta);
            // Redireccionar a página Gracias
            return RedirectToPage("Gracias");
        }
    }
}
