namespace Portal_Remedios.Models
{
    public class Estoque
    {
        public int Codigo { get; set; }
        public string Produto { get; set; }
        public string Nome_produto { get; set; }
        public string Descricao { get; set; }
        public DateTime Validade_produto { get; set; }
        public DateTime Recebimento_produto { get; set; }


    }
}
