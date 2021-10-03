using System;

namespace Ejercicio1
{
    class Program
    {

        public static int Signo(float n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n > 0){
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            // Crea una función llamada "Signo", que reciba un número real, y devuelva un número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.

            Console.WriteLine("Ingrese numero: ");
            float n = float.Parse(Console.ReadLine());

            int signo = Signo(n);
            Console.WriteLine(signo);
        }
    }
}
