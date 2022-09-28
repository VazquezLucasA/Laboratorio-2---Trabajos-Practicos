namespace TrabajoPractico1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Universidad Tecnológica Nacional - Facultad Regional Tucumán. Septiembre 2022.
            //Tecnicatura Universitaria en programación. Laboratorio de computación 2.
            //Trabajo práctico 1. Grupo 1.
            //Vázquez, Lucas Alejo. DNI 42467088.Legajo 55893.

            //marca, patente, valor, modelo, color
            Vehiculo vehiculo1 = new Vehiculo("Honda", "asd123", 4000);
            vehiculo1.mostrarDatos();
            Console.WriteLine();
            Console.ReadKey();

            Automovil automovil1 = new Automovil("Honda", "dsa321", 5000, "Civic", "Rojo");
            automovil1.mostrarDatos();
            Console.WriteLine();
            Console.ReadKey();

            Automovil automovil2 = new Automovil("Fiat", "qwe123", 1000, "Cronos", "Gris");
            automovil2.mostrarDatos();
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine($"El auto 2 es modelo {automovil2.getModelo()}");
            Console.ReadKey();

            
            
        }
    }
}