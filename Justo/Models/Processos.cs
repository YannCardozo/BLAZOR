using Justo.Models.Comuns;

namespace Justo.Models
{
    //entidade destinada a fazer os inserts inicial de cada processo de cada cliente no webscrapping do PJE
    //processos detalhes fará os inserts respectivos de novas atualizações a fim de traçar uma RASTREABILIDADE
    //para cada processo

    public class Processos : EntidadeBase
    {
        //destinado a codigo do processo de acordo com a numeração do TJ
        //possivelmente pelo cod_processo faremos a distinção se em cada processo ( numeração dele ) , ele não muda.
        public string Cod_processo_TJ { get; set; }
        public string? Nome_autor { get; set; }
        public string? Nome_reu { get; set; }
        //areas de atuação do processo
        public List<Tipo_Processo> Tipo_processo { get; set; }
        public string Situacao { get; set; }
        public string Comarca_inicial { get; set; }
        //destinado a observações para incluir no processo
        public string? Obs_processo { get; set; }
        public DateTime Data_abertura { get; set; }
        public DateTime Data_fim { get; set; }

        //cliente é ativo ou passivo
        public string Polo_cliente { get; set; }


        //Lisconsorcio nao clientes serão a parte oposta aos clientes do advogado
        public List<Clientes>? Lisconsorcio_reu { get; set; }

        //Lisconsorcio clientes será a parte interessada do advogado
        public List<Clientes>? Lisconsorcio_autor { get; set; }

        public List<Advogados> Advogado { get; set; }

    }
}
