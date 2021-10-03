using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que pida una letra al usuario y diga si se trata de una vocal

            char letra;

            Console.WriteLine("Ingrese una letra: ");
            letra = char.Parse(Console.ReadLine());

            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("{0} es una vocal", letra);
            }
            else
            {
                Console.WriteLine("{0} no es una vocal", letra);
            }
        }
    }
}
