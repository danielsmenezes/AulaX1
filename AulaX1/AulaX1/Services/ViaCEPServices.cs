using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Aulas.Services.Model;
using Newtonsoft.Json;

namespace Aulas.Services
{
    public class ViaCEPServices
    {
        private static string endURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BrowserAdressViaCEP(String cep)
        {
            string NewAressURL = string.Format(endURL, cep);

            WebClient wc = new WebClient();
            string content = wc.DownloadString(NewAressURL);

            Endereco address = JsonConvert.DeserializeObject<Endereco>(content);

            return address;

        }


    }
}
