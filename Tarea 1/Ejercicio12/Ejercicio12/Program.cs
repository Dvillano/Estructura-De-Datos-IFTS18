using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarea 12: Crea un programa que pida al usuario dos números enteros. Si el segundo no
            //es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el contrario,
            //si el segundo número es cero, escribirá "Error: No se puede dividir entre cero"

            float n1, n2;

            Console.WriteLine("Ingrese primer numero entero");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero entero");
            n2 = float.Parse(Console.ReadLine());

            if (n2 != 0)
            {
                Console.WriteLine("{0} dividido entre {1} es: {2}", n1, n2, n1 / n2);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }

        }
    }
}
