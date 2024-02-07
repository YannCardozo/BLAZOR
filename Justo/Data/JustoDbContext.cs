using Justo.Data.Mapping;
using Justo.Models;
using Microsoft.EntityFrameworkCore;

namespace Justo.Data
{
    public class JustoDbContext : DbContext
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

            //modelBuilder.Entity<Clientes>()
            //    .HasOne(c => c.Endereco_cliente)
            //    .WithOne(e => e.Cliente)
            //    .HasForeignKey<Endereco>(e => e.ClienteId);




            //    modelBuilder.Entity<Clientes>()
            //        .HasMany(c => c.Enderecos)
            //        .WithOne()
            //        .HasForeignKey(e => e.ClienteId);

            //    // Se você quiser uma relação bidirecional, pode adicionar o seguinte:
            //    modelBuilder.Entity<Endereco>()
            //        .HasOne(e => e.Cliente)
            //        .WithMany(c => c.Enderecos)
            //        .HasForeignKey(e => e.ClienteId);
            //
        }
    }
}
