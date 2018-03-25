namespace Udemy
{
    public class Conta
    {
        #region Atributos

        private int _Numero;
        private string _Titular;
        private double _Saldo;
        private double _LimiteDeSaque;

        #endregion

        #region Construtores

        public Conta(int Numero, string Titular, double LimiteDeSaque)
        {
            this._Numero = Numero;
            this._Titular = Titular;
            this._Saldo = 0.0;
            this._LimiteDeSaque = LimiteDeSaque;
        }

        #endregion

        #region Propriedades

        public int Numero
        {
            get
            {
                return this._Numero;
            }
            set
            {
                this._Numero = value;
            }
        }

        public string Titular
        {
            get
            {
                return this._Titular;
            }
            set
            {
                this._Titular = value;
            }
        }

        public double Saldo
        {
            get
            {
                return this._Saldo;
            }
            private set
            {

            }
        }

        public double LimiteDeSaque
        {
            get
            {
                return this._LimiteDeSaque;
            }
            set
            {
                this._LimiteDeSaque = value;
            }
        }

        #endregion

        #region Métodos

        public void Depositar(double valor)
        {
            this._Saldo = this._Saldo + valor;
        }

        public void Sacar(double valor)
        {
            if (this._Saldo < valor)
            {
                throw new OperacaoException("Não há saldo suficiente! Saque cancelado!");
            }
            if (this._LimiteDeSaque < valor)
            {
                throw new OperacaoException("Valor do saque é superior ao limite de saque da conta! Saque cancelado.");
            }
            this._Saldo = this._Saldo - valor;
        }

        #endregion
    }
}
