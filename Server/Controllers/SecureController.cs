using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("api/[controller]")]
public class SecureDataController : ControllerBase
{
    [HttpGet("GetAdminData")]
    public IActionResult GetSecureData()
    {
        return Ok("This is secure data in a controller only accessible by administrators.");
    }
}