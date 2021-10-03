using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que muestre la tabla de multiplicar del 9

            Console.WriteLine("Tabla de multiplicar del 9: ");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("9 * {0} = {1}",i, 9 * i);
            }
        }
    }
}
