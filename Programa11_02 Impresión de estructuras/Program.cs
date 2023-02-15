using System;
using System.Text;

namespace Programa11_02_Impresión_de_estructuras
{
    internal class Program
    {
        // En este programa se muestra una manera mas conveniente de imprimir
        // los datos de una estructura
        public struct empleado
        {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;

            // Override lo usamos para decir que usaremos una version 
            // personalizada de la funcion ToString(), y no la version 
            // contenida dentro de Object.

            // La función ToString() retornará una cadena, por ende la funcion
            // es de tipo string.
            public override string ToString()
            {
                // Dentro de la función vamos a crear la cadena que queremos
                // regresar, y para eso aprovechamos una clase llamada
                // StringBuilder, esta clase forma parte de .Net y crea un objeto.
                StringBuilder cadena = new StringBuilder();

                // Y en cadena utilizaremos otro metodo llamado AppendFormat.
                // Este metodo nos va a permitir adicionar adentro de cadena, 
                // una cadena haciendo uso del formato que nosotros podemos
                // utilizar en el WriteLine().

                // La impresion no sale directamente en consola, si no que se
                // guarda en "cadena".
                // \r\n provoca un salto de linea
                cadena.AppendFormat("Empleado: {0}, Nombre: {1}, \r\nEdad: {2}, Sueldo: {3}", id, nombre, edad, sueldo);

                // No necesariamente se deben imprimir todos los datos de la
                // estructura, si se quiere solo se imprime los datos que 
                // interesen segun el caso, como por ejemplo, solo el id y el sueldo.

                // cadena.AppendFormat("Empleado: {0}, Sueldo: {1}", id, sueldo);

                // Aqui se retorna.
                return cadena.ToString();

                
            }
        }
        static void Main(string[] args)
        {
            // Creación de una variable del tipo empleado
            empleado uno;

            // Asignacion de valores
            uno.nombre = "Juan";
            uno.edad = 28;
            uno.id = 567;
            uno.sueldo = 10500.50;

            // Impresion de valores

            // Invocar la variable uno (de tipo empleado) dentro de un WriteLine sólo invoca
            // el método ToString() definido mas arriba, (el método ToString devuelve un tipo string
            // siendo este *cadena*, que contiene todo el mensaje a imprimir).
            Console.WriteLine(uno);

            Console.WriteLine("-------------------------------");

            // Tambien se puede seguir usando la impresion tradicional
            // aunque es repetitivo
            Console.WriteLine(uno.edad);
        }
    }
}
