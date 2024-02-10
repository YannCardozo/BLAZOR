using Justo.Data.Mapping;
using Justo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Emit;

namespace Justo.Data
{
    public class JustoDbContext : DbContext
    {
        public JustoDbContext(DbContextOptions<JustoDbContext> options) : base(options)
        {



        }
        public DbSet<Clientes> Clientes { get; set; }

        //clientes se relaciona a enderecos e se relaciona a arquivos_clientes_uploads
        //public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Advogado> Advogados { get; set; }
        public DbSet<Advogado_especialidade> Advogados_Especialidades { get; set; }
        public DbSet<Advogado_especialidade_completo> Advogados_Especialidades_Completo { get; set; }
        public DbSet<Site_contato> Site_Contatos { get; set; }
        //public DbSet<Arquivos_cliente_upload> Arquivos_Clientes_Uploads { get; set; }
        //public DbSet<Processos> Processos { get; set; }
        //public DbSet<Processos_Despesa> Processos_Despesas { get; set; }
        //public DbSet<Processos_Atualizacao> Processos_Atualização { get; set; }
        //public DbSet<Processos_compromissos> Processos_Compromissos { get; set; }

        //vai precisa se relacionar  site_contato a clientes.

        //Processos vai se relacionar a ADVOGADOS e CLIENTES




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Justo;Trusted_Connection=True;TrustServerCertificate=true;");

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("Justo-ADV");
            builder.ApplyConfiguration(new ClientesMap());
            builder.ApplyConfiguration(new AdvogadoMap());
            builder.ApplyConfiguration(new Advogado_especialidadeMap());
            builder.ApplyConfiguration(new Advogado_especialidade_completoMap());
            builder.ApplyConfiguration(new Site_ContatoMap());


            //relacionamentos das tabelas

            //falta implementar cascade delete nas tabelas em seus relacionamentos

            //um advogado tem muitas especialidades.
            builder.Entity<Advogado>()
                .HasMany<Advogado_especialidade_completo>(a => a.Advogados_Especialidades_Completos_ADV)
                .WithOne()
                .HasForeignKey(ae => ae.AdvogadoId)
                .OnDelete(DeleteBehavior.Cascade);


            //uma especialidade_completo vai ter muitas especialidades.
            builder.Entity<Advogado_especialidade>()
                .HasMany<Advogado_especialidade_completo>(a => a.Advogados_Especialidades_Completos_ESPEC)
                .WithOne()
                .HasForeignKey(ae => ae.Advogado_especialidade_Id)
                .OnDelete(DeleteBehavior.Cascade);

            //uma especialidade_completo vai ter muitos advogados
            builder.Entity<Advogado_especialidade_completo>()
                .HasMany(ae => ae.Advogados)
                .WithOne()
                .HasForeignKey(a => a.Advogado_especialidade_Completo_Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Advogado_especialidade_completo>()
                .HasOne<Advogado_especialidade>(ae => ae.Advogado_Especialidades)
                .WithMany(ae => ae.Advogados_Especialidades_Completos_ESPEC)
                .HasForeignKey(ae => ae.Advogado_especialidade_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
