using System;

namespace Racional
{
    class Racional
    {
        //Atributos
        public int numerador;
        public int denominador;

        //Constructor
        public Racional(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;

            if (denominador == 0)
            {
                throw new ArgumentException("El denominador no puede ser 0");
            }
        }

        public int Numerador
        {
            get{return numerador;}
            private set{numerador = value;}
        }
        public int Denominador
        {
            get{return denominador;}
            private set{denominador = value;}
        }

        /*public string Formatoracional()
        {
            return $"{numerador}/{denominador}";
        }*/

        public static Racional operator +(Racional a, Racional b)
        {
            int nuvNumerador = ((a.numerador * b.denominador) + (a.denominador * b.numerador));
            int nuvDenominador = a.denominador * b.denominador;
            return new Racional(nuvNumerador, nuvDenominador);
        }

        public static Racional operator -(Racional a, Racional b)
        {
            int nuvNumerador = ((a.numerador * b.denominador) - (a.denominador * b.numerador));
            int nuvDenominador = a.denominador * b.denominador;
            return new Racional(nuvNumerador, nuvDenominador);
        }
        private void Simplificar()
        {
            int gcd = Mcd(Math.Abs(Numerador), Math.Abs(Denominador));
            if (gcd > 1)
            {
                Numerador /= gcd;
                Denominador /= gcd;
            }
        }

        private int Mcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}