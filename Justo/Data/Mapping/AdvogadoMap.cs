using Justo.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.Emit;

namespace Justo.Data.Mapping
{
    public class AdvogadoMap : IEntityTypeConfiguration<Advogado>
    {

            public void Configure(EntityTypeBuilder<Advogado> builder)
            {
                // Tabela
                builder.ToTable("Advogados");

                builder
                    .HasKey(o => o.Id)
                    .HasName("PK_Advogados");

                //falta mapear atributos e chaves estrangeiras

                //entidadebase

                builder
                    //precisa do identity? para associar o cliente a  
                    .Property(o => o.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID")
                    //.UseIdentityColumn()
                    .HasColumnType("int");

                builder
                    .Property(o => o.Nome)
                        .HasColumnName("Nome")
                        .HasColumnType("varchar")
                        .HasMaxLength(35);

                builder
                    .Property(o => o.Oab)
                        .HasColumnName("Oab")
                        .HasColumnType("varchar")
                        .HasMaxLength(6);

                builder
                    .Property(o => o.Oab_UF)
                        .HasColumnName("Oab_UF")
                        .HasColumnType("varchar")
                        .HasMaxLength(2);

                builder
                    .Property(o => o.cpf)
                        .HasColumnName("cpf")
                        .HasColumnType("varchar")
                        .HasMaxLength(11);

                builder
                    .Property(o => o.Status_Oab_Ativo)
                    .HasColumnName("Status_Oab_Ativo")
                    .HasColumnType("bit");




                //chaves estrangeiras
                builder
                    .Property(o => o.ProcessosId)
                    .HasColumnName("ProcessosId")
                    .HasColumnType("int");
                builder
                    .Property(o => o.Advogado_especialidade_Completo_Id)
                    .HasColumnName("Advogado_especialidade_Completo_Id")
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
