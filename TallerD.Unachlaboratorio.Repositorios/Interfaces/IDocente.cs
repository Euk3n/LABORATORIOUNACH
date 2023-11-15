public interface IDocente
{
    Task<bool> InsertarDocente(Docente docente);
    Task<string> ActualizarDocente(Docente docente);
    Task<bool> EliminarDocente(Docente docente);
    Task<List<Control>> ConsultarControlDocente(Docente docente);
}