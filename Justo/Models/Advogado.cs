using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Advogado : EntidadeBase
    {
        public string Nome { get; set; }
        public string Oab { get; set; }
        public string Oab_UF { get; set; }
        public string cpf { get; set; }

        //identifica em um select a area de atuacao, poderia ser relacionado com a tabela dos direitos de atuacao?

        //oab ativa ou não ativa
        public bool Status_Oab_Ativo { get; set; }



        //todo advogado vai ter uma especialidade, 1 advogado pode ter varias especialidades
        public ICollection<Advogado_especialidade> Advogados_Especialidades_FK { get; set; }


        //chave estrangeira
        //public int Advogado_especialidade_Completo_Id { get; set; }
        public int ProcessosId { get; set; }

        //Advogado vai ter que estar associado com processos também

    }
}
