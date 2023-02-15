using System;
using System.Security.Cryptography;

namespace Programa10_02_Metodos_que_solo_realizan_trabajo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que realiza operaciones aritmeticas usando metodos

            // Variables
            string dato = "";
            int opcion = 0;
            double a = 0;
            double b = 0;
            double r = 0;

            // Presentamos menú
            do
            {
                Console.WriteLine("1- Suma, 2- Resta, 3- Multi, 4- Division, 5-Salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                if (opcion == 1)
                    suma();

                if (opcion == 2)
                {
                    Console.WriteLine("Dame el numero 1:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Dame el numero 2:");
                    b = Convert.ToDouble(Console.ReadLine());

                    resta(a, b);
                }

                if (opcion == 3)
                {
                    r = multi();

                    Console.WriteLine("El resultado de la multiplicacion es {0}", r);
                }

                if (opcion == 4)
                {
                    Console.WriteLine("Dame el numero 1:");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Dame el numero 2:");
                    b = Convert.ToDouble(Console.ReadLine());

                    r = div(a, b);

                    Console.WriteLine("El resultado de la division es {0}", r);
                }

            } while (opcion != 5);
        }

        // Primer estilo de Metodos
        // Metodo que solo ejecuta código y no regresa valor
        // Cuando los metodos no retornan ningún valor (return), se le
        // debe declarar con void.
        public static void suma()
        {
            double x = 0;
            double y = 0;
            double rta = 0;

            Console.WriteLine("Dame el primer numero:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero:");
            y = Convert.ToInt32(Console.ReadLine());

            rta = x + y;

            Console.WriteLine("El resultado de la suma es {0}", rta);
        }

        // Segundo estilo de Metodos
        // Metodo que recibe valores por medio de sus parametros y regresa valor
         public static void resta(double x, double y)
        {
            double rta = 0;

            rta = x - y;

            Console.WriteLine("El resultado de la resta es {0}", rta);
        }

        // Tercer estilo de Metodos
        // Metodo que no recibe valor por parametros y regresa valor
        // Regresa valor (return) entonces se quita el void
        // Cuando las funciones retornan valor, se debe especificar en la
        // declaracion que tipo de valor devuelve la funcion. En este caso
        // devuelve un valor tipo double.
        public static double multi()
        {
            double x = 0;
            double y = 0;
            double rta = 0;

            Console.WriteLine("Dame el primer numero:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero:");
            y = Convert.ToInt32(Console.ReadLine());

            rta = x * y;

            return rta;
        }

        // Cuarto estilo de Metodos
        // Metodo que recibe valor por parametros y regresa valor 
        public static double div(double x, double y)
        {
            double r = 0;

            r = x / y;

            return r;
        }
    }
}
