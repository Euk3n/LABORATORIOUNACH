public interface IHorarioDocente
{
     Task<bool> InsertarHorarioDocente(HorarioDocente horariodocente);
    Task<string> ActualizarHorarioDocente(HorarioDocente horariodocente);
    Task<bool> EliminarHorarioDocente(HorarioDocente horariodocente);
    Task<List<Control>> ConsultarHorarioDocente(HorarioDocente horariodocente);
}