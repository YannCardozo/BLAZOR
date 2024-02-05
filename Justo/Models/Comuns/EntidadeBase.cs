using System.ComponentModel.DataAnnotations.Schema;

namespace Justo.Models.Comuns
{
    public class EntidadeBase
    {
        public int Id { get; set; }
        [Column("data_cadastro")]
        public DateTime datacadastro { get; set; }
        public int cadastradopor { get; set; }
        [Column("data_atualizacao")]
        public DateTime dataatualizacao { get; set; }
        public int atualizadopor { get; set; }
    }
}
