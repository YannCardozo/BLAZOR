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
        public string Nome_cliente { get; set; }
        public string? Nome_autor { get; set; }
        public string? Nome_reu { get; set; }
        //areas de direito do processo
        public string Tipo_processo { get; set; }
        public string Situacao { get; set; }
        public string Comarca_inicial { get; set; }
        public string Conteudo_inicial { get; set; }
        //destinado a observações para incluir no processo
        public string? Obs_processo { get; set; }
        public DateTime Data_abertura { get; set; }
        public DateTime Data_fim { get; set; }

        //cliente é ativo ou passivo
        public string Polo_cliente { get; set; }


        //Lisconsorcio nao clientes serão a parte oposta aos clientes do advogado
        public ICollection<Processos_ClientesReu>? Processos_ClientesReu { get; set; }

        //Lisconsorcio clientes será a parte interessada do advogado
        public ICollection<Clientes>? Lisconsorcio_autor { get; set; }

        public ICollection<Advogado>? Advogados { get; set; }


        //chaves estrangeiras

        //public int ClienteId { get; set; }
        //public int AdvogadoId { get; set; }


        public int ProcessosDetalhesId { get; set; }

    }
}
