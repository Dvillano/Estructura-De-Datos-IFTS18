using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; b=b*5;  a = a * 2; Crea un programa que lo resuelva.

            int a = 5;
            int b = ++a;
            int c = a++;

            Console.WriteLine("a = 5");
            Console.WriteLine("b = ++a; b = {0}", b);
            Console.WriteLine("c = a++; c = {0}", c);
            Console.WriteLine("b = b *5; b = {0}", b * 5);
            Console.WriteLine("El nuevo valor de a es: {0}", a);
            Console.WriteLine("a = a * 2; a = {0}", a * 2);

        }
    }
}
