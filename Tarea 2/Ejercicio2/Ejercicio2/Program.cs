using System;

namespace Ejercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se
            // puede hacer dividiendo varias veces entre 10).

            int cifra = 0; 

            Console.WriteLine("Ingrese numero positivo: ");
            int n = int.Parse(Console.ReadLine());
            
            while(n > 0)
            {
                n = n / 10;
                cifra++;
            }

            Console.WriteLine("El numero de cifras es: {0}", cifra);

        }
    }
}
