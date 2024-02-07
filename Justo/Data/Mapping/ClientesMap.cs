using Justo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Justo.Data.Mapping
{
    public class ClientesMap : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            // Tabela
            builder.ToTable("Clientes");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Clientes");

            //falta mapear atributos e chaves estrangeiras

            //entidadebase

            builder
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder
                .Property(o => o.Nome_cliente)
                .HasColumnName("Nome_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(80);


            builder
                .Property(o => o.Cpf_cliente)
                .HasColumnName("Cpf_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder
                .Property(o => o.Rg_cliente)
                .HasColumnName("Rg_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(9);

            builder
                .Property(o => o.Cnh_cliente)
                .HasColumnName("Cnh_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired(false);

            //se relacionar com o envio de arquivos pelo ftp na tabela , vincular o id
            //do envio de arquivos com o FTP
            builder
                .Property(o => o.Contrato_social_cliente)
                .HasColumnName("Contrato_social_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder
                .Property(o => o.Cnpj_cliente)
                .HasColumnName("Cnpj_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);


            builder
                .Property(o => o.Certificado_reservista_cliente)
                .HasColumnName("Certificado_reservista_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);

            builder
                .Property(o => o.Procuracao_representacao_legal_cliente)
                .HasColumnName("Procuracao_representacao_legal_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(30)
                .IsRequired(false);

            builder
                .Property(o => o.Genero)
                .HasColumnName("Genero")
                .HasColumnType("varchar")
                .HasMaxLength(13);

            builder
                .Property(o => o.Data_nascimento)
                .HasColumnName("Data_nascimento")
                .HasColumnType("datetime2");

            builder
                .Property(o => o.Ocupacao)
                .HasColumnName("Ocupacao")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.Nacionalidade)
                .HasColumnName("Nacionalidade")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            builder
                .Property(o => o.Estado_civil)
                .HasColumnName("Estado_civil")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            builder
                .Property(o => o.Banco)
                .HasColumnName("Banco")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.Agencia_bancaria)
                .HasColumnName("Agencia_bancaria")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.Telefone_cliente)
                .HasColumnName("Telefone_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder
                .Property(o => o.Contato_de_confianca_cliente)
                .HasColumnName("Contato_de_confianca_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(35)
                .IsRequired(false);

            builder
                .Property(o => o.Email_cliente)
                .HasColumnName("Email_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            builder
                .Property(o => o.Tipo_cliente)
                .HasColumnName("Tipo_cliente")
                .HasColumnType("varchar")
                .HasMaxLength(2);

            //public Endereco Endereco_cliente { get; set; }

            builder
                .HasOne(o => o.Endereco_cliente)  // Define o relacionamento
                .WithOne()                        // O relacionamento é de um para um (um cliente tem um endereço)
                .HasForeignKey<Endereco>(e => e.ClienteId);  // Define a chave estrangeira na entidade Endereco

            
            //chave estrangeira
            //builder
            //    .HasOne(o => o.Endereco_cliente)
            //    .WithOne()
            //    .HasForeignKey<Endereco>(e => e.ClienteId)
            //    .IsRequired(false); // Indica que a relação é opcional, ou seja, EnderecoId pode ser nulo

            //builder
            //    .HasOne(o => o.Processo)
            //    .WithMany()
            //    .HasForeignKey(o => o.ProcessoId)
            //    .IsRequired(false); // Indica que a relação é opcional, ou seja, ProcessoId pode ser nulo





            //chaves estrangeiras
            //public int EnderecoId { get; set; }
            //public int ProcessoId { get; set; }





            // .IsRequired(false);

            //// Propriedades
            //builder.Property(x => x.)
            //    .IsRequired()
            //    .HasColumnName("Name")
            //    .HasColumnType("NVARCHAR")
            //    .HasMaxLength(80);

            //builder.Property(x => x.Slug)
            //    .IsRequired()
            //    .HasColumnName("Slug")
            //    .HasColumnType("VARCHAR")
            //    .HasMaxLength(80);

            //// Índices
            //builder
            //    .HasIndex(x => x.Slug, "IX_Category_Slug")
            //    .IsUnique();


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
