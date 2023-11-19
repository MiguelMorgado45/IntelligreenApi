using Intelligreen.Domain.Entity;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Intelligreen.Application.Queries.Plantas;

public class ConsultarPlantasQuery : IRequest<IList<Planta>>
{
}

public class ConsultarPlantasQueryHandler : IRequestHandler<ConsultarPlantasQuery, IList<Planta>>
{
    private readonly ApplicationDbContext _context;

    public ConsultarPlantasQueryHandler(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IList<Planta>> Handle(ConsultarPlantasQuery request, CancellationToken cancellationToken)
    {
        return await _context.Plantas.ToListAsync(cancellationToken);
    }
}