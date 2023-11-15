ApiController]
[Route("Api/Materia")]
public class MateriaController : ControllerBase
{
	IMateria _MateriaService;
	public MateriaController(IMateria materia)
	{
    	_MateriaService = materia;
	}

	[HttpPost("CrearMateria")]
	public async Task<IActionResult> CrearMateria(Materia materia)
	{
    	var resultado = await _MateriaService.CrearMateria(materia);
    	return Ok(resultado);
	}

	[HttpGet("LeerMateria/{id}")]
	public async Task<IActionResult> LeerMateria(Guid id)
	{
    	var resultado = await _MateriaService.LeerMateria(id);
return Ok(resultado);
	}

	[HttpPut("ActualizarMateria")]
	public async Task<IActionResult> ActualizarMateria(Materia materia)
	{
    	var resultado = await _MateriaService.ActualizarMateria(materia);
    	return Ok(resultado);
	}

	[HttpDelete("EliminarMateria/{id}")]
	public async Task<IActionResult> EliminarMateria(Guid id)
	{
    	var resultado = await _MateriaService.EliminarMateria(id);
    	return Ok(resultado);
	}
}


