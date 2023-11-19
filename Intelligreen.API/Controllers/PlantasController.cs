using Intelligreen.Application;
using Intelligreen.Application.Commands.Plantas;
using Intelligreen.Application.Queries.Plantas;
using Intelligreen.Domain.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Intelligreen.API.Controllers;

public class PlantasController : BaseController
{
    public PlantasController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IList<Planta>> GetPlantas()
    {
        return await Mediator.Send(new ConsultarPlantasQuery());
    }

    [HttpPost]
    public async Task<ActionResult> PostPlantas(CrearPlantaCommand crearPlantaCommand)
    {
        await Mediator.Send(crearPlantaCommand);

        return Ok();
    }
}