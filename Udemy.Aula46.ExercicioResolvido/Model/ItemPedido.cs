using System.Globalization;

namespace Udemy.Model
{
    class ItemPedido
    {
        #region Atributos

        private int _Quantidade;
        private double _PorcentagemDesconto;
        private Produto _Produto;
        private Pedido _Pedido;

        #endregion

        #region Construtores

        public ItemPedido(int Quantidade, double PorcentagemDesconto, Produto Produto, Pedido Pedido)
        {
            this._Quantidade = Quantidade;
            this._PorcentagemDesconto = PorcentagemDesconto;
            this._Produto = Produto;
            this._Pedido = Pedido;
        }

        #endregion

        #region Propriedades

        public int Quantidade
        {
            get
            {
                return _Quantidade;
            }
            set
            {
                this._Quantidade = value;
            }
        }

        public double PorcentagemDesconto
        {
            get
            {
                return this._PorcentagemDesconto;
            }
            set
            {
                this._PorcentagemDesconto = value;
            }
        }

        public Produto Produto
        {
            get
            {
                return this._Produto;
            }
            set
            {
                this._Produto = value;
            }
        }

        public Pedido Pedido
        {
            get
            {
                return this._Pedido;
            }
            set
            {
                this._Pedido = value;
            }
        }

        #endregion

        #region Métodos

        public double SubTotal()
        {
            return Quantidade * (Produto.Preco - (Produto.Preco * PorcentagemDesconto / 100));
        }

        public override string ToString()
        {
            return Produto.Descricao
                + ", Preço: "
                + Produto.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Qtde: "
                + Quantidade
                + ", Desconto: "
                + PorcentagemDesconto.ToString("F1", CultureInfo.InvariantCulture)
                + "%, Subtotal: "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture)
                + "\n";
        }

        #endregion
    }

}
