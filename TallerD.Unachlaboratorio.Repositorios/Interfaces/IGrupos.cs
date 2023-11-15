public interface IGrupos
{
    Task<bool> InsertarGrupos(Grupos grupos);
    Task<string> ActualizarGrupos(Grupos grupos);
    Task<bool> EliminarGrupos(Grupos grupos);
    Task<List<Control>> ConsultarGrupos(Grupos grupos);
}
