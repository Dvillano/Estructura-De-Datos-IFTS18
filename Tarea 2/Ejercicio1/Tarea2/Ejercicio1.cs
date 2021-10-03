using System;

namespace Tarea2
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            // Crea un programa que pida al usuario su identificador y su contraseña (ambos numéricos), y no le permita seguir hasta que introduzca como identificador "1234" y como
            //contraseña "1111".

            int identificador, contrasenia;

            do
            {
                Console.WriteLine("Ingrese identificador: ");
                identificador = Convert.ToInt32(Console.ReadLine());
            } while (identificador != 1234);


            do
            {
                Console.WriteLine("Ingrese contraseña: ");
                contrasenia = Convert.ToInt32(Console.ReadLine());
            } while (contrasenia != 1111);

            Console.WriteLine("Bienvenido");

        }
    }
}
