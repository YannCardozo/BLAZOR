using Justo.Data.Mapping;
using Justo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Justo.Data
{
    public class JustoDbContext : IdentityDbContext
    {

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Advogado_especialidade> Advogados_Especialidades { get; set; }
        public DbSet<Advogado_especialidade_completo> Advogados_Especialidades_Completo { get; set; }


        public JustoDbContext(DbContextOptions<JustoDbContext> options) : base(options)
        {



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Justo;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Justo-ADV");
            builder.ApplyConfiguration(new ClientesMap());
            builder.ApplyConfiguration(new AdvogadoMap());
            builder.ApplyConfiguration(new Advogado_especialidadeMap());
            builder.ApplyConfiguration(new Advogado_especialidade_completoMap());
            builder.ApplyConfiguration(new SiteContatoMap());


            //relacionamentos das tabelas

            //falta implementar cascade delete nas tabelas em seus relacionamentos

            //um advogado tem muitas especialidades.
            builder.Entity<Advogado>()
                .HasMany<Advogado_especialidade_completo>(a => a.Advogados_Especialidades_Completos_ADV)
                .WithOne()
                .HasForeignKey(ae => ae.AdvogadoId);


            //uma especialidade tem muitos.
            builder.Entity<Advogado_especialidade>()
                .HasMany<Advogado_especialidade_completo>(a => a.Advogados_Especialidades_Completos_ESPEC)
                .WithOne()
                .HasForeignKey(ae => ae.Advogado_especialidade_Id);


            builder.Entity<Advogado_especialidade_completo>()
                .HasMany<Advogado>(ae => ae.Advogados)
                .WithOne()
                .HasForeignKey(a => a.Advogado_especialidade_Completo_Id);

            builder.Entity<Advogado_especialidade_completo>()
                .HasOne<Advogado_especialidade>(ae => ae.Advogado_Especialidades)
                .WithMany(ae => ae.Advogados_Especialidades_Completos_ESPEC)
                .HasForeignKey(ae => ae.Advogado_especialidade_Id);

        }
    }
}
