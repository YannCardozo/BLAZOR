using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Clientes : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string? Cnh { get; set; }

        //PF ou PJ
        public string Tipo_Cliente { get; set; }
        public Endereco Endereco_cliente { get; set; }
    }
}
