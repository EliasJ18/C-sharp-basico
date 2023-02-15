using System;

namespace Programa08_05_Variaciones_del_ciclo_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int n = 0;

            // Ciclo de cierto numero a otro
            Console.WriteLine("Ciclo que va del 3 al 7");
            for (n = 3; n <= 7; n++)
            {
                Console.WriteLine(n);
            }

            // El incremento de dos en dos
            Console.WriteLine("Este ciclo avanza de dos en dos");
            for (n = 0; n < 100; n = n + 2)
            {
                Console.WriteLine("{0}", n);
            }

            // Ciclo en cuenta regresiva
            Console.WriteLine("Ciclo en cuenta regresiva");
            for (n = 10; n > 0; n--)
            {
                Console.WriteLine("{0}", n);
            }

        }
    }
}
