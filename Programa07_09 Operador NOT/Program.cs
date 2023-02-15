using System;

namespace Programa07_10_Operador_NOT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NOT - ! - NO
            // Es verdadero cuando el valor es falso
            // A | R
            // F | V
            // V | F

            // Este programa imprime la suma, solo cuando el primer numero NO sea menor a 10

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

            // Verificamos que el nro a no sea menor que 10
            if (!(a < 10))
            {
                // Hacemos la suma
                suma = a + b;

                // Mostramos resultado
                Console.WriteLine("La suma es {0}", suma);
            }

            else
            {
                Console.WriteLine("El primer numero es menor");
            }
        }
    }
}
