using Funcionalidades;

namespace FuncionalidadesTest
{
    public class UnitTestPila
    {
        [Fact]
        public void Probar_Pop()
        {
            //Preparacion
            var pila = new Pila();

            //Ejecución 
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);

            pila.Pop();
            pila.Pop();
            int valor = pila.Pop();

            //Validación.
            Assert.Equal(2, valor);
        }

        [Fact]
        public void Probar_Pop2()
        {
            //Preparacion
            var pila = new Pila();

            //Ejecución 
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);

            pila.Pop();
            pila.Pop();
            int valor = pila.Pop();

            //Validación.
            Assert.True(valor == 2, "OK");
        }

        [Fact]
        public void Probar_Push2()
        {

            //Preparacion
            var pila = new Pila();

            //Ejecución 
            pila.Push(1);
            pila.Pop();
            pila.Push(2);
            pila.Pop();
            pila.Push(3);
            pila.Push(4);

            int valor = pila.Pop();

            Assert.False(valor != 4, "NO OK!!");

        }

        [Fact]
        public void Probar_Push()
        {

            //Preparacion
            var pila = new Pila();

            //Ejecución 
            pila.Push(1);
            pila.Pop();
            pila.Push(2);
            pila.Pop();
            pila.Push(3);
            pila.Push(4);

            int valor = pila.Pop();

            Assert.Equal(4,valor);

        }
    }
}