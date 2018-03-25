using System;
using System.Globalization;

namespace Udemy.Model
{
    class Produto : IComparable
    {
        #region Atributos

        private int _Codigo;
        private string _Descricao;
        private double _Preco;

        #endregion

        #region Construtores

        public Produto(int Codigo, string Descricao, double Preco)
        {
            this._Codigo = Codigo;
            this._Descricao = Descricao;
            this._Preco = Preco;
        }

        #endregion

        #region Propriedades

        public int Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                this._Codigo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _Descricao;
            }
            set
            {
                this._Descricao = value;
            }
        }

        public double Preco
        {
            get
            {
                return _Preco;
            }
            set
            {
                this._Preco = value;
            }
        }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return this._Codigo
                + ", "
                + this._Descricao
                + ", "
                + this._Preco.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            Produto outro = (Produto)obj;
            int resultado = Descricao.CompareTo(outro.Descricao);
            if (resultado != 0){
                return resultado;
            }
            else
            {
                return -(Preco.CompareTo(outro.Preco));
            }
        }

        #endregion
    }
}
