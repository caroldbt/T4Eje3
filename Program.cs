using System;

namespace T4Eje3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre: ");
            string dato = Console.ReadLine();
            Console.WriteLine("Ingrese edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Te llamas " + dato + " y tienes " + edad + " años");
        }
    }
}
