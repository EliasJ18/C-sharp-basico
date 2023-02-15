using System;

namespace Programa07_12_Escaleras_de_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mismo programa que en el proyecto 07_02-03
            // Mejorado con las escaleras de if
            // Programa que suma, resta, divide o multiplica dos numeros según lo desee el usuario

            // Variables
            string dato = "";
            double num1 = 0.0;
            double num2 = 0.0;
            double res = 0.0;
            int seleccion = 0;

            // Pedir numeros
            Console.WriteLine("Dame el primer numero");
            dato = Console.ReadLine();
            num1 = Convert.ToDouble(dato);

            Console.WriteLine("Dame el segundo numero");
            dato = Console.ReadLine();
            num2 = Convert.ToDouble(dato);

            // Pedir tipo de operacion deseada
            Console.WriteLine("Seleccione en numero la operación deseada: 1. Suma, 2. Resta, 3. Division, 4. Multiplicación");
            dato = Console.ReadLine();
            seleccion = Convert.ToInt32(dato);

            // Determinar y llevar a cabo los cálculos según lo elegido por el usuario
            if (seleccion == 1)
                res = num1 + num2;
            else if (seleccion == 2)
                res = num1 - num2;
            else if (seleccion == 3)
                res = num1 / num2;
            else if (seleccion == 4)
                res = num1 * num2;
            else
                Console.WriteLine("Su selección es inválida");

            // Resultado final
            Console.WriteLine("El resultado es {0}", res);
        }
    }
}
