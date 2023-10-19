using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/Seguridad")]
public class SeguridadController:ControllerBase
{
    ILogin _LoginService;
    public SeguridadController(ILogin login)
    {
        _LoginService=login;
    }


    [HttpPost("IniciarSesion")]
    public IActionResult IniciarSesion(User user)
    {
        var resultado=_LoginService.IniciarSesion(user);
        return Ok(true);
    }
}