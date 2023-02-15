using System;

namespace Programa09_03_Más_sobre_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa similar al proyecto 09_01-02 aplicando una solucion
            // si no se sabe cuantas calificaciones ingresará el alumno.

            // Variables
            double[] calif;

            double promedio = 0.0;
            double suma = 0.0;
            double dif = 0.0;
            int cantCaf = 0;

            //Pedimos la cantidad de calificaciones que se quiere ingresar
            Console.WriteLine("Ingresá la cantidad de notas a promediar");
            cantCaf = Convert.ToInt32(Console.ReadLine());

            calif = new double[cantCaf];

            // Pedimos las calificaciones
            for (int i = 0; i < calif.Length; i++)
            {
                Console.WriteLine("Ingrese la calificación {0}", i + 1);
                calif[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < calif.Length; i++)
            {
                suma += calif[i];
            }

            promedio = suma / cantCaf;

            // Calculamos diferencia e imprimimos
            for (int i = 0; i < calif.Length; i++)
            {
                dif = promedio - calif[i];
                Console.WriteLine("La calificación es {0}, el promedio es {1} y la diferencia es {2}", calif[i], promedio, dif);
            }
        }
    }
}
