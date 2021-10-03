using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea una función "Triángulo" que reciba una letra y un número, y
            // escriba un "triángulo" formado por esa letra, que tenga como anchura inicial la que se
            // ha indicado.

            char letra;
            int numero;

            Console.WriteLine("Ingrese letra o símbolo: ");
            letra = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numero: ");
            numero = int.Parse(Console.ReadLine());

            dibujarTriangulo(letra, numero);
        }

        public static void dibujarTriangulo(char figura, int anchura)
        {
            for(int i = 0; i <= anchura; i++)
            {
                Console.WriteLine();
                for(int j = i; j < anchura; j++)
                {
                    Console.Write("{0}", figura);
                }
                
            }
        }
 
    }
}
