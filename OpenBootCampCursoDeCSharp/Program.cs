using System;
using System.Net;
using System.Runtime.Remoting;
using System.Security.Cryptography;

namespace OpenBootCampCursoDeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\tResolución de los ejercicios del curso de C# de OpenBootCamp");
            Ejercicio1();
            Ejercicio2();
            Ejercicio3();
            Ejercicio4();
            Ejercicio5();
            Ejercicio6();
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
            Console.WriteLine("La hora actual es: " + (DateTime.UtcNow));
        }
        // Resolución Ejercicio 3
        // Variables 
        // Escribe un programa que reciba datos de una persona y genera un mensaje,
        // usa una variable para cada dato y otra para el mensaje.
        // Ej: nombre, apellido, edad, sabe programar, etc.
        public static void Ejercicio3()
        {
            String nombre;
            String apellido;
            int edad;
            double saldoDisponible;

            Console.WriteLine("\tEjercicio 3.");
            Console.WriteLine("Introduce tu nombre.");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu apellido.");
            apellido = Console.ReadLine();
            Console.WriteLine($"Bienvenido {nombre} {apellido}.");
            Console.WriteLine("Introduce tu edad.");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tienes {edad} años.");
            Console.WriteLine("Introduce tu saldo disponible.");
            saldoDisponible = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Tu saldo disponible es: {saldoDisponible}");
        }
        // Ejercicio 4
        // Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
        // Coche: puertas, ruedas, marca, ITV vigente
        // Mesa: peso, largo, material, color
        // Nota: puedes escribir estos datos por consola si prefieres verlos.La idea del ejercicio es almacenar los datos en los tipos más adecuados.
        public static void Ejercicio4()
        {
            // Variables de coche

            int numeroPuertas;
            string marcaVehiculo;
            bool itvVigente;
            string marcaRuedas;
            int numeroRuedas;

            // Variables de Mesa

            double pesoMesa;
            double largoMesa;
            string materialMesa;
            string colorMesa;

            Console.WriteLine("\tEjercicio 4.");
            Console.WriteLine("Vamos a establecer las variables para un objeto tipo Coche.");
            Console.WriteLine("Introduce el numero de ruedas de tu vehiculo. \tVariable tipo Integer.");
            numeroRuedas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tu vehiculo tiene {numeroRuedas} ruedas.");
            Console.WriteLine("Introduce la marca de tu vehiculo. \tVariable tipo String.");
            marcaVehiculo = Console.ReadLine();
            Console.WriteLine($"Tu vehiculo es de la marca: {marcaVehiculo}");
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("Vamos a establecer las variables para un objeto tipo Mesa.");
            Console.WriteLine("Introduce el peso en KG. de la mesa. \tVariable tipo Double.");
            pesoMesa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El peso de la mesa es: {pesoMesa} KG.");
            Console.WriteLine("Introduce el largo de la mesa en CM. \tVariable tipo Double.");
            largoMesa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"El largo de la mesa es: {largoMesa} CM.");

        }
        // Ejercicio 5
        // Operadores Determina los operadores para verificar las siguientes condiciones:
        // Un número es mayor o igual a 18
        // Un char es ‘a’
        // Se cumplen dos conciones a la vez(ambas verdaderas)
        // Se cumple una de dos condiciones a la vez(una true y otra false)
        // Nota: puedes escribir estos datos por consola si prefieres verlos.La idea del ejercicio es almacenar los datos en los tipos más adecuados.
        public static void Ejercicio5()
        {
            Console.WriteLine("\tEjercicio 5.");
            int numero = 8;
            if ( numero > 18 ) 
            {
                Console.WriteLine($"El numero {numero} es menor que 18.");
            }
            char caracter = 'A';
            if ( caracter == 'A' )
            {
                Console.WriteLine($"La variable Char corresponde al caracter: {caracter}. ");
            }
            if ( numero < 18 &&  caracter == 'A')
            {
                Console.WriteLine("Las dos condiciones son True");
            }
            if ( numero > 18 && caracter == 'A')
            {
                Console.WriteLine("Una de la condiciones es True y la otra False");
            }
        }
        // Ejercicio 6
        // Crea una estructura de datos para un cliente con estos campos:
        // Nombre completo
        // Teléfono
        // Dirección
        // Email
        // Si es nuevo cliente
        // Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
        public static void Ejercicio6()
        {
            Console.WriteLine("\tEjercicio 6.");
            object[] cliente = new object[5];
            cliente[0] = "Noa Jiménez Matobella";
            cliente[1] = 34555789234;
            cliente[2] = "C/Programacion en C#, Nº 2";
            cliente[3] = "noa.jim348@programacion.es";
            cliente[4] = true;

            foreach ( object datos in cliente ) 
            {
                Console.WriteLine(datos);
            }
        }

    }
}
