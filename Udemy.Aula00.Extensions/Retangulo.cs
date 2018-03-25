using System;

namespace Udemy
{
    public class Retangulo : Figura
    {
        #region Atributos
        private double _Largura;
        private double _Altura;
        #endregion

        #region Construtores

        public Retangulo(double Largura, double Altura)
        {
            this._Largura = Largura;
            this._Altura = Altura;
        }
        #endregion

        #region Propriedades

        public double Largura
        {
            get
            {
                return this._Largura;
            }
            set
            {
                this._Largura = value;
            }
        }

        public double Altura
        {
            get
            {
                return this._Altura;
            }
            set
            {
                this._Altura = value;
            }
        }

        #endregion

        #region Métodos

        public override double Area()
        {
            return this._Largura * this._Altura;
        }

        public override double Perimetro()
        {
            return (2 * this._Altura + 2 * this._Largura);
        }

        #endregion
    }
}
