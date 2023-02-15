using System;

namespace Programa06_02_Uso_de_Convert_y_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable
            string dato = "";
            int valor = 0;
            double valorpf = 0.0;

            // Pedir Numero
            Console.WriteLine("Dame un numero:");
            dato = Console.ReadLine();
            valor = Convert.ToInt32(dato);

            // Mostrar resultado
            Console.WriteLine("Tu numero es {0}", valor);

            // Pedir valor de punto flotante
            Console.WriteLine("Dame un numero de punto flotante:");
            dato = Console.ReadLine();
            valorpf = Convert.ToDouble(dato);

            // Mostrar valor
            Console.WriteLine("Tu numero de punto flotante es {0}", valorpf);
        }
    }
}
