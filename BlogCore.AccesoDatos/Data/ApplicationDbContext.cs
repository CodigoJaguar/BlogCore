using BlogCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Poner aquí todos los modelos que se vayan creando
        public DbSet<Categoria> Categoria {  get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<CodigoResultado> CodigoResultados { get; set; }
        public DbSet<CodigoCausaNoPago> CodigoCausaNoPagos { get; set; }
        public DbSet<Asociacion> Asociaciones { get; set; }
        public DbSet<AsociacionResultado> AsociacionResultados { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AsociacionResultado>()
                .HasKey(ar => new { ar.CodigoResultadoId, ar.AsociacionId });
        }


    }



}
