using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestMediatR.Api;

namespace TestMediatR.Controllers;
[Route("api/[controller]")]
[ApiController]
public class Test(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async  Task<IActionResult> Get()
    {
        return Ok(await mediator.Send(new QueryStudent()));
    }

    [HttpGet("{StudNo}")]
    public async Task<IActionResult> Get(string StudNo)
    {
        return Ok(await mediator.Send(new QueryStudentByNo(StudNo)));
    }
}