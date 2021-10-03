using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea 13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
            // nombre de ese número, usando "switch"(por ejemplo, si introduce "1", el programa escribirá "uno").

            Console.WriteLine("Ingrese un numero del 1 al 5");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                default:
                    Console.WriteLine("Error: numero ingresado invalido");
                    break;
            }

        }
    }
}
