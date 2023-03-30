using System.Reflection.Metadata.Ecma335;

namespace FuncionalidadesTest
{
    internal class Calculadora
    {
        public Calculadora()
        {
        }

        internal decimal Dividir(decimal a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }

        internal int Modulo(int a, int b)
        {
            return a % b;
        }

        internal decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        internal decimal Potenciar(decimal a, decimal b)
        {
            return (decimal)Math.Pow((double)a, (double)b);
        }

        internal decimal Restar(decimal a, decimal b)
        {
            return a - b;
        }

        internal decimal Sumar(decimal a, decimal b)
        {
            return a + b;
        }
    }
}