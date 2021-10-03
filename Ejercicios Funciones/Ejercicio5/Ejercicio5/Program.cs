using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crea una calculadora básica, llamada "calcula", que deberá sumar, restar,
            // multiplicar o dividir los dos números que se le indiquen como parámetros. Ejemplos de
            // su uso sería "calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)

            Console.WriteLine("Ingrese operacion (Ej: calcula 2 + 3 o calcula 5 * 60)");
            string linea = Console.ReadLine();
            string[] operacion = linea.Split(' ');

            string calcula = operacion[0];
            float n1 = float.Parse(operacion[1]);
            float n2 = float.Parse(operacion[3]);
            string operador = operacion[2];

 
            switch (operador)
            {
                case "+":
                    Console.WriteLine("Resultado: {0:N2}", calcularSuma(n1, n2));
                    break;
                case "-":
                    Console.WriteLine("Resultado: {0:N2}", calcularResta(n1, n2));
                    break;
                case "*":
                    Console.WriteLine("Resultado: {0:N2}", calcularMultiplicacion(n1, n2));
                    break;
                case "/":
                    Console.WriteLine("Resultado: {0:N2}", calcularDivision(n1, n2));
                    break;
            }

        }

        public static float calcularSuma(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float calcularResta(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float calcularMultiplicacion(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float calcularDivision(float n1, float n2)
        {
            if (n2 != 0)
                return n1 / n2;
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
                return 0;
            }
       
        }




    }
}
