namespace Herencia01
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** Repartidor
            Repartidor repartidor1 = new Repartidor();
            repartidor1.Nombre = "Hernan";
            repartidor1.Edad = 34;
            repartidor1.Salario = 400;
            repartidor1.Zona = "3";
            repartidor1.Plus();
            Console.WriteLine($"El repartidor {repartidor1.Nombre} tiene {repartidor1.Edad} años y se maneja por la zona {repartidor1.Zona}");
            Console.WriteLine($"Su salario final es de {repartidor1.Plus()}$");

            //*** Comercial
            Comercial comercial1 = new Comercial();
            comercial1.Nombre = "Jose";
            comercial1.Edad = 35;
            comercial1.Salario = 500;
            comercial1.Comision = 350;
            Console.WriteLine($"El repartidor {comercial1.Nombre} tiene {comercial1.Edad} años y recibe una comision de {comercial1.Comision}$");
            Console.WriteLine($"Su salario final es de {comercial1.Plus()}$");

            Console.ReadLine();
        }
    }
}