using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Arquivos_cliente_upload : EntidadeBase
    {
        //nome completo do arquivo, caminho dele no FTP
        public string Nome_advogado_arquivo { get; set; }
        public string Oab_arquivo { get; set; }
        public string Oab_UF_arquivo { get; set; }
        public TipoArquivo Tipo_arquivo { get; set; }
        public string Nome_arquivo { get; set; }



        public enum TipoArquivo
        {
            Contrato = 1,
            Acordos = 2,
            Outros = 3,
            Procuracao_legal = 4,
        }


        //chave estrangeiro em processos
        public int ProcessoId { get; set; }
        public int AdvogadoId { get; set; }


    }
}
