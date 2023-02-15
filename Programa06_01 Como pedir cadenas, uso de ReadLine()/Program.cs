using System;

namespace Programa06_01_Como_pedir_cadenas__uso_de_ReadLine__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // La funcion ReadLine() guarda informacion proveniente del usuario, en cadenas/string.

            // Variables
            string info = "";

            // Pedir nombre
            Console.WriteLine("Por favor ingrese su nombre y luego presione la tecla Enter:");
            info = Console.ReadLine();

            // Saludar
            Console.WriteLine("Hola {0}, mucho gusto!!", info);

            //------------------------------------------------------------------

            // Variables
            string fname = "";
            string lname = "";

            // Pedir nombre
            Console.WriteLine("Por favor ingrese su nombre y luego presione la tecla Enter:");
            fname = Console.ReadLine();

            // Pedir apellido
            Console.WriteLine("Por favor ingrese su apellido y luego presione la tecla Enter:");
            lname = Console.ReadLine();

            // Mostar mensaje
            Console.WriteLine("Hola {0}!, tengo un amigo de apellido {1} también!", fname, lname);
        }
    }
}
