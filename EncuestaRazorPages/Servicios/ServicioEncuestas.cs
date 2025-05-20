using EncuestaRazorPages.Models;

namespace EncuestaRazorPages.Servicios
{
    public class ServicioEncuestas
    {
        public List<Encuesta> Encuestas { get; set; } = new List<Encuesta>();

        internal void Agregar(Encuesta encuesta)
        {
            throw new NotImplementedException();
        }
    }
}
