using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea 11: Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.
            int n1, n2;

            Console.WriteLine("Ingrese primer numero entero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero entero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("{0} es mayor que {1}", n1, n2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}", n2, n1);
            }
        }
    }
}
