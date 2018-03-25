using System;

namespace Udemy
{
    public class Quadrado : Figura
    {
        #region Atributos

        private double _Lado;

        #endregion

        #region Construtores

        public Quadrado(double Lado)
        {
            this._Lado = Lado;
        }
        
        #endregion

        #region Propriedades

        public double Lado
        {
            get
            {
                return this._Lado;
            }
            set
            {
                this._Lado = value;
            }
        }

        #endregion

        #region Métodos

        public override double Area()
        {
            return Math.Pow(this._Lado, 2);
        }

        public override double Perimetro()
        {
            return 4 * this._Lado;
        }

        #endregion
    }
}
