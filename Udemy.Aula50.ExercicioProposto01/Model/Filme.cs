using System;
using System.Collections.Generic;
using System.Globalization;

namespace Udemy.Model
{
    class Filme
    {
        #region Atributos

        private int _Codigo;
        private string _Titulo;
        private int _Ano;
        private List<Participacao> _Participacoes;

        #endregion

        #region Construtores

        public Filme(int codigo, string titulo, int ano)
        {
            this._Codigo = codigo;
            this._Titulo = titulo;
            this._Ano = ano;
            this._Participacoes = new List<Participacao>();
        }

        #endregion

        #region Propriedades

        public int Codigo
        {
            get
            {
                return this._Codigo;
            }
            set
            {
                this._Codigo = value;
            }
        }

        public string Titulo
        {
            get
            {
                return this._Titulo;
            }
            set
            {
                this._Titulo = value;
            }
        }

        public int Ano
        {
            get
            {
                return this._Ano;
            }
            set
            {
                this._Ano = value;
            }
        }

        public List<Participacao> Participacoes
        {
            get
            {
                return this._Participacoes;
            }
            set
            {
                this._Participacoes = value;
            }
        }

        #endregion

        #region Métodos

        public double CustoTotal()
        {
            double CustoTotal = 0;
            for(int i = 0; i < this._Participacoes.Count; i++)
            {
                CustoTotal = CustoTotal + this._Participacoes[i].Custo();
            }
            return CustoTotal;
        }

        public override string ToString()
        {
            string retorno = "Filme "
                + Codigo
                + ", Título: "
                + Titulo
                + ", Ano: "
                + Ano + "\nParticipações: \n";

            for (int i = 0; i < Participacoes.Count; i++)
            {
                retorno = retorno + Participacoes[i];
            }

            retorno = retorno + "\nCusto total do filme: " + CustoTotal().ToString("F2", CultureInfo.InvariantCulture);

            return retorno;
        }

        #endregion

    }
}
