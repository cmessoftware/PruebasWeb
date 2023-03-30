namespace Funcionalidades
{
    public class Pila
    {

        List<int> pila = new List<int>();

        public int Pop()
        {
            var elemento = pila.Last();
            pila.RemoveAt(pila.Count - 1);
            return elemento;
        }

        public void Push(int n) 
        {
            pila.Add(n); 
        }
    }
}