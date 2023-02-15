using System;

namespace Programa07_08_Operador_AND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AND - && - Y
            // Solo es verdadero cuando los dos son verdaderos
            // A  B | C
            // F  F | F
            // F  V | F
            // V  F | F
            // V  V | V

            // Este programa imprime la suma solo cuando estos dos programas sean
            // menores a 10

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

            // Verificamos que a y b sean menor que 10
            if (a < 10 && b < 10)
            {
                suma = a + b;
                Console.WriteLine("La suma total es {0}", suma);
            }

            else
            {
                Console.WriteLine("Los numeros ingresados o uno de ellos son mayor o igual a 10");
            }
        }
    }
}
