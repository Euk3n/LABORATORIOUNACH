public interface ISolicitud
{
    Task<bool> InsertarSolicitud(Solicutid solicitud);
    Task<string> ActualizarSolicitud(Solicutid solicitud);
    Task<bool> EliminarSolicitud(Solicutid solicitud);
    Task<List<Control>> ConsultarSolicitud(Solicutid solicitud);
}