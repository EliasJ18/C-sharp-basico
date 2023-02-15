using System;

namespace Programa08_03_Contador_y_Acumulador_Ciclo_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este programa muestra un contador y un acumulador
            int n = 0;
            int contador = 0;
            int acumulador = 0;
            int valor = 0;
            string dato = "";

            // Ejemplo de contador
            for (n = 0; n < 10; n++)
            {
                Console.WriteLine("En el ciclo");
                contador = contador + 1;
            }

            Console.WriteLine("El contador tiene {0}", contador);

            // Ejemplo de acumulador
            // El operador ++ adiciona uno a la variable
            // n = n + 1; es igual a n++;
            for (n = 0; n < 5; n++)
            {
                Console.WriteLine("Dame un numero");
                dato = Console.ReadLine();
                valor = Convert.ToInt32(dato);

                acumulador = acumulador + valor;
            }

            Console.WriteLine("El acumulado es {0}", acumulador);
        }
    }
}
