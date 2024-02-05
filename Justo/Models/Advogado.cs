using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Advogado : EntidadeBase
    {
        public string Nome { get; set; }
        public string Oab { get; set; }
        public string Oab_UF { get; set; }

        public List<Documentos> Documentos_Advogado { get; set; }
        public List<Tipo_Processo> Area_de_atuacao_direito { get;set; }
    }
}
