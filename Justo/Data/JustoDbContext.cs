using Justo.Data.Mapping;
using Justo.Models;
using Microsoft.EntityFrameworkCore;

namespace Justo.Data
{
    public class JustoDbContext : DbContext
    {


        public JustoDbContext(DbContextOptions<JustoDbContext> options) : base(options)
        {



        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Justo;Trusted_Connection=True;TrustServerCertificate=true;");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ClientesMap());

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
