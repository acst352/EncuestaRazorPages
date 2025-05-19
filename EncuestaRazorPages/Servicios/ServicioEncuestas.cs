using EncuestaRazorPages.Models;

namespace EncuestaRazorPages.Servicios
{
    public class ServicioEncuestas
    {
        public List<Encuesta> Encuestas { get; set; }
        public void Agregar(Encuesta encuesta)
        {
            Encuestas.Add(encuesta);
        }
    }
}
