public interface ILogin
{
    Task<bool> IniciarSesion(User user);
}