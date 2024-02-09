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
                .Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID")
                .HasColumnType("int");

            builder
                .Property(o => o.Nome_area_direito)
                .HasColumnName("Nome_area_direito")
                .HasColumnType("varchar")
                .HasMaxLength(35);

            ////chave estrangeira
            builder
                .Property(o => o.Advogado_especialidade_completo_Id)
                .HasColumnName("Advogado_especialidade_completo_Id")
                .HasColumnType("int");


        }
    }
}
