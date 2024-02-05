namespace Justo.Models.Comuns
{
    public class Endereco : EntidadeBase
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string Referencia { get; set; }
    }
}
