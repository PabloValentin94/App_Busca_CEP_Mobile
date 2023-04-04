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

                HttpResponseMessage resposta = await cliente.GetAsync("http://10.0.2.2:8000/endereco/by-cep?cep=" + cep);

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

                HttpResponseMessage resposta = await cliente.GetAsync("http://10.0.2.2:8000/bairro/by-cidade?id_cidade=" + id_cidade);

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

        public static async Task<List<Logradouro>> GetLogradouroByBairro(string bairro, int id_cidade)
        {

            List<Logradouro> lista_logradouros = new List<Logradouro>();

            using(HttpClient cliente = new HttpClient())
            {

                HttpResponseMessage resposta = await cliente.GetAsync("http://10.0.2.2:8000/logradouro/by-bairro?id_cidade=" + id_cidade + "&bairro=" + bairro);

                if(resposta.IsSuccessStatusCode)
                {

                    string json = resposta.Content.ReadAsStringAsync().Result;

                    lista_logradouros = JsonConvert.DeserializeObject<List<Logradouro>>(json);

                }

                else
                {

                    throw new Exception(resposta.RequestMessage.Content.ToString());

                }

            }

            return lista_logradouros;

        }

        public static async Task<List<Cidade>> GetCidadesByUF(string uf)
        {

            List<Cidade> lista_cidades = new List<Cidade>();

            using(HttpClient cliente = new HttpClient())
            {

                HttpResponseMessage resposta = await cliente.GetAsync("http://10.0.2.2:8000/cidade/by-uf?uf=" + uf);

                if(resposta.IsSuccessStatusCode)
                {

                    string json = resposta.Content.ReadAsStringAsync().Result;

                    lista_cidades = JsonConvert.DeserializeObject<List<Cidade>>(json);

                }

                else
                {

                    throw new Exception(resposta.RequestMessage.Content.ToString());

                }

            }

            return lista_cidades;

        }

        public static async Task<List<CEP>> GetCEPByLogradouro(string logradouro)
        {

            List<CEP> lista_ceps = new List<CEP>();

            using(HttpClient cliente = new HttpClient())
            {

                HttpResponseMessage resposta = await cliente.GetAsync("http://10.0.2.2:8000/cep/by-logradouro?logradouro=" + logradouro);

                if(resposta.IsSuccessStatusCode)
                {

                    string json = resposta.Content.ReadAsStringAsync().Result;

                    lista_ceps = JsonConvert.DeserializeObject<List<CEP>>(json);

                }

                else
                {

                    throw new Exception(resposta.RequestMessage.Content.ToString());

                }

                return lista_ceps;

            }

        }

    }

}
