using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea una función "SumaCifras" que reciba un numero cualquiera y que
            //devuelva como resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la
            //suma sería 6.

            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los digitos de {0} es {1}", numero, SumaCifras(numero));

        }

        static public int SumaCifras(int numero)
        {
            int suma = 0;

            while (numero != 0)
            {
                suma += numero % 10;
                numero /= 10;
            }

            return suma;
        }
    }
}
