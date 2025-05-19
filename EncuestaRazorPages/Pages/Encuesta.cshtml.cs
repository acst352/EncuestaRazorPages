using EncuestaRazorPages.Models;
using EncuestaRazorPages.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EncuestaRazorPages.Pages
{
    public class EncuestaModel : PageModel
    {
        private readonly ServicioEncuestas _servicioEncuesta;
        public EncuestaModel(ServicioEncuestas servicioEncuesta)
        {
            _servicioEncuesta = servicioEncuesta;
        }
        [BindProperty]
        public Encuesta Encuesta { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _servicioEncuesta.Agregar(Encuesta);
            return RedirectToPage("Gracias");
        }
    }
}
