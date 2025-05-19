using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EncuestaRazorPages.Pages
{
    public class TagHelpersModel : PageModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Correo Electronico")]
        public string CorreoElectronico { get; set; }
        public void OnGet()
        {
        }
    }
}
