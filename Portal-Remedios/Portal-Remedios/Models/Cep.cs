﻿namespace Portal_Remedios.Models
{
    public class Cep
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string ddd { get; set; }

        public bool Vericacao = false; 

    }
}

