using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("Api/Control")]
public class ControlController : ControllerBase
{
	private readonly IControlService _controlService;

	public ControlController(IControlService controlService)
	{
    	_controlService = controlService;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<Control>>> GetControls()
	{
    	return Ok(await _controlService.GetControls());
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Control>> GetControl(Guid id)
	{
    	var control = await _controlService.GetControl(id);
    	if (control == null)
    	{
        	return NotFound();
    	}
    	return Ok(control);
	}

	[HttpPost]
	public async Task<ActionResult<Control>> InsertControl(Control control)
	{
    	var createdControl = await _controlService.InsertControl(control);
    	return CreatedAtAction(nameof(GetControl), new { id = createdControl.Id }, createdControl);
	}

	[HttpPut("{id}")]
	public async Task<ActionResult<Control>> UpdateControl(Guid id, Control control)
	{
    	if (id != control.Id)
    	{
        	return BadRequest();
    	}
    	var updatedControl = await _controlService.UpdateControl(id, control);
    	return Ok(updatedControl);
	}

	[HttpDelete("{id}")]
	public async Task<ActionResult<Control>> DeleteControl(Guid id)
	{
    	var control = await _controlService.DeleteControl(id);
    	if (control == null)
    	{
        	return NotFound();
    	}
    	return Ok(control);
	}
}
