using System;
using System.Text;

namespace Programa11_03_Arreglos_de_estructuras
{
    internal class Program
    {
        public struct empleado
        {
            public int id;
            public string nombre;
            public int edad;
            public double sueldo;

            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();

                cadena.AppendFormat("Empleado: {0}, Nombre: {1}, \r\nEdad: {2}, Sueldo: {3}", id, nombre, edad, sueldo);

                return cadena.ToString();


            }
        }

        // En este programa se muestra como crear un Arreglo de estructuras, como
        // asignarle datos y como consultarlos una vez añadidos.
        // Además, la informacion la dará el usuario!!
        static void Main(string[] args)
        {
            // Variables
            int n = 0;
            empleado[] gente = new empleado[3];

            for (n = 0; n < 3; n++)
            {
                Console.WriteLine("Dame el id de la persona {0}", n + 1);
                gente[n].id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dame el nombre de la persona {0}", n + 1);
                gente[n].nombre = Console.ReadLine();

                Console.WriteLine("Dame la edad de la persona {0}", n + 1);
                gente[n].edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dame el sueldo de la persona {0}", n + 1);
                gente[n].sueldo = Convert.ToDouble(Console.ReadLine());
            }

            // Mostramos la informacion
            for (n = 0; n < 3; n++)
            {
                Console.WriteLine(gente[n]);
                Console.WriteLine("-------------------------");

            }

            for (n = 0; n < 3; n++)
            {
                if (gente[n].sueldo < 100000)
                    Console.WriteLine("Aumento para {0}", gente[n].nombre);
            }
        }
    }
}
