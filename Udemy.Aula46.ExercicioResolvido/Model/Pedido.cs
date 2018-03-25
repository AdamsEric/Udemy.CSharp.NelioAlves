using System;
using System.Collections.Generic;
using System.Globalization;

namespace Udemy.Model
{
    class Pedido
    {
        #region Atributos

        private int _Codigo;
        private DateTime _Data;
        private List<ItemPedido> _ItensPedido;

        #endregion

        #region Construtores

        public Pedido(int Codigo, int Dia, int Mes, int Ano)
        {
            this._Codigo = Codigo;
            this._Data = new DateTime(Ano, Mes, Dia);
            this._ItensPedido = new List<ItemPedido>();
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

        public DateTime Data
        {
            get
            {
                return _Data;
            }
            set
            {
                this._Data = value;
            }
        }

        public List<ItemPedido> ItensPedido
        {
            get
            {
                return this._ItensPedido;
            }
            set
            {
                this._ItensPedido = value;
            }
        }

        #endregion

        #region Métodos

        public double ValorTotal()
        {
            double soma = 0;
            for (int i = 0; i < ItensPedido.Count; i++)
            {
                soma = soma + ItensPedido[i].SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            string s;
            s = "Pedido "
                + Codigo
                + ", data: "
                + Data.Day + "-" + Data.Month + "-" + Data.Year
                + "\n\nItens:\n";

            for (int i = 0; i < ItensPedido.Count; i++)
            {
                s = s + ItensPedido[i];
            }

            s = s + "\nTotal do pedido: "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;


        }

        #endregion
    }
}
