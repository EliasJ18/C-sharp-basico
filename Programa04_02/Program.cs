using System;

namespace Programa04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración con inicialización -> tipo, nombre = x;
            double impuesto = 1.13;
            bool encendido = true;
            char letra = 'A';
            string palabra = "Hola";
            int numero = 19;

            Console.WriteLine("Impuesto = {0}, numero = {1}", impuesto, numero);

            Console.WriteLine("Se tiene {1} en el bool y {0} en la letra", letra, encendido);

            Console.WriteLine("La cadena dice {0}", palabra);

            encendido = false;
            letra = '&';
            impuesto = -387.986;
            palabra = "Adios";

            Console.WriteLine("Impuesto = {0}, numero = {1}", impuesto, numero);

            Console.WriteLine("Se tiene {1} en el bool y {0} en la letra", letra, encendido);

            Console.WriteLine("La cadena dice {0}", palabra);
        }
    }
}
