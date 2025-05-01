using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SoftwareDevelopmentCenter.Shared.Authorization.Classes;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private List<User> ExistingUsersRepository = new List<User>
    {
        new User("User 1", "user_1", "user1_123"),
        new User("User 0", "user_0", "user0_123", SecurityRoleEnum.ADMINISTRATOR)
    };
    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginParams login)
    {
        // Validate the login credentials (username and password)
        User? user = ExistingUsersRepository.Where(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();

        if (user == null) return Unauthorized();

        // Create claims based on user information
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.DisplayName),
            new Claim(ClaimTypes.Role, user.SecurityRole)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("CCLuT6RXiK3Tb34wSbTf8yJ5cvC1Tyqy"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: "YourIssuer",
            audience: "YourAudience",
            claims: claims,
            expires: DateTime.Now.AddMinutes(50),
            signingCredentials: creds);

        return Ok(new JwtSecurityTokenHandler().WriteToken(token));
    }
}
