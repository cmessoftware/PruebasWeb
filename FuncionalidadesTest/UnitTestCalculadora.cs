using Funcionalidades;

namespace FuncionalidadesTest
{
    public class UnitTestCalculadora
    {

       


        [Fact]
        public void Probar_Suma()
        {
            decimal a, b;
            a = 2.3M;
            b = 0.7M;

            var calcu = new Calculadora();

            var resultado = calcu.Sumar(a,b);


            Assert.Equal(3, resultado);

           
        }

        [Fact]
        public void Probar_Resta()
        {

            decimal a, b;
            a = 2.3M;
            b = 0.7M;

            var calcu = new Calculadora();

            var resultado = calcu.Restar(a, b);


            Assert.Equal(1.6M, resultado);

        }

        [Fact]
        public void Probar_Multiplicacion()
        {

            decimal a, b;
            a = 2M;
            b = 7M;

            var calcu = new Calculadora();

            var resultado = calcu.Multiplicar(a, b);


            Assert.Equal(14, resultado);


        }

        [Fact]
        public void Probar_Division()
        {

            decimal a, b;
            a = 3M;
            b = 2M;

            var calcu = new Calculadora();

            var resultado = calcu.Dividir(a, b);


            Assert.Equal(1.5M, resultado);
        }

        [Fact]
        public void Probar_Division2()
        {

            decimal a, b;
            a = 3M;
            b = 0M;

            var calcu = new Calculadora();

            Action funcion = () => calcu.Division(a, b);

            //Assert
            Assert.Throws<DivideByZeroException>(funcion);
        }


        [Fact]
        public void Probar_Potenciacion()
        {

            decimal a, b;
            a = 3M;
            b = 2M;

            var calcu = new Calculadora();

            var resultado = calcu.Potenciar(a, b);


            Assert.Equal(9, resultado);
        }


        [Fact]
        public void Probar_Modulo()
        {


            int a, b;
            a = 3;
            b = 2;

            var calcu = new Calculadora();

            var resultado = calcu.Modulo(a, b);


            Assert.Equal(1, resultado);

        }
    }
}