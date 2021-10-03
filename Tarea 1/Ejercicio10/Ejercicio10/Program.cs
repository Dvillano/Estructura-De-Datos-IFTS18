using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tarea 10: Crea un programa que pida al usuario un número entero y diga si es par (pista:
            // habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) …).

            Console.Write("Ingrese numero: ");
            int n = Int32.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("El numero {0} es par", n);
            }
            else
            {
                Console.WriteLine("El numero {0} es impar", n);
            }
        }
    }
}
