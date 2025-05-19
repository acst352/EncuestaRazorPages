using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EncuestaRazorPages.Pages
{
    public class TagHelpersModel : PageModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name = "Correo Electronico")]
        public string CorreoElectronico { get; set; }

        public List<SelectListItem> Numeros = Enumerable.Range(1, 10).Select(n => new SelectListItem
        {
            Value = n.ToString(),
            Text = n.ToString()
        }).ToList();

        public int NumeroSeleccionado { get; set; } = 7;
        public void OnGet()
        {
        }
    }
}
