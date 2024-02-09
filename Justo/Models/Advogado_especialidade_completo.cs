using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Advogado_especialidade_completo : EntidadeBase
    {
        public string Nome_advogado { get; set; }
        public string Nome_especialidade { get; set; }
        public string Oab_especialidade { get; set; }
        public string Oab_uf_especialidade { get; set; }
        public string Cpf_especialidade { get; set; }
        public string Status_Oab_Ativo { get; set; }





        // Chave estrangeira
        public int AdvogadoId { get; set; } // Chave estrangeira para Advogado
        public int Advogado_especialidade_Id { get; set; } // Chave estrangeira para Advogado_especialidade

        // Relacionamento com Advogado
        public Advogado Advogados { get; set; }

        // Relacionamento com Advogado_especialidade
        public Advogado_especialidade Advogado_Especialidades { get; set; }
    }
}
