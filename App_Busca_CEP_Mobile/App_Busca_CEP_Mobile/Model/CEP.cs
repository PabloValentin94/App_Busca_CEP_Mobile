﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App_Busca_CEP_Mobile.Model
{

    public class CEP
    {

        public int id { get; set; }

        public int id_logradouro { get; set; }

        public string descricao { get; set; }

        public string complemento { get; set; }

        public string tipo { get; set; }

        public int id_cidade { get; set; }

        public string descricao_cidade { get; set; }

        public string codigo_ibge_cidade { get; set; }

        public string uf { get; set; }

        public string descricao_bairro { get; set; }

        public string descricao_sem_numero { get; set; }

        public string cep { get; set; }

    }

}
