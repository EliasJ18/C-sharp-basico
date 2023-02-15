using System;

namespace Programa08_08_Ciclo_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa 
            // Puede no llevarse a cabo ni una vez
            // Se usa cuando no sabemos el numero de repeticiones

            // Variables
            //int dinero = 0;
            //int opcion = 0;
            //int total = 0;

            //// Pedimos la cantidad de dinero
            //Console.WriteLine("¿Cuanto dinero tienes?");
            //dinero = Convert.ToInt32(Console.ReadLine());

            //while (dinero > 0 && opcion != 5) 
            //{
            //    // Presentamos menú
            //    Console.WriteLine("1. Dulces | 2. Papas | 3. Chocolates | 4. Helado | 5. Salir");
            //    opcion = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            dinero -= 3;
            //            total += 3;
            //            break;

            //        case 2:
            //            dinero -= 12;
            //            total += 12;
            //            break;

            //        case 3:
            //            dinero -= 7;
            //            total += 7;
            //            break;

            //        case 4:
            //            dinero -= 25;
            //            total += 25;
            //            break;
            //    }
            //    Console.WriteLine("Tienes ${0} y has gastado ${1}", dinero, total);
            //} // Fin del while

            //Console.WriteLine("Adios!");

            // Ejercicio pendiente;  Los alumnos desean ingresar en un curso y tienen que escoger entre 4 grupos,
            // pero cada grupo tiene un límite de 15 integrantes o cupos,
            // y si en dado caso un grupo este completo, le dé al alumno oportunidad de
            // volver a seleccionar otro y al final se debe imprimir cuantos alumnos hay en cada grupo hasta el momento.

            // Variables
            int opcion = 0;
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;

            // Preguntamos por id de estudiante

            // Preguntamos por el grupo
            Console.WriteLine("Escoge un grupo: 1. Grupo A | 2. Grupo B | 3. Grupo C | 4. Grupo D | 5. Salir");
            opcion = Convert.ToInt32(Console.ReadLine());




        }
    }
}
