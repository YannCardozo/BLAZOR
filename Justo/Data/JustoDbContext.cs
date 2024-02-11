using Justo.Data.Mapping;
using Justo.Models;
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
            builder.ApplyConfiguration(new Site_ContatoMap());


            //relacionamentos das tabelas

            //falta implementar cascade delete nas tabelas em seus relacionamentos

            // Mapeamento da entidade Advogado
            builder.Entity<Advogado>()
                .HasMany(a => a.Advogados_Especialidades_FK) // Um advogado pode ter muitas especialidades
                .WithOne(ae => ae.Advogados_FK) // A especialidade pertence a um único advogado
                .HasForeignKey(ae => ae.AdvogadoId) // Chave estrangeira para AdvogadoId em Advogado_Especialidade
                .OnDelete(DeleteBehavior.Cascade); // Opção de exclusão em cascata, se um advogado for excluído, suas especialidades serão excluídas também


            builder.Entity<Advogado>()
                .HasIndex(ae => ae.Oab)
                .IsUnique();

            builder.Entity<Advogado>()
                .HasIndex(ae => ae.cpf)
                .IsUnique();

            builder.Entity<Advogado_especialidade>()
                .HasOne(ae => ae.Advogados_FK) // Uma especialidade pertence a um único advogado
                .WithMany(a => a.Advogados_Especialidades_FK) // Um advogado pode ter muitas especialidades
                .HasForeignKey(ae => ae.AdvogadoId) // Chave estrangeira para AdvogadoId em Advogado_Especialidade
                .OnDelete(DeleteBehavior.Cascade); // Restringir a exclusão, ou seja, não permitir a exclusão em cascata

        }
    }
}
