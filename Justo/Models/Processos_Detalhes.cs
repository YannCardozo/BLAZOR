using Justo.Models.Comuns;

namespace Justo.Models
{


    //entidade destinada a movimentação processual, inserida no banco após novas atualizações.
    public class Processos_Detalhes : EntidadeBase
    {
        public string Movimentacao_processual_detalhes { get; set; }
        public string Julgamento_status_detalhes { get; set; }
        public DateTime Data_vencimento_processual_detalhes { get; set; }
        public string Conteudo_detalhes { get; set; }

        //o que é marcação de data?
        public DateTime Marcação_de_data_detalhes { get; set; }
        //Andamento, julgamento, marcação de data, data de vencimento protestual
        public string Comarca_atual_detalhes { get; set; }

        public bool Status_Processo_Detalhes { get; set; }



        //chave estrangeira

        public int ProcessoId {get;set;}
    }
}
