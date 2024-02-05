using Justo.Models.Comuns;

namespace Justo.Models
{
    public class Clientes : EntidadeBase
    {
        public string Nome_cliente { get; set; }

        //documentos
        public string Cpf_cliente { get; set; }
        public string Rg_cliente { get; set; }
        public string? Cnh_cliente { get; set; }
        public string? Contrato_social_cliente { get; set; }
        public string? Cnpj_cliente { get; set; }
        public string? Certificado_reservista_cliente { get; set; }
        public string? Procuracao_representacao_legal_cliente { get; set; }


        //pessoais
        public string? Genero { get; set; }
        public DateTime Data_nascimento { get; set; }
        public string? Ocupacao { get; set; }
        public string Nacionalidade { get; set; }
        public string Estado_civil { get; set; }
        public string? Banco { get; set; }
        public string? Agencia_bancaria { get; set; }
        public string? Telefone_cliente { get; set; }
        public string? Contato_de_confianca_cliente { get; set; }
        public string Email_cliente { get; set; }

        //PF ou PJ
        public string Tipo_cliente { get; set; }
        public Endereco Endereco_cliente { get; set; }


         


        //chaves estrangeiras
        public int EnderecoId { get; set; }
        public int ProcessoId { get; set; }

    }
}
