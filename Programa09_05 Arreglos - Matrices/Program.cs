using System;

namespace Programa09_05_Arreglos___Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que muestra el uso de arreglos en dos dimensiones o matrices

            // Declaracion de Arreglo común: double arreglo = new double[*num elementos*]
            // Declaracion de Arreglo-Matriz: int[,] matriz = new int[4, 7];
            // De esta forma se le dice a la matriz que cree una tabla de 4 renglones
            // y 7 columnas, que se graficamente se puede ver de esta forma:

            // Recordando que el indice parte en 0.
            //   0 1 2 3 4 5 6
            // 0
            // 1
            // 2
            // 3

            // Variables
            double sum = 0.0;
            double promedio = 0.0;
            Random rnd= new Random();
            int[,] datos = new int[4, 7];

            // Llenamos los datos
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    datos[i, j] = rnd.Next(30);
                }
            }

            // Imprimimos los datos
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Semana {0}", i);
                for (int j = 0; j < 7; j++) {
                    Console.Write("{0}, ", datos[i, j]);
                }
                Console.WriteLine();
            }

            // Calculamos el promedio por semana
            for (int i = 0; i < 4; i++)
            {
                sum = 0.0;
                promedio = 0.0;

                for (int j = 0; j < 7; j++)
                {
                    sum += datos[i, j];
                }

                promedio = sum / 7.0;
                Console.WriteLine("El promedio de la semana {0} es {1}", i, promedio);
            }

            // Calculamos el promedio total

            sum = 0.0;
            promedio = 0.0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    sum += datos[i, j];
                }

            }
                promedio = sum / 28.0;
                Console.WriteLine("El promedio total de la semana es {0}", promedio);
        }
    }
}
