﻿using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // dibujo de cada linea (bucle externo)

            for (int fila = 1; fila <= 7; fila++)
            {
                // dibuja espacios en blanco (1er bucle interno)
                for (int espacios = 7 - fila; espacios > 0; espacios--)
                {
                    Console.Write(" "); //espacio en blanco
                }

                for (int conta = 1; conta < (2*fila); conta++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }
        }
    }
}
