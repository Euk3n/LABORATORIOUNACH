public interface ILaboratorio
{
     Task<bool> InsertarLaboratorio(Laboratorio laboratorio);
    Task<string> ActualizarLaboratorio(Laboratorio laboratorio);
    Task<bool> EliminarLaboratorio(Laboratorio laboratorio);
    Task<List<Control>> ConsultarLaboratorio(Laboratorio laboratorio);
}