using System;

namespace Programa07_09_Operador_OR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OR - || - O
            // Solo es verdadero cuando al menos una o todas las condiciones son verdaderas
            // A  B | R
            // F  F | F
            // F  V | V
            // V  F | V
            // V  V | V

            // Este programa imprime la suma, si hay un numero menor a 10
            // Variables
            int a = 0;
            int b = 0;
            int suma = 0;
            string dato = "";

            // Pedimos los numeros
            Console.WriteLine("Dame el primer numero");
            dato = Console.ReadLine();
            a = Convert.ToInt32(dato);

            Console.WriteLine("Dame el segundo numero");
            dato = Console.ReadLine();
            b = Convert.ToInt32(dato);

            // Verificamos que almenos 1 de las 2 opciones brindadas por el usuario
            // sea menor a 10

            if (a < 10 || b < 10)
            {
                suma = a + b;
                Console.WriteLine("La suma entre {0} y {1} da un total de {2}", a, b, suma);
            }
            else
            {
                Console.WriteLine("Algún numero es mayor a 10");
            }
        }
    }
}
