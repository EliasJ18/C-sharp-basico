using System;

namespace Programa07_05_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1
            // Programa para determinar si un numero es par o impar

            // Variables
            //string dato = "";
            //double num1 = 0.0;

            //// Preguntar por la medida a convertir
            //Console.WriteLine("¿Tu numero es par? Ingresalo:");
            //dato = Console.ReadLine();
            //num1 = Convert.ToDouble(dato);

            //// Comprobar si es par o no, hacer los calculos y mostrar resultados
            //if (num1 % 2 == 0)

            //    Console.WriteLine("{0} es un numero par", num1);
            //else
            //    Console.WriteLine("{0} es un numero impar", num1);

            // -----------------------------------------------------------------------------------------

            // Ejemplo 2
            // Este programa pide datos solo a los mayores de 18 años

            // Variables
            int edad = 0;
            int diferencia = 0;
            string dato = "";
            string nombre = "";
            string ciudad = "";

            // Pedimos la edad
            Console.WriteLine("Por favor ingrese su edad:");
            dato = Console.ReadLine();
            edad = Convert.ToInt32(dato);

            // Si es mayor hacemos lo del bloque del if, si no, lo del bloque del else
            if (edad >= 18)
            {
                // Pedimos los datos
                Console.WriteLine("Dame tu nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Dame tu ciudad de nacimiento");
                ciudad = Console.ReadLine();

                // Escribimos un saludo
                Console.WriteLine("Hola {0}, me da gusto que seas de {1}!", nombre, ciudad);
            } 
            
            else

            {
                // Calculamos cuantos años le quedan para ser mayor
                diferencia = 18 - edad;
                Console.WriteLine("Lo siento, te faltan {0} años para ser mayor :/", diferencia);
            }
        }
    }
}
