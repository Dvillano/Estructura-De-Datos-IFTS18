using System;
using System.Collections;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea un programa que pida al usuario 6 números reales de doble precisión, los guarde en una cola y luego los muestre en pantalla.

            Queue miCola = new Queue();
            double n;

            
            for (int i = 0; i < 6; i++) 
            {
                Console.WriteLine("Ingrese numero {0}: ", i+1);
                n = double.Parse(Console.ReadLine());

                // Agregamos numeros a la cola
                miCola.Enqueue(n);
            }

            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                // Muestra el primer elemento de la cola
                Console.WriteLine( miCola.Peek() );

                // Quita el primer elemento de la cola
                miCola.Dequeue();
            }
        }
    }
}
