using System;

namespace Programa08_09_Ciclos_Anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostramos un ejemplo de ciclos anidados, ente caso, ciclo for
            // Tablas de multiplicar

            // Variables
            //int n = 0;
            //int m = 0;
            //int producto = 0;

            //// Imprime las tablas de multiplicar

            //for (n = 1; n <= 10; n++)
            //{
            //    for (m = 1; m <= 10; m++)
            //    {
            //        producto = n * m;
            //        Console.WriteLine("{0} x {1} = {2}", n, m, producto);
            //    }
            //    Console.WriteLine();
            //}

            // -----------------------------------------------------------------------------

            // Este otro programa muestra todos los numeros primos del 1 al 100
            // No es la mejor forma, pero explica el anidamiento

            // Variables
            int n = 0;
            int m = 0;
            bool primo = true;

            for (n = 2; n < 100; n++)
            {
                primo = true;
                for (m = 2; m < n; m++)
                {
                    if (n % m == 0)
                        primo = false;
                }

                    if (primo == true)
                        Console.Write("{0},", n);

            }
              Console.WriteLine();
        }
    }
}
