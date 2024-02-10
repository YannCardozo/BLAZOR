using Justo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Justo.Data.Mapping
{
    public class Advogado_especialidadeMap : IEntityTypeConfiguration<Advogado_especialidade>
    {

        public void Configure(EntityTypeBuilder<Advogado_especialidade> builder)
        {
            // Tabela
            builder.ToTable("Advogados_Especialidades");

            builder
                .HasKey(o => o.Id)
                .HasName("PK_Advogados_Especialidades");

            builder
                //precisa do identity? para associar o cliente a  
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                //.UseIdentityColumn()
                .HasColumnType("int");


            builder
                .Property(o => o.Nome_area_direito)
                .HasColumnName("Nome_area_direito")
                .HasColumnType("varchar")
                .HasMaxLength(35);


            //builder
            //    .Property(o => o.Nome_advogado)
            //    .HasColumnName("Nome_advogado")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(35);

            //builder
            //    .Property(o => o.Nome_especialidade)
            //    .HasColumnName("Nome_especialidade")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(25);

            //builder
            //    .Property(o => o.Oab_especialidade)
            //    .HasColumnName("Oab_especialidade")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(6);

            //builder
            //    .Property(o => o.Oab_uf_especialidade)
            //    .HasColumnName("Oab_uf_especialidade")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(2);

            //builder
            //    .Property(o => o.Cpf_especialidade)
            //    .HasColumnName("Cpf_especialidade")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(11);

            //builder
            //    .Property(o => o.Status_Oab_Ativo)
            //    .HasColumnName("Status_Oab_Ativo")
            //    .HasColumnType("bit");

            ////chave estrangeira
            builder
                .Property(o => o.AdvogadoId)
                .HasColumnName("AdvogadoId")
                .HasColumnType("int");

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
