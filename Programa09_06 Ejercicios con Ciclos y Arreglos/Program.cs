using System;

namespace Programa09_06_Ejercicios_con_Ciclos_y_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que pide al usuario numeros y dice cuantas apariciones tiene el numero
            // Los numeros deben ser del 0 al 10
            // También debe mostrar que numero se repitió mas veces

            // Variables
            int num = 0;
            int[] arrayNum = new int[11];
            int mayor = 0;


            for (int i = 0; i < 11; i++)
            {

            }

            // Pedimos los numeros
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Ingrese un numero del 0 al 10");
                num = Convert.ToInt32(Console.ReadLine());

                arrayNum[num]++;
    
            }

            for (int i = 0; i < 11; i++)
            { 

            Console.WriteLine("El numero {0} apareció {1} veces", i, arrayNum[i]);
            }

            for (int i = 0; i < 11; i++)
            {
                if (arrayNum[i] > mayor)
                    mayor = i;
            }
            
            Console.WriteLine("El numero que se repitió mas veces es {0}", mayor);

        }
    }
}
