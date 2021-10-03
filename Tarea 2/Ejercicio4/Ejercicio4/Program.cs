using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que contenga un bucle sin fin que muestre los números enteros positivos a partir del uno

            int n = 1;

            do
            {
                Console.WriteLine(n);
                n++;
            } while (n > 0);
        }
    }
}
