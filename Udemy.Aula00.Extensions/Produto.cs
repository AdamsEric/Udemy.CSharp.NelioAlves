using System.Globalization;

namespace Udemy
{
    public class Produto
    {
        #region Atributos

        private string _Nome;
        private double _Preco;
        private int _QuantidadeEmEstoque;
        private Fornecedor _Fornecedor;

        #endregion

        #region Construtores

        public Produto()
        {

        }

        public Produto(string _Nome, double _Preco, int _QuantidadeEmEstoque, Fornecedor _Fornecedor)
        {
            this._Nome = _Nome;
            this._Preco = _Preco;
            this._QuantidadeEmEstoque = _QuantidadeEmEstoque;
            this._Fornecedor = _Fornecedor;
        }

        public Produto(string _Nome, double _Preco, Fornecedor _Fornecedor)
        {
            this._Nome = _Nome;
            this._Preco = _Preco;
            this._QuantidadeEmEstoque = 0;
            this._Fornecedor = _Fornecedor;
        }

        #endregion

        #region Propriedades

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

        public double Preco
        {
            get
            {
                return this._Preco;
            }
            set
            {
                this._Preco = value;
            }
        }

        public int QuantidadeEmEstoque
        {
            get
            {
                return this._QuantidadeEmEstoque;
            }

            private set
            {

            }

        }

        public Fornecedor Fornecedor
        {
            get;
            private set;
        }

        #endregion

        #region Métodos

        public double ValorTotalEmEstoque()
        {
            return this._Preco * this._QuantidadeEmEstoque;
        }

        public void RealizarEntrada(int QuantidadeEntrada)
        {
            this._QuantidadeEmEstoque += QuantidadeEntrada;
        }

        public void RealizarSaida(int QuantidadeSaida)
        {
            this._QuantidadeEmEstoque -= QuantidadeSaida;
        }

        public override string ToString()
        {
            return this._Nome
                + ", R$ "
                + this._Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + this._QuantidadeEmEstoque
                + " unidades. Total: R$ "
                + this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + ", Fornecedor: "
                + this._Fornecedor;
        }

        #endregion
    }
}
