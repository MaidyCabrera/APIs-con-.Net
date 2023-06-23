using Microsoft.AspNetCore.Mvc;
using webapi.Models;

namespace web_api.Controllers;

[Route("api/[controller]")]
public class TareaController : ControllerBase
{
    ItareasService tareasService;

    public TareaController(ItareasService service)
    {
        tareasService = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(tareasService.Get());
    }
}