namespace Intelligreen.Domain.Entity;

public class Cuidado
{
    public Guid CuidadoId { get; set; }
    public string Descripcion { get; set; } = null!;
    public Guid PlantaId { get; set; }
}