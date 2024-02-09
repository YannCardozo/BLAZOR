using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Advogado_especialidade_completo : EntidadeBase
    {
        public string Nome_advogado_completo { get; set; }
        public string Nome_especialidade_completo { get; set; }
        public string Oab_especialidade_completo { get; set; }
        public string Oab_uf_especialidade_completo { get; set; }
        public string Cpf_especialidade_completo{ get; set; }
        public bool Status_Oab_Ativo_completo { get; set; }





        // Chave estrangeira
        public int AdvogadoId { get; set; } // Chave estrangeira para Advogado
        public int Advogado_especialidade_Id { get; set; } // Chave estrangeira para Advogado_especialidade

        // Relacionamento com Advogado
        public ICollection<Advogado> Advogados { get; set; }

        // Relacionamento com Advogado_especialidade
        public Advogado_especialidade Advogado_Especialidades { get; set; }
    }
}
