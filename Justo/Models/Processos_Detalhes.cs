using Justo.Models.Comuns;

namespace Justo.Models
{


    //entidade destinada a movimentação processual, inserida no banco após novas atualizações.
    public class Processos_Detalhes : EntidadeBase
    {
        public string Movimentacao_processual { get; set; }
        public string Julgamento_status { get; set; }
        public string Data_vencimento_processual { get; set; }
        public string Conteudo { get; set; }

        //o que é marcação de data?
        public string Marcação_de_data { get; set; }
        //Andamento, julgamento, marcação de data, data de vencimento protestual
        public string Comarca_atual { get; set; }
    }
}
