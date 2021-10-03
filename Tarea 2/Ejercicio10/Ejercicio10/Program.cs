using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Martín", o bien le diga "No te conozco" si teclea otro nombre.

            string nombre;

            Console.WriteLine("¿Cual es tu nombre?");
            nombre = Console.ReadLine();

            if (nombre == "martin" || nombre == "Martin" || nombre == "Martín" || nombre == "MARTIN")
            {
                Console.WriteLine("Hola Martín");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }

        }
    }
}
