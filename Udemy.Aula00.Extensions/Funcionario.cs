using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Udemy
{
    public class Funcionario
    {
        #region Atributos

        private string _CPF;
        private string _Nome;
        private double _Salario;

        #endregion

        #region Construtores

        public Funcionario()
        {

        }

        public Funcionario(string CPF, string Nome, double Salario)
        {
            this._CPF = CPF;
            this._Nome = Nome;
            this._Salario = Salario;
        }

        #endregion

        #region Propriedades

        public string CPF
        {
            get{ return this._CPF; }
            set { this._CPF = value; }
        }

        public string Nome
        {
            get { return this._Nome; }
            set { this._Nome = value; }
        }

        public double Salario
        {
            get { return this._Salario; }
            set { this._Salario = value; }
        }

        #endregion

        #region Métodos

        public void AumentarSalario(double PercentualAumento)
        {
            this._Salario = this._Salario + this._Salario*(PercentualAumento/100);
        }

        public override string ToString()
        {
            return this._CPF + ", " + this._Nome + ", " + this._Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        #endregion

    }
}
