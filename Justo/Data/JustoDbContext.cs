using Justo.Data.Mapping;
using Justo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Justo.Data
{
    public class JustoDbContext : IdentityDbContext
    {

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Advogado_especialidade> Advogados_Especialidades { get; set; }


        //public JustoDbContext(DbContextOptions<JustoDbContext> options) : base(options)
        //{



        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Justo;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Justo-ADV");
            builder.ApplyConfiguration(new ClientesMap());
            builder.ApplyConfiguration(new AdvogadoMap());
            builder.ApplyConfiguration(new SiteContatoMap());



            //definindo relacionamentos: 

            //um para um
            builder.Entity<Advogado>()
                .HasOne(a => a.Advogado_Especialidades)

            //muitos para muitos




        }
    }
}
