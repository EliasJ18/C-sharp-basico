using System;

namespace Programa05_01_Operadores_Aritméticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operadores aritmeticos
            // + suma
            // - resta
            // * multiplicacion
            // / division
            // % modulo
            // = asignacion
            // ( ) agrupacion

            // Variables necesarias
            //double valor1 = 1.5;
            //double valor2 = 4.7;
            //double resultado = 0.0;

            //// Operaciones
            //resultado = valor1 + valor2;

            //Console.WriteLine("{0} + {1} = {2}", valor1, valor2, resultado);

            //resultado = valor1 - valor2;

            //Console.WriteLine("{0} - {1} = {2}", valor1, valor2, resultado);

            //resultado = valor1 * valor2;

            //Console.WriteLine("{0} x {1} = {2}", valor1, valor2, resultado);

            //resultado = valor1 / valor2;

            //Console.WriteLine("{0} / {1} = {2}", valor1, valor2, resultado);

            //resultado = valor1 % valor2;

            //Console.WriteLine("El residuo de {0} / {1} = {2}", valor1, valor2, resultado);

            double valor1 = 1.5;
            double valor2 = 3.7;
            double valor3 = 6.7;
            double resultado = 0.0;

            resultado = 5.6 + 2;

            Console.WriteLine(resultado);

            resultado = valor1 + 10.5;

            Console.WriteLine(resultado);

            // Prioridad en las operaciones/se resuelve primero;
            // mul *, div /, mod %
            // sum +, res -

            resultado = 5 + 6 * 2;
            Console.WriteLine(resultado);

            resultado = 5 + (6 * 2);
            Console.WriteLine(resultado);

            resultado = (5 + 6) * 2;
            Console.WriteLine(resultado);

            resultado = ((valor1+valor2) * (valor2/valor3));
            Console.WriteLine(resultado);
        }
    }
}
