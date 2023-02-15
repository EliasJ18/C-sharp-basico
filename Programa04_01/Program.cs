using System;

namespace Programa04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos:
            // bool - booleanos v o f
            // char - caracteres
            // int - numeros enteros
            // float - numeros de punto flotante
            // double - numeros con punto decimal
            // string - colecciones de caracteres; frases, palabras, etc.

            // Ciclo de vida de las variables:
            // Declaración - Creamos la variable
            // Inicialización - Cuando se le da su primer valor
            // Asignación - Cuando se le da un valor nuevo

            // Declaracion -> tipo de variable(dato que almacenará) y su nombre;
            int valor;

            // Inicialización nombre = x;
            valor = 5;

            Console.WriteLine("Valor de inicio es {0}",valor);

            // Asignación nombre = y;
            valor = 7;

            Console.WriteLine("El valor final es {0}",valor);

        }
    }
}
