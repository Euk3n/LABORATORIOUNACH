using Microsoft.EntityFrameworkCore;
using TallerD.Unachlaboratorio.Helpers;

public partial class LabDBContex:DbContext
{
    public virtual DbSet<Docente> Docente { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    if (!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseSqlServer(ContextoConfiguracion.CadenaDB, builder=> {
         builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
     });
        base.OnConfiguring(optionsBuilder);
    }
}
}


