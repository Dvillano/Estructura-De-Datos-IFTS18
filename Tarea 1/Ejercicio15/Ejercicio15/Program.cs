using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea 15: Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while"

            int n = 1;

            do
            {
                Console.WriteLine(n);
                n++;
            }
            while (n <= 10);
        }
    }
}
