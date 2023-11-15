using TallerD.Unachlaboratorio.BaseDatos;
public class ControlService : IControlService
{
	private readonly LabDBContex _context;

	public ControlService(LabDBContex context)
	{
    	_context = context;
	}

	public async Task<IEnumerable<Control>> GetControls()
	{
    	return await _context.Control.ToListAsync();
	}

	public async Task<Control> GetControl(Guid id)
	{
    	return await _context.Control.FindAsync(id);
	}

	public async Task<Control> InsertControl(Control control)
	{
    	_context.Control.Add(control);
    	await _context.SaveChangesAsync();
    	return control;
	}

	public async Task<Control> UpdateControl(Guid id, Control control)
	{
    	_context.Entry(control).State = EntityState.Modified;
    	await _context.SaveChangesAsync();
    	return control;
	}
    public async Task<Control> DeleteControl(Guid id)
	{
    	var control = await _context.Control.FindAsync(id);
    	_context.Control.Remove(control);
    	await _context.SaveChangesAsync();
    	return control;
	}
}
