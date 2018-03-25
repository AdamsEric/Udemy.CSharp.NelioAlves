namespace Udemy
{
    public class Fornecedor
    {
        #region Atributos

        private string _Nome;
        private string _Email;
        private string _Telefone;

        #endregion

        #region Construtores

        public Fornecedor()
        {

        }

        public Fornecedor(string nome, string email, string telefone)
        {
            this._Nome = nome;
            this._Email = email;
            this._Telefone = telefone;
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

        public string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this._Email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return this._Telefone;
            }
            set
            {
                this._Telefone = value;
            }
        }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return this._Nome
                + ", "
                + this._Email
                + ", "
                + this._Telefone;
        }

        #endregion
    }
}
