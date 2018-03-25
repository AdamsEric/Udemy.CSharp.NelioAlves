using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Model
{
    class Artista : IComparable
    {
        #region Atributos

        private int _Codigo;
        private string _Nome;
        private double _Cache;

        #endregion

        #region Construtores

        public Artista(int codigo, string nome, double cache)
        {
            this._Codigo = codigo;
            this._Nome = nome;
            this._Cache = cache;
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

        public string Nome
        {
            get
            {
                return this._Nome;
            }
            set
            {
                this._Nome = value;
            }
        }

        public double Cache
        {
            get
            {
                return this._Cache;
            }
            set
            {
                this._Cache = value;
            }
        }

        #endregion

        #region Métodos

        public int CompareTo(object obj)
        {
            Artista outro = (Artista)obj;
            int resultado = Nome.CompareTo(outro.Nome);
            return resultado;
        }


        public override string ToString()
        {
            return Codigo
                + ", "
                + Nome +
                ", Cachê: "
                + Cache.ToString("F2", CultureInfo.InvariantCulture);
        }


        #endregion

    }
}
