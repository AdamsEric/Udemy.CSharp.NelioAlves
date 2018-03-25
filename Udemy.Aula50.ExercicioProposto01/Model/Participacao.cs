using System;
using System.Globalization;

namespace Udemy.Model
{
    class Participacao
    {

        #region Atributos

        private Artista _Artista;
        private Filme _Filme;
        private double _Desconto;

        #endregion

        #region Construtores

        public Participacao(Artista artista, Filme filme, double desconto)
        {
            this._Artista = artista;
            this._Filme = filme;
            this._Desconto = desconto;
        }

        #endregion

        #region Propriedades

        public Artista Artista
        {
            get
            {
                return this._Artista;
            }
            set
            {
                this._Artista = value;
            }
        }

        public Filme Filme
        {
            get
            {
                return this._Filme;
            }
            set
            {
                this._Filme = value;
            }
        }

        public double Desconto
        {
            get
            {
                return this._Desconto;
            }
            set
            {
                this._Desconto = value;
            }
        }

        #endregion

        #region Métodos

        public double Custo()
        {
            return Artista.Cache - Desconto;
        }

        public override string ToString()
        {
            return Artista.Nome
                + ", "
                + Artista.Cache.ToString("F2", CultureInfo.InvariantCulture)
                + ", Desconto: "
                + Desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + Custo().ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }

        #endregion
    }
}
