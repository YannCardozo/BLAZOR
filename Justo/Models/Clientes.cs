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
        public string Genero_cliente { get; set; }
        public DateTime Data_nascimento_cliente { get; set; }
        public string? Ocupacao_cliente { get; set; }
        public string Nacionalidade_cliente { get; set; }
        public string Estado_civil_cliente { get; set; }
        public string? Banco_cliente { get; set; }
        public string? Agencia_bancaria_cliente { get; set; }
        public string Telefone_cliente { get; set; }
        public string? Contato_de_confianca_cliente { get; set; }
        public string Email_cliente { get; set; }

        

        //PF ou PJ
        public string Tipo_cliente { get; set; }


        //a ideia seria ter  uma tabela Endereco na qual fosse cadastrado todos os enderecos de cada cliente de acordo
        //com o id da tabela clientes
        public Endereco Endereco_cliente { get; set; }


         


        //chaves estrangeiras
        public int EnderecoId { get; set; }
        public int ProcessoId { get; set; }


    }
}
