using System;

namespace Programa08_04_Ejemplos_de_uso_del_Ciclo_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mismo programa que el proyecto Programa06_04, esta vez mejorado con Ciclo For
            // Programa que calcula el promedio de tres numeros

            // Variables
            string dato = "";
            double valor = 0.0;
            double avg = 0.0;
            int cantidad = 0;
            double suma = 0.0;

            // Pedir cantidad de numeros
            Console.WriteLine("¿Cuántos números va a ingresar?");
            dato = Console.ReadLine();
            cantidad = Convert.ToInt32(dato);

            // Pedir numeros
            for (int n = 0; n < cantidad; n++)
            {
                Console.WriteLine("Ingrese el número");
                dato = Console.ReadLine();
                valor= Convert.ToInt32(dato);

                suma += valor;
            }

            // Calculamos el promedio
            avg = suma / cantidad;

            // Mostrar Resultado
            Console.WriteLine("El promedio es {0}", avg);
        }
    }
}
