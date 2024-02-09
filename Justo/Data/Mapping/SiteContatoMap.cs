using Justo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Justo.Data.Mapping
{
    public class SiteContatoMap : IEntityTypeConfiguration<Site_contato>
    {

        public void Configure(EntityTypeBuilder<Site_contato> builder)
        {
            // Tabela
            builder.ToTable("Site_contato");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Site_contato");

            //entidadebase

            builder
                //precisa do identity? para associar o cliente a  tabela de usuarios login
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                //.UseIdentityColumn()
                .HasColumnType("int");

            builder
                .Property(o => o.Nome_contato)
                    .HasColumnName("Nome_contato")
                    .HasColumnType("varchar")
                    .HasMaxLength(35);

            builder
                .Property(o => o.Telefone_contato)
                    .HasColumnName("Telefone_contato")
                    .HasColumnType("varchar")
                    .HasMaxLength(11);

            builder
                .Property(o => o.Email_contato)
                    .HasColumnName("Email_contato")
                    .HasColumnType("varchar")
                    .HasMaxLength(35);

            builder
                .Property(o => o.Assunto_contato)
                    .HasColumnName("Assunto_contato")
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

            builder
                .Property(o => o.Conteudo_contato)
                    .HasColumnName("Conteudo_contato")
                    .HasColumnType("varchar")
                    .HasMaxLength(300);

            builder
                .Property(o => o.Tipo_causa_contato)
                    .HasColumnName("Tipo_causa_contato")
                    .HasColumnType("varchar")
                    .HasMaxLength(35);

            //booleana
            builder
                .Property(o => o.Analisado_contato)
                    .HasColumnName("Analisado_contato")
                    .HasColumnType("bit");



            //entidadebase

            builder
                .Property(o => o.datacadastro)
                .HasColumnName("data_cadastro")
                .HasColumnType("datetime2");

            builder
                .Property(o => o.dataatualizacao)
                    .HasColumnName("data_atualizacao")
                    .HasColumnType("datetime2");

            builder
                .Property(o => o.cadastradopor)
                    .HasColumnName("cadastradopor")
                    .HasColumnType("int");

            builder
                .Property(o => o.atualizadopor)
                    .HasColumnName("atualizadopor")
                    .HasColumnType("int");

        }
    }
}
