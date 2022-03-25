using System;

namespace paroimpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número " + numero + "es par.");
            }
            else
            {
                Console.WriteLine("El número " + numero + "es Impar.");
            }
            Console.ReadKey(true);
        }
    }
}
