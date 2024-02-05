using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Advogado : EntidadeBase
    {
        public string Nome { get; set; }
        public string cpf { get; set; }
        public string Oab { get; set; }
        public string Oab_UF { get; set; }

        //oab ativa ou não ativa
        public string Status_Oab { get; set; }

        public List<Advogado_especialidade> Area_de_atuacao_direito { get;set; }
    }
}
