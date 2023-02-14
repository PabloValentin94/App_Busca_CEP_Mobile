using System;
using System.Collections.Generic;
using System.Text;

namespace App_Busca_CEP.Model
{

    public class Endereco
    {

        public int id { get; set; }

        public int id_cidade { get; set; }

        public string tipo { get; set; }

        public string descricao { get; set; }

        public string uf { get; set; }

        public string complemento { get; set; }

        public string descricao_sem_numero { get; set; }

        public string descricao_cidade { get; set; }

        public string codigo_cidade_ibge { get; set; }

        public string descricao_bairro { get; set; }

        public object rows { get; set; }

        public int CEP { get; set; }

        public string UF { get; set; }

    }

}
