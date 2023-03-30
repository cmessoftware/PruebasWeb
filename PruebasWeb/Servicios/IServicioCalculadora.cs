namespace PruebasWeb.Servicios
{
    public interface IServicioCalculadora
    {
        public decimal Sumar(decimal a, decimal b);
        public decimal Restar(decimal a, decimal b);
        public decimal Multiplicar(decimal a, decimal b);

        public decimal Dividir(decimal a, decimal b);

        public long Potenciar(int a, int b);
        public int Modulo(int a, int b);


    }
}
