using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Justo.Models
{
    public class Processos_ClientesReuMap : IEntityTypeConfiguration<Processos_ClientesReu>
    {
        public void Configure(EntityTypeBuilder<Processos_ClientesReu> builder)
        {
            builder.HasKey(c => new
            {
                c.ProcessoId,
                c.ClienteId
            });

            builder.HasOne(c => c.Processo).WithMany(c => c.Processos_ClientesReu).HasForeignKey(c => c.ProcessoId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(c => c.Cliente).WithMany(c => c.Processos_ClientesReu).HasForeignKey(c => c.ClienteId).OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class Processos_ClientesReu
    {


        public int ProcessoId { get; set; }
        public Processos? Processo { get; set; }






        public int ClienteId { get; set; }
        public Clientes? Cliente { get; set; }


        public DateTime? DataEntrouNoProcesso { get; set; }

    }
}
