using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a *= b; Crea un programa que te lo muestre.

            int a = 5;
            int b = a + 2;
            int c = -3;

            Console.WriteLine("a = 5");
            Console.WriteLine("b = a + 2; b = {0}", b);
            Console.WriteLine("b-=3; b = {0}", b-=3);
            Console.WriteLine("c=-3; c = {0}", c);
            Console.WriteLine("c*= 2; c = {0}", c *= 2);
            Console.WriteLine("++c; c = {0}", ++c);
            Console.WriteLine("a *= b; a = {0}", a *= b);
        }
    }
}
