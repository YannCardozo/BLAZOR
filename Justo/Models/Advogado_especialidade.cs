namespace Justo.Models
{
    public class Advogado_especialidade
    {
        public string Nome_advogado { get; set; }
        public string Nome_especialidade { get; set; }
        public string Oab_especialidade { get; set; }
        public string Oab_uf_especialidade { get; set; }
        public string Cpf_especialidade { get; set; }






        //chave estrangeira
        public int AdvogadoId { get; set; }
    }
}
