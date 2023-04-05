namespace Portal_Remedios.Models
{
    public class Beneficiario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateOnly data_nasc { get; set; }
        public string sexo { get; set; }
        public string ocupacao { get; set; }
        public string NIS { get; set; }
        public string escolaridade { get; set; }
        public string motivo_cadastro { get; set; }
        public string renda_familiar { get; set; }


    }
}
