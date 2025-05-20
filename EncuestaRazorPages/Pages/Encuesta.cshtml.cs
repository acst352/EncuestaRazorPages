using EncuestaRazorPages.Models;
using EncuestaRazorPages.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

// T�cnica de inyecci�n de dependencias por constructor para tener acceso al servicio Encuesta
namespace EncuestaRazorPages.Pages
{
    public class EncuestaModel : PageModel
    {
        private readonly ServicioEncuestas _servicioEncuesta;
        public EncuestaModel(ServicioEncuestas servicioEncuesta)
        {
            _servicioEncuesta = servicioEncuesta;
        }
        // Declaraci�n de Objeto o propiedad Encuesta
        [BindProperty] // Permite enlazar la propiedad al enviarla al servidor mediante el m�todo OnPost.
                       // Permite el binding autom�tico de los datos del formulario a la propiedad Encuesta durante el POST.
        public Encuesta Encuesta { get; set; }

        // El Manejador OnGet muestra la p�gina
        public void OnGet()
        {
        }
        // El m�todo OnPost guarda una nueva encuesta
        public IActionResult OnPost()
        {
            _servicioEncuesta.Agregar(Encuesta);
            // Redireccionar a p�gina Gracias
            return RedirectToPage("Gracias");
        }
    }
}
