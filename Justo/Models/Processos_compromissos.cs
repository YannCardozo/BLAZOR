using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Processos_compromissos : EntidadeBase
    {
        //entidade destinada a fazer 
        public string Nome_cliente_compromisso { get; set; }
        public string Nome_advogado_compromisso { get; set; }
        public string Nome_compromisso { get; set; }
        public DateTime Data_compromisso { get; set; }
        public string Obs_compromisso { get; set; }
        public DateTime Data_proximo_evento_compromisso { get; set; }



        //chave estrangeira
        public int ProcessoId { get; set; }
        public int ClienteId { get; set; }
        public int AdvogadoId { get; set; }
    }
}
