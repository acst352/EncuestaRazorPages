namespace EncuestaRazorPages.Pages;

public class Persona
{
    public int Id { get; internal set; }
    public string Nombre { get; internal set; }
}
public enum EstadoDocumento
{
    Iniciado = 1,
    EnRevision = 2,
    Rechazado = 3,
    Cancelado = 4,
    Aprobado = 5
}