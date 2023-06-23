using Microsoft.AspNetCore.Mvc;

namespace web_api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HelloWorldController: ControllerBase
{
    IHelloWordService helloWorlService;

    public HelloWorldController(IHelloWordService helloWord)
    {
        helloWorlService = helloWord;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(helloWorlService.GetHelloWorld());
    }
}