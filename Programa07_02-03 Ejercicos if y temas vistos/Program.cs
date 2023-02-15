using System;

namespace Programa07_02_03_Ejercicos_if_y_temas_vistos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que suma, resta, divide o multiplica dos numeros según lo desee el usuario

            // Variables
            string dato = "";
            double num1 = 0.0;
            double num2 = 0.0;
            double res = 0.0;

            // Pedir numeros
            Console.WriteLine("Dame el primer numero");
            dato = Console.ReadLine();
            num1 = Convert.ToDouble(dato);

            Console.WriteLine("Dame el segundo numero");
            dato = Console.ReadLine();
            num2 = Convert.ToDouble(dato);

            // Pedir tipo de operacion deseada
            Console.WriteLine("Selecciones en letras la operación deseada: a. Suma, b. Resta, c. Division, d. Multiplicación");
            dato = Console.ReadLine();

            // Determinar y llevar a cabo los cálculos según lo elegido por el usuario
            if (dato == "a")
                res = num1 + num2;
                Console.WriteLine("Los numeros sumados dan {0}", res);

            if (dato == "b")
                res = num1 - num2;
                Console.WriteLine("Los numeros restados dan {0}", res);

            if (dato == "c")
                res = num1 / num2;
                Console.WriteLine("Los numeros divididos dan {0}", res);

            if (dato == "d")
                res = num1 * num2;
                Console.WriteLine("Los numeros multiplicados dan {0}", res);
        }
    }
}
