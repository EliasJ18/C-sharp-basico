using System;

namespace Programa09_01_02_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Los arreglos son también conocidos como Arrays, vectores o matrices
            // Los arreglos son como una lista de cosas que podemos guardarle
            // como numeros, strings, etc.

            // Variables
            double[] calif = new double[3];
            double promedio = 0.0;
            double suma = 0.0;
            double dif = 0.0;

            // Ciclo para guardar las calificaciones del usuario
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la calificación {0}", i + 1);
                calif[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculamos el promedio
            for (int i = 0; i < 3; i++)
            {
                suma += calif[i];
            }

            promedio = suma / 3;

            // Calculamos diferencia e imprimimos
            for (int i = 0; i < 3; i++)
            {
                dif = promedio - calif[i];
                Console.WriteLine("La calificación es {0}, el promedio es {1} y la diferencia es {2}", calif[i], promedio, dif);
            }

        }
    }
}
