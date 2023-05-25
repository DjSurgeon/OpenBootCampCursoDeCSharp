using System;

namespace OpenBootCampCursoDeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tResolución de los ejercicios del curso de C# de OpenBootCamp");
            Ejercicio1();
            Ejercicio2();
        }
        // Resolución Ejercicio 1
        // Escribe un programa que reciba tu nombre y lo escriba por consola.
        public static void Ejercicio1()
        {
            String nombre;
            Console.WriteLine("\tEjercicio 1.");
            Console.WriteLine("Por favor, escribe tu nombre.");
            nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}.");
        }
        // Resolución Ejercicio 2
        // Escribe un programa que tome la hora y la escriba por pantalla.
        public static void Ejercicio2()
        {
            Console.WriteLine("\tEjercicio 2.");
            Console.WriteLine("Para conocer la hora actual presiona una tecla");
            Console.Read();
            Console.WriteLine(DateTime.UtcNow);
        }
    }
}
