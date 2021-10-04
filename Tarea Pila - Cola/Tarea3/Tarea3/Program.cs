using System;
using System.Collections;

namespace Tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea un programa que pida frases al usuario, hasta que introduzca una frase vacía. En ese
            // momento, mostrará todas las frases que se habían introducido.

            Queue miCola = new Queue();
            string frase = string.Empty;

            // Guardamos frases en cola
            do
            {
                Console.WriteLine("Ingrese una frase o ingrese una frase vacia para salir: ");
                frase = Console.ReadLine();
                miCola.Enqueue(frase);
            } while (frase != string.Empty);

            Console.WriteLine("Frases ingresadas: ");
            // Imprimimos frases de la cola
            foreach (var item in miCola)
            {
                Console.WriteLine(item);
            }

        }
    }
}
