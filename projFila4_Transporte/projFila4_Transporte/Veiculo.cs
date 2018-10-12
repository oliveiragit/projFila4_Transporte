﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace projFila4_Transporte
{
    class Veiculo
    {
        #region atributos
        private string placa, nomeMotorista;
        private int lotacao;
        #endregion


        #region propriedades
        public string Placa
        {
            get { return placa; }
            set { if (placa.Length == 7 && validaPlaca(value)) placa = value; }
        }
        public int Lotacao
        {
            get { return lotacao; }
            set {
                if (lotacao > 0)lotacao = value;
            }
        }
        #endregion

        #region construtores
        public Veiculo(string placa, string nomeMotorista, int lotacao)
        {
            Placa = placa;
            this.nomeMotorista = nomeMotorista;
            Lotacao = lotacao;
        }
        #endregion

        #region metodos
        public bool validaPlaca(string value)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");

            if (regex.IsMatch(value))
                return true; //se a placa for válida, retorna TRUE
            return false; //se a placa for inválida, retorna FALSE             
        }

        #endregion
    }
}