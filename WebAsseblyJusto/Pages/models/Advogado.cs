namespace WebAsseblyJusto.Pages.models
{
    public class Advogado
    {
        public Advogado()
        {

        }
        public Advogado(string cPF, string oAB, int id, string nOme)
        {
            CPF = cPF;
            OAB = oAB;
            this.id = id;
            NOME = nOme;
        }

        public string CPF { get; set; }
        public string NOME { get; set; }
        public string OAB { get; set; }
        public int id { get; set; }
    }
}
