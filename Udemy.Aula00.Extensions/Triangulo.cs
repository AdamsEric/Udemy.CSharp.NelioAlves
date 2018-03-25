using System;

namespace Udemy
{
    public class Triangulo : Figura
    {
        #region Atributos

        private double _A;
        private double _B;
        private double _C;

        #endregion

        #region Construtores

        public Triangulo(double A, double B, double C)
        {
            this._A = A;
            this._B = B;
            this._C = C;
        }

        #endregion

        #region Propriedades

        public double A {
            get
            {
                return this._A;
            }
            set
            {
                this._A = value;
            }
        }

        public double B
        {
            get
            {
                return this._B;
            }
            set
            {
                this._B = value;
            }
        }
        public double C
        {
            get
            {
                return this._C;
            }
            set
            {
                this._C = value;
            }
        }

        #endregion

        #region Métodos

        public override double Area()
        {
            double _P = (_A + _B + _C) / 2;
            return Math.Sqrt(_P * (_P - _A) * (_P - _B) * (_P - _C));
        }

        public override double Perimetro()
        {
            double _P = (this.A + this.B + this.C);
            return _P;
        }

        #endregion

    }
}
