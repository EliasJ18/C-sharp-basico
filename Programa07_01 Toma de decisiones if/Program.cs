using System;

namespace Programa07_01_Toma_de_decisiones_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estructuras selectivas
            // if(expresion) {sentencia}
            // Operadores relacionales ==, >, <, >=, <=, !=

            int a = 5;
            int b = 8;
            int c = 5;

            if (a == c)
                Console.WriteLine("a y c son iguales");

            if (b > c)
                Console.WriteLine("b es mayor a c");

            if (a > c)
                Console.WriteLine("a es mayor a c");

            if (a < b)
                Console.WriteLine("a es menor a b");

            if (a >= c)
                Console.WriteLine("a es mayor o igual que c");

            if (a != b)
                Console.WriteLine("a es diferente de b");

            Console.WriteLine("Adios");
        }
    }
}
