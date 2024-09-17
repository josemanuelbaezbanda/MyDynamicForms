using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MyDynamicForms.Models;
using MyDynamicForms.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using MyDynamicForms.Models.Context;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IConfiguration _configuration;
    private readonly DbmyFormsContext _dbContext;

    public AuthController(UserManager<IdentityUser> userManager, IConfiguration configuration, DbmyFormsContext dbContext)
    {
        _userManager = userManager;
        _configuration = configuration;
        _dbContext = dbContext;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserRegisterDTO user)
    {
        string username = (user.Name + user.LastName).ToUpper().Replace(" ","");
        IdentityResult result = await _userManager.CreateAsync(new IdentityUser { UserName = username}, user.Password);
        User newUser = new User { Name = user.Name, LastName = user.LastName, Username = username };
        _dbContext.Users.Add(newUser);
        int affected = await _dbContext.SaveChangesAsync();

        if (affected > 0) return BadRequest(result.Errors);

        return Ok(new { result = "User created successfully!" });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UserLoginDTO dto)
    {
        var user = await _userManager.FindByNameAsync(dto.Username);

        if (user == null || !await _userManager.CheckPasswordAsync(user, dto.Password))
            return Unauthorized("Invalid credentials");

        var token = GenerateJwtToken(user);

        return Ok(new { token });
    }

    private string GenerateJwtToken(IdentityUser user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["JwtConfig:Secret"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id) }),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
