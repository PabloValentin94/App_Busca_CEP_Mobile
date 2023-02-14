using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

using App_Busca_CEP.Model;

namespace App_Busca_CEP.Service
{

    public class Data_Service
    {

        public static async Task<Endereco> GetEnderecoByCEP(string cep)
        {

            Endereco endereco;

            using (HttpClient cliente = new HttpClient())
            {

                HttpResponseMessage resposta = await cliente.GetAsync("https://cep.metoda.com.br/endereco/by-cep?cep=" + cep);

                if (resposta.IsSuccessStatusCode)
                {

                    string json = resposta.Content.ReadAsStringAsync().Result;

                    endereco = JsonConvert.DeserializeObject<Endereco>(json);

                }

                else
                {

                    throw new Exception(resposta.RequestMessage.Content.ToString());

                }

            }

            return endereco;

        }

        public static async Task<List<Bairro>> GetBairrosByIDCidade(int id_cidade)
        {

            List<Bairro> lista_bairros = new List<Bairro>();

            using(HttpClient cliente = new HttpClient())
            {

                HttpResponseMessage resposta = await cliente.GetAsync("https://cep.metoda.com.br/bairro/by-cidade?id_cidade=" + id_cidade);

                if(resposta.IsSuccessStatusCode)
                {

                    string json = resposta.Content.ReadAsStringAsync().Result;

                    lista_bairros = JsonConvert.DeserializeObject<List<Bairro>>(json);

                }

                else
                {

                    throw new Exception(resposta.RequestMessage.Content.ToString());

                }

            }

            return lista_bairros;

        }

    }

}
