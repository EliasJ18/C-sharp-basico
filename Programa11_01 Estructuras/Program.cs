using System;

namespace Programa11_01_Estructuras
{
    internal class Program
    {
        // Al crear una estructura, hay que declararla fuera de Main, usando
        // "public struct *nombre*" usando public si se quiere que sea publico y
        // el exterior de la estructura acceda a sus datos.

        // Una vez creada la estructura, el contenido de cada campo se define
        // ahora si, dentro de Main.

        // En este caso crearemos una estructura de "empleados" que almacenará
        // datos de trabajadores como ser; nombre, id, edad y sueldo.

        // Creación de la estructura
        public struct empleado
        {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;
        }

        static void Main(string[] args)
        {
            // Creamos una variable del tipo *empleado*
            empleado uno;

            // Asignacion de valores
            uno.nombre = "Juan";
            uno.edad = 28;
            uno.id = 567;
            uno.sueldo = 10500.50;

            // Impresion de valores
            Console.WriteLine(uno.nombre);
            Console.WriteLine(uno.edad);
            Console.WriteLine(uno.id);
            Console.WriteLine(uno.sueldo);
        }
    }
}
