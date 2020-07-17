using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using BuscaCEP.Service.Model;
using Newtonsoft.Json;
namespace BuscaCEP.Service
{
    public class ViaCEP
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoUrl = string.Format(EnderecoURL, cep);
            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoUrl);
            Endereco End = JsonConvert.DeserializeObject<Endereco>(Conteudo);
            return End;
        }
    }
}
