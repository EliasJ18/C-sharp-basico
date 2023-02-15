using System;

namespace Programa10_03_Ejercicios_con_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que calcule el costo de construir una casa
            // Se pedirá la cantidad de habitaciones y las dimensiones de cada una
            // El costo por m2 de habitacion es de $300 con impuesto de 5%
            // El costo por m2 de cocina y sanitario es de $375 con impuesto de 12%
            // El costo por m2 de jardin es de $120 con impuesto del 0$

            // Variable
            int i = 0;
            int cantHab = 0;
            int tipoHab = 0;
            double granTotal = 0.0;
            double area = 0.0;
            double costoHab = 0.0;

            // Lo que hace el programa
            Console.WriteLine("Este programa calculará el costo total de su casa");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Cuantos elementos hay en tu casa");
            cantHab = Convert.ToInt32(Console.ReadLine());

            // Pido la cantidad de habitaciones
            for (i = 0; i < cantHab; i++)
            {
                // Calcular area
                area = calcularArea();

                // Pedir tipo de habitacion
                Console.WriteLine("Dame el tipo de habitacion: 1- Cuarto, 2- Jardin, 3- Cocina/Baño");
                tipoHab= Convert.ToInt32(Console.ReadLine());

                // Calcular costo
                if (cantHab == 1)
                    costoHab = calcularCosto(area, 300.0, 0.05);

                if (cantHab == 2)
                    costoHab = calcularCosto(area, 120.0, 0.0);

                if (cantHab == 3)
                    costoHab = calcularCosto(area, 375.0, 0.12);

                // Sumar gran total
                granTotal += costoHab;
            }

            // Presentar resultado
            Console.WriteLine("El total es ${0} con impuestos incluidos", granTotal);
        }

        // Funcion para calcular areas
        public static double calcularArea()
        {
            double ladoA = 0.0;
            double ladoB = 0.0;
            double r = 0.0;

            Console.WriteLine("Dame el ancho de la habitacion");
            ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame el largo de la habitacion");
            ladoB = Convert.ToDouble(Console.ReadLine());

            r = ladoA * ladoB;

            return r;
        }

        // Metodo para calcular costo
        public static double calcularCosto(double area, double pM2, double impuesto)
        {
            double costo = 0.0;
            double imp = 0.0;
            double total = 0.0;

            costo = area * pM2;
            imp = costo * impuesto;
            total = costo + imp;

            return total;
        }
    }
}
