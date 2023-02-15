using System;

namespace Programa07_14_15_Ejercicios_con_If_Else_y_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa que convierte de millas a km o de km a millas

            // Variables
            //string dato = "";
            //double km = 0.0;
            //double millas = 0.0;
            //int opcion = 0;
            //double rta = 0.0;

            //// Presentar un menú
            //Console.WriteLine("Elije una opcion: 1. Convertir Km a Millas, 2. Convertir Millas a Km");
            //dato = Console.ReadLine();
            //opcion = Convert.ToInt32(dato);



            //// Si es de kilometros a millas
            //if (opcion == 1)
            //{
            //    Console.WriteLine("Ingrese las Kilometros a convertir");
            //    dato = Console.ReadLine();
            //    km =  Convert.ToInt32(dato);

            //    rta = km / 1.609;
            //    Console.WriteLine("{0} Kilometros son {1} Millas", km, rta);
            //}
            //// Si es millas a kilometros
            //else if (opcion == 2)
            //{
            //    Console.WriteLine("Ingrese las millas a convertir");
            //    dato = Console.ReadLine();
            //    millas = Convert.ToInt32(dato);

            //    rta = millas * 1.609;
            //    Console.WriteLine("{0} Millas son {1} Kilometros", millas, rta);
            //}
            //else
            //{
            //    Console.WriteLine("Ingrese una opcion valida");
            //}

            // ------------------------------------------------------------------------

            // Programa que convierte el peso en la tierra al peso en Mercurio, Venus o Marte

            // Variables
            string dato = "";
            int planeta = 0;
            double peso = 0.0;
            double rta = 0.0;

            // Pedir el planeta
            Console.WriteLine("Ingrese el planeta: 1. Mercurio, 2. Venus, 3. Marte");
            dato = Console.ReadLine();
            planeta = Convert.ToInt32(dato);

            // Pedir el peso en la tierra
            Console.WriteLine("Ingrese su peso:");
            dato = Console.ReadLine();
            peso = Convert.ToInt32(dato);

            // Verificar en que planeta fue
            switch (planeta)
            {
                // Caso Mercurio
                case 1:
                    rta = peso * 0.38;
                    break;

                // Caso Venus
                case 2:
                    rta = peso * 0.91;
                    break;
                // Caso Marte
                case 3:
                    rta = peso * 0.38;
                    break;

                default:
                    Console.WriteLine("Ingrese una opcion valida");
                    break;
            }
            // Mostrar el peso convertido
            Console.WriteLine("Tu peso sería {0} kg", rta);
        }
    }
}
