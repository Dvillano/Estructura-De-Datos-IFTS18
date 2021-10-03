using System;

namespace Ejercicio2
{
    class Program
    {
        static public int Menor(int numero1, int numero2)
        {
            int menor;

            if (numero1 > numero2)
            {
                menor = numero2;    
            }
            else
            {
                menor = numero1;
            }

            return menor;
        }

        static void Main(string[] args)
        {
            //Crea una función "Menor" que calcule el menor de dos números enteros que
            // recibirá como parámetros.El resultado será otro número entero.

            Console.WriteLine("Introduzca primer numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca segundo numero");
            int n2 = int.Parse(Console.ReadLine());

            int resultado = Menor(n1, n2);

            Console.WriteLine("El menor entre {0} y {1} es: {2}", n1, n2, resultado);

        }
    }
}
