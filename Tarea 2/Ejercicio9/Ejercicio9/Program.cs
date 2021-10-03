using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se debe introducir dos veces.
            //Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas

            string nombre;
            int password1, password2;

            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese contraseña: ");
                password1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Vuelva a ingresar contraseña: ");
                password2 = int.Parse(Console.ReadLine());

                if(password1 != password2)
                {
                    Console.WriteLine("Estimado {0}, las contraseñas no coinciden, por favor volver a intentarlo", nombre);
                }

            } while (password1 != password2);

            Console.WriteLine("Ingreso correcto");
            
        }
    }
}
