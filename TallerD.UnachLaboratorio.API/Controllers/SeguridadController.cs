using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/Seguridad")]
public class SeguridadController:ControllerBase

{
    ILogin _LoginService;
    IConfiguration _configuration;
    public SeguridadController(ILogin login)
    {
        _LoginService=login;
    }


    [HttpPost("IniciarSesion")]
    public IActionResult IniciarSesion(User user)
    {
        var resultado=await _LoginService.IniciarSesion(user);
        if (resultado.Nombre!=null)
        {
            var token=Generartoken(resultado);
            return Ok(token);
        }
        else{
        return BadRequest();
        }
    }

    private string Generartoken (Docente doc)
    {

        /Header
        SymmetricSecurityKey issuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._Configuration["Authentication:Secretkey"]));
        SigningCredentials signingCredentials = new SigningCredentials(issuerSigningKey, SecurityAlgorithms.HmacSha256);
        JwtHeader header = new JwtHeader(signingCredentials);
        //Claims
        Claim[] claims = {
            new Claim(ClaimTypes.Email, resultado.user),
            new Claim(ClaimTypes.Password, resultado.Password)7

        };
        //Payload
        JwtPayload payload = new JwtPayload(
            this._Configuration["Authentication:Issuer"],
            this._Configuration["Authentication:Audience"],
            claims,
            DateTime.Now,
            DateTime.Now.Date.AddDays(1)
                
        );
        JwtSecurityToken token = new JwtSecurityToken(header, payload);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

