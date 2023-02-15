using System;

namespace Programa05_02_Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que calcule el area y perimetro de un cuadrado

            // Variables
            double lado = 5.0;
            double area = 0.0;
            double perimetro = 0.0;

            // Solucion:
            perimetro = lado * 4;

            area = lado * lado;

            Console.WriteLine("El perimetro del cuadrado es {0}cm y su area es {1}cm2", perimetro, area);

            // -----------------------------------------------------------------------------------------------------

            // Convertir de Celsius a Fahrenheit

            // Variables
            double c = 38.3;
            double f = 0.0;

            // Solución
            f = (c * 9 / 5) + 32;

            Console.WriteLine("{0} grados celsius son {1} grados Fahrenheit", c, f);

            // ------------------------------------------------------------------------------------------------------

            // Calcular el area de una casa con tres habitaciones

            // Variables
            double ancho1 = 4.3;
            double largo1 = 4.0;
            double area1 = 0.0;

            double ancho2 = 5.0;
            double largo2 = 6.7;
            double area2 = 0.0;

            double ancho3 = 2.89;
            double largo3 = 3.54;
            double area3 = 0.0;

            double areaTotal = 0.0;

            // Solucion

            area1 = ancho1 * largo1;
            area2 = ancho2 * largo2;
            area3 = ancho3 * largo3;

            areaTotal = area1 + area2 + area3;

            Console.WriteLine("El area de la primera habitacion es de {0}, el de al segunda es {1}" +
            " y el de la tercera es {2}. El area total de la casa es {3}", area1, area2, area3, areaTotal);

        }
    }
}
