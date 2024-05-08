namespace WebAsseblyJusto.Pages.models
{
    public class Advogado
    {
        public Advogado()
        {

        }
        public Advogado(string cPF, string oAB, int id)
        {
            CPF = cPF;
            OAB = oAB;
            this.id = id;
        }

        public string CPF { get; set; }
        public string OAB { get; set; }
        public int id { get; set; }
    }
}
