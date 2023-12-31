using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Intelligreen.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BaseController : ControllerBase
{
    protected readonly IMediator Mediator;

    public BaseController(IMediator mediator)
    {
        Mediator = mediator;
    }
}