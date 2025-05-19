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
        [BindProperty]
        public int PersonaSeleccionada { get; set; }
        public List<Persona> Personas { get; set; }
        public int MyProperty { get; set; }

        public  EstadoDocumento Estado { get; set; }
        [MinLength(5)]
        [MaxLength(500)]
        public string Observaciones { get; set; }
        public void OnGet()
        {
            Personas = new List<Persona>
            {
                new Persona {Id =1, Nombre="George"},
                new Persona {Id =2, Nombre="John"},
                new Persona {Id =3, Nombre="Paul"},
                new Persona {Id =4, Nombre="Ringo"},
            };
        }
    }

}