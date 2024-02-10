using Justo.Models.Comuns;

namespace Justo.Models
{


    //entidade destinada a movimentação processual, inserida no banco após novas atualizações.
    public class Processos_Atualizacao : EntidadeBase
    {
        public string Movimentacao_processual_atualizacao { get; set; }
        public string Julgamento_status_atualizacao { get; set; }
        public DateTime Data_vencimento_processual_atualizacao { get; set; }
        public string Conteudo_atualizacao { get; set; }

        //o que é marcação de data?
        public DateTime Marcação_de_data_atualizacao { get; set; }
        //Andamento, julgamento, marcação de data, data de vencimento protestual
        public string Comarca_atual_atualizacao { get; set; }

        public bool Status_Processo_atualizacao { get; set; }



        //chave estrangeira

        public int ProcessoId {get;set;}
    }
}
