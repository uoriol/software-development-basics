using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoftwareDevelopmentCenter.Shared;

namespace SoftwareDevelopmentCenter.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class RequestController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<RequestController> _logger;

    public RequestController(ILogger<RequestController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetPublicData")]
    public IActionResult GetPublicData()
    {
        return Ok("Public data");
    }

    [HttpGet("GetPrivateData")]
    [Authorize]
    public IActionResult GetPrivateData()
    {
        return Ok("Private data");
    }
}
