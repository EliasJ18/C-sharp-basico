using System;

namespace Programa07_04_bloque_de_codigo_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que convierte de metros a pies o pies a metros, según lo seleccione el usuario

            // Variables
            string dato = "";
            int opcion = 0;
            double num1 = 0.0;
            double resultado = 0.0;

            // Preguntar por la medida a convertir
            Console.WriteLine("Este programa convierte de Metros a Pies o de Pies a Metros segun lo desees. Dame la medida (solo numeros)");
            dato = Console.ReadLine();
            num1 = Convert.ToDouble(dato);

            // Preguntar por la conversión
            Console.WriteLine("Seleccione con el numero correspondiente la conversión deseada: 1. Metros a Pies, 2. Pies a Metros");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            // Comprobar la eleccion, hacer los calculos y mostrar resultados
            if (opcion == 1)
            {
                resultado = num1 * 3.28;
                Console.WriteLine("{0} Metro/s son {1} Pie/s", num1, resultado);
            }

            if (opcion == 2)
            {
                resultado = num1 / 3.28;
                Console.WriteLine("{0} Pie/s son {1} Metro/s", num1, resultado);
            }

        }
    }
}
