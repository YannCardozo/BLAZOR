using Justo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Justo.Data.Mapping
{
    public class Advogado_especialidade_completoMap : IEntityTypeConfiguration<Advogado_especialidade_completo>
    {

        public void Configure(EntityTypeBuilder<Advogado_especialidade_completo> builder)
        {
            // Tabela
            builder.ToTable("Advogados_Especialidades_Completos");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Advogados_Especialidades_Completos");


            builder
                .Property(o => o.Nome_advogado_completo)
                .HasColumnName("Nome_advogado_completo")
                .HasColumnType("varchar")
                .HasMaxLength(35);


            builder
                .Property(o => o.Nome_especialidade_completo)
                .HasColumnName("Nome_especialidade_completo")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            builder
                .Property(o => o.Oab_especialidade_completo)
                .HasColumnName("Oab_especialidade_completo")
                .HasColumnType("varchar")
                .HasMaxLength(6);

            builder
                .Property(o => o.Oab_uf_especialidade_completo)
                .HasColumnName("Oab_uf_especialidade_completo")
                .HasColumnType("varchar")
                .HasMaxLength(2);

            builder
                .Property(o => o.Cpf_especialidade_completo)
                .HasColumnName("Cpf_especialidade_completo")
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder
                .Property(o => o.Status_Oab_Ativo_completo)
                .HasColumnName("Status_Oab_Ativo_completo")
                .HasColumnType("bit");




            ////chave estrangeira
            builder
                .Property(o => o.AdvogadoId)
                .HasColumnName("AdvogadoId")
                .HasColumnType("int");

            builder
                .Property(o => o.Advogado_especialidade_Id)
                .HasColumnName("Advogado_especialidade_Id")
                .HasColumnType("int");

            //public string  { get; set; }
            //public string  { get; set; }
            //public string Oab_especialidade_completo { get; set; }
            //public string Oab_uf_especialidade_completo { get; set; }
            //public string Cpf_especialidade_completo { get; set; }
            //public string Status_Oab_Ativo_completo { get; set; }

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
