public interface IControlService
{
	Task<IEnumerable<Control>> GetControls();
	Task<Control> GetControl(Guid id);
	Task<Control> InsertControl(Control control);
	Task<Control> UpdateControl(Guid id, Control control);
	Task<Control> DeleteControl(Guid id);
}
