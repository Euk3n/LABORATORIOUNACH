public interface IMateria
{
 Task<bool> InsertarMateria(Materia materia);
    Task<string> ActualizarMateria(Materia materia);
    Task<bool> EliminarMateria(Materia materia);
    Task<List<Control>> ConsultarMateria(Materia materia);
}     