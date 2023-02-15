using System;

namespace Programa08_06_07_Ciclo_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa similar al proyecto 06_04, ahora mostrando
            // el uso del ciclo Do While
            // El Ciclo Do While se lleva a cabo almenos una vez
            // Y se usa cuando no sabemos la cantidad de repeticiones

            // Variables
            int opcion = 0;
            string dato = "";
            double tipoCambio = 284;
            double ars = 0.0;
            double usd = 0.0;

            // Hacemos el ciclo Do While
            do
            {
                Console.WriteLine("1. Pesos a Dolares | 2. Dolares a Pesos | 3. Salir");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                if (opcion == 1)
                {
                    // Pedimos los pesos
                    Console.WriteLine("Ingrese cantidad de pesos");
                    dato = Console.ReadLine();
                    ars = Convert.ToDouble(dato);

                    // Convertimos
                    usd = ars / tipoCambio;
                    Console.WriteLine("Son {0} dolares", usd);
                }

                if (opcion == 2)
                {
                    // Pedimos los pesos
                    Console.WriteLine("Ingrese cantidad de dolares");
                    dato = Console.ReadLine();
                    usd = Convert.ToDouble(dato);

                    // Convertimos
                    ars = usd * tipoCambio;
                    Console.WriteLine("Son {0} pesos", ars);
                }

            } while (opcion != 3);

            Console.WriteLine("Adios");
        }
    }
}
