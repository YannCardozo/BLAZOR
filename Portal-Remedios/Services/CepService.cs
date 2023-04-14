using Newtonsoft.Json;
using Portal_Remedios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Portal_Remedios.Services

{
    internal class CepServices
    {
        public async Task<Cep> Integracao(string cep)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            var jsonString = await response.Content.ReadAsStringAsync();

            Cep jsonObject = JsonConvert.DeserializeObject<Cep>(jsonString);

            if (jsonObject != null)
            {
                return jsonObject;
            }
            else
            {
                return new Cep
                {
                    Vericacao = true
                };
            }
        }
    }
}
