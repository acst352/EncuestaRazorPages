using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EncuestaRazorPages.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        /* Page handler, método. 
         * Es el punto de entrada para inicializar datos cuando la página 
         * se carga por primera vez mediante una solicitud GET.
         * Este método solo ejecuta lógica interna y no retorna ningun valor */
        {
        }
    }

}
