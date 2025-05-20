using EncuestaRazorPages.Models;

namespace EncuestaRazorPages.Servicios
{
    public class ServicioEncuestas
    {
        public List<Encuesta> Encuestas { get; set; } = new List<Encuesta>();
        // Inicializa la lista Encuestas al crear una instancia de ServicioEncuestas.
        // Siempre habrá una lista válida (no nula) para agregar elementos.
        // El método Agregar nunca lanzará excepciones por referencia nula.

        internal void Agregar(Encuesta encuesta)
        {
            Encuestas.Add(encuesta);
        }
    }
}
