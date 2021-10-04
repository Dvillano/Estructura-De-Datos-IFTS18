using System;
using System.Collections; // Para usar pilas y colas

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que pida al usuario 6 números enteros y luego los muestre en orden contrario,
            // utilizando una pila.

            // Instanciamos una pila llamada miPila
            Stack miPila = new Stack();
            int n;

            // Agregamos los 6 numeros en orden a la pila
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Ingrese numero {0}:", i+1 );
                n = int.Parse(Console.ReadLine());
                miPila.Push(n);
            }

            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                //Imprimimos el ultimo elemento añadido a la pila
                Console.WriteLine( miPila.Peek() );

                //Removemos el ultimo elemento añadido a la pila
                miPila.Pop();
            }



        }
    }
}
