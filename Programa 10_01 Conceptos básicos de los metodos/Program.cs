using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace Programa_10_01_Conceptos_básicos_de_los_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En este modulo simplificaremos el programa usando metodos
            // Programa para calcular el promedio de cinco numeros


            // version innecesaria y larga:

            // Variables
            //string dato = "";
            //double num1 = 0.0;
            //double num2 = 0.0;
            //double num3 = 0.0;
            //double num4 = 0.0;
            //double num5 = 0.0;
            //double promedio = 0.0;

            //// Pedir numero 1
            //Console.WriteLine("Dame el numero 1");
            //dato = Console.ReadLine();
            //num1= Convert.ToDouble(dato);

            //// Pedir numero 2
            //Console.WriteLine("Dame el numero 2");
            //dato = Console.ReadLine();
            //num2 = Convert.ToDouble(dato);

            //// Pedir numero 3
            //Console.WriteLine("Dame el numero 3");
            //dato = Console.ReadLine();
            //num3 = Convert.ToDouble(dato);

            //// Pedir numero 4
            //Console.WriteLine("Dame el numero 4");
            //dato = Console.ReadLine();
            //num4 = Convert.ToDouble(dato);

            //// Pedir numero 5
            //Console.WriteLine("Dame el numero 5");
            //dato = Console.ReadLine();
            //num5 = Convert.ToDouble(dato);

            //// Calcular promedio
            //promedio = (num1 + num2 + num3 + num4 + num5) / 5;

            //Console.WriteLine("El promedio es {0}", promedio);

            // ----------------------------------------------------------

            // Usamos metodos (funciones)
            // Los nombres de funciones no pueden ser iniciados por numeros
            // Reutilizamos código
            // Especialización
            // Más facil entendimiento y depuración

            // Variables
            string dato = "";
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            double num5 = 0.0;
            double promedio = 0.0;

            // Pedir numero1
            num1 = Pedir(1);

            // Pedir numero2
            num2 = Pedir(2);

            // Pedir numero3
            num3 = Pedir(3);

            // Pedir numero4
            num4 = Pedir(4);

            // Pedir numero5
            num5 = Pedir(5);

            // Mostrar promedio
            promedio = (num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine("El promedio es {0}", promedio);
        }

        // Las funciones se definen fuera de Main (static void Main).

        // Cuando creamos funciones, se establecen en "public" para que 
        // cualquier programa acceda a ellas.

        // "static" Es reconocido por Main y asi poder utilizarlo
        // Mas info de static en Programación Orientada a Objetos

        // "double" En la declaracion de la funcion 
        // nos dice que tipo de valor retorna la función.

        // Hacemos la funcion que pedirá los numeros al usuario
        public static double Pedir(int n)
        {
            double numero = 0.0;

            Console.WriteLine("Dame el numero {0}", n);
            numero = Convert.ToDouble(Console.ReadLine());

            return numero;
        }
    }
}
