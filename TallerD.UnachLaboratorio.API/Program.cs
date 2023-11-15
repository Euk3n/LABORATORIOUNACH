
using TallerD.Unachlaboratorio.Helpers;


internal class Programs
{

    private static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddTransient<IControl, ControlService>();
        builder.Services.AddTransient<IDocente, DocenteService>();
        builder.Services.AddTransient<IGrupos, GruposService>();
        builder.Services.AddTransient<IHorarioDocente, HorarioDocenteService>();
        builder.Services.AddTransient<ILaboratorio, LaboratorioService>();
        builder.Services.AddTransient<IMateria, MateriaService>();
        builder.Services.AddTransient<ISolicitud, SolicitudService>();


        
        
        //Inyeccion de dependencias
        builder.Services.AddTransient<ILogin, LoginService>();
        ContextoConfiguracion.CadenaDB = builder.Configuration.GetConnectionString("CadenaConexion")??"";
        // Add services to the container. 

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();




        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}