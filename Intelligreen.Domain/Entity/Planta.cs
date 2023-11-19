namespace Intelligreen.Domain.Entity;

public enum Clasificacion
{
    Poca,
    Media,
    Mucha
}

public class Planta
{
    public Guid PlantaId { get; set; }
    public string Nombre { get; set; } = null!;
    public string NombreCientifico { get; set; } = null!;
    public string Descripcion { get; set; } = null!;
    public Clasificacion ClasificacionSol { get; set; }
    public Clasificacion ClasificacionAgua { get; set; }
    public Clasificacion CLasificacionCuidado { get; set; }
    public float HumedadTierra { get; set; }
    public float HumedadAmbiente { get; set; }
    public float TemperaturaAmbiente { get; set; }
    public IList<Cuidado> Cuidados { get; set; }
}