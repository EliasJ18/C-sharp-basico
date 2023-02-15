using System;

namespace Programa06_04_Ejercicos_Convert_y_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que convierta ARS a USD

            // Variables
            //string dato = "";
            //double ars = 0.0;
            //double usd = 0.0;

            //// Pedir la cantidad de ARS a convertir
            //Console.WriteLine("Ingrese la cantidad de ARS a convertir:");
            //dato = Console.ReadLine();
            //ars = Convert.ToDouble(dato);

            //// Calcular
            //usd = ars / 283.20;

            //// Mostrar Resultado
            //Console.WriteLine("${0} ARS es igual {1} USD", ars, usd);

            // -------------------------------------------------------------------------------

            // Programa que calcule el promedio de tres numeros

            // Variables
            string dato = "";
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double avg = 0.0;

            // Pedir numero1
            Console.WriteLine("Ingrese el primer numero;");
            dato = Console.ReadLine();
            num1 = Convert.ToInt32(dato);

            // Pedir numero2
            Console.WriteLine("Ingrese el segundo numero;");
            dato = Console.ReadLine();
            num2 = Convert.ToInt32(dato);

            // Pedir numero3
            Console.WriteLine("Ingrese el tercer numero;");
            dato = Console.ReadLine();
            num3 = Convert.ToInt32(dato);

            // Calcular
            avg = (num1 + num2 + num3) / 3;

            // Mostrar Resultado
            Console.WriteLine("El promedio es {0}", avg);
        }
    }
}
