using System;

namespace Ejercicio3
{
    class Program
    {
        static public bool EsPrimo(float n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            //Crea una función "EsPrimo", que reciba un número y devuelva el valor
            // booleano "true" si es un número primo o "false" en caso contrario.

            Console.WriteLine("Ingrese numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero)) 
            {
                Console.Write("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }
    }
}
