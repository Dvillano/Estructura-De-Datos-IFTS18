using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tarea 9: Crea un programa que calcule el producto de dos números introducidos por el usuario

            Console.WriteLine("Ingrese primer numero: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("El producto de {0} por {1} es: {2}", n1, n2, n1 * n2);

        }
    }
}
