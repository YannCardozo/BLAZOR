namespace Justo.Models.Comuns
{
    public class Documentos : EntidadeBase
    {
        public string? Cnh {get; set; } 
        public List<string>? Contrato_social { get; set; }
        public string? Cnpj { get; set; }
    }
}
