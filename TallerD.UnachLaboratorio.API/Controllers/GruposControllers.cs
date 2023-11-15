[ApiController]
[Route("Api/Grupos")]
public class GruposController : ControllerBase
{
    IGrupos _GruposService;
    public GruposController(IGrupos grupos)
    {
        _GruposService = grupos;
    }

    [HttpPost("CrearGrupo")]
    public async Task<IActionResult> CrearGrupo(Grupos grupo)
    {
        var resultado = await _GruposService.CrearGrupo(grupo);
        return Ok(resultado);
    }

    [HttpGet("LeerGrupo/{id}")]
    public async Task<IActionResult> LeerGrupo(Guid id)
    {
        var resultado = await _GruposService.LeerGrupo(id);
        return Ok(resultado);
    }

    [HttpPut("ActualizarGrupo")]
    public async Task<IActionResult> ActualizarGrupo(Grupos grupo)
    {
        var resultado = await _GruposService.ActualizarGrupo(grupo);
        return Ok(resultado);
    }

    [HttpDelete("EliminarGrupo/{id}")]
    public async Task<IActionResult> EliminarGrupo(Guid id)
    {
        var resultado = await _GruposService.EliminarGrupo(id);
        return Ok(resultado);
   }
}