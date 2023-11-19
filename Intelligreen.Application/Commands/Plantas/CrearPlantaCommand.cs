using Intelligreen.Domain.Entity;
using MediatR;

namespace Intelligreen.Application.Commands.Plantas;

public class CrearPlantaCommand : IRequest
{
    public string Nombre { get; set; } = null!;
    public string NombreCientifico { get; set; } = null!;
    public string Descripcion { get; set; } = null!;
    public Clasificacion ClasificacionSol { get; set; }
    public Clasificacion ClasificacionAgua { get; set; }
    public Clasificacion CLasificacionCuidado { get; set; }
    public float HumedadTierra { get; set; }
    public float HumedadAmbiente { get; set; }
    public float TemperaturaAmbiente { get; set; }
    public IList<Cuidado> Cuidados { get; set; } = new List<Cuidado>();
}

public class CrearPlantaCommandHandler : IRequestHandler<CrearPlantaCommand>
{
    private readonly ApplicationDbContext _context;

    public CrearPlantaCommandHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(CrearPlantaCommand request, CancellationToken cancellationToken)
    {
        _context.Plantas.Add(new Planta
        {
            PlantaId = Guid.NewGuid(),
            Nombre = request.Nombre,
            NombreCientifico = request.NombreCientifico,
            Descripcion = request.Descripcion,
            HumedadAmbiente = request.HumedadAmbiente,
            HumedadTierra = request.HumedadTierra,
            TemperaturaAmbiente = request.TemperaturaAmbiente,
            ClasificacionAgua = request.ClasificacionAgua,
            ClasificacionSol = request.ClasificacionSol,
            CLasificacionCuidado = request.CLasificacionCuidado,
            Cuidados = request.Cuidados
        });

        await _context.SaveChangesAsync(cancellationToken);
    }
}