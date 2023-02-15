using System;

namespace Programa06_03_Ejercicios_con_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcule el area y el perimetro de un rectangulo

            // Variables
            string ladoA = "";
            string ladoB = "";
            int num = 0;
            int num2 = 0;
            int resArea = 0;
            int resPer = 0;

            // Pedir lado A
            Console.WriteLine("Dame el lado A:");
            ladoA = Console.ReadLine();
            num = Convert.ToInt32(ladoA);

            // Pedir lado B
            Console.WriteLine("Dame el lado B:");
            ladoB = Console.ReadLine();
            num2 = Convert.ToInt32(ladoB);

            // Calcular el Area
            resArea = num * num2;

            // Calcular el Perimetro
            resPer = num + num + num2 + num2;

            // Mostrar resultado
               Console.WriteLine("El Area es {0} y el perimetro es {1}",resArea, resPer);
        }
    }
}
