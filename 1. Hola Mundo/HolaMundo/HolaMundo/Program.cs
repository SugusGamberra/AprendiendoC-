// "Hello World"
// C# se parece a JAVA
// En C# mostramos por consola con System.Console.WriteLine

// System.Console.WriteLine("Hola Mundo");

// Si queremos usar WriteLine sin el prefijo System lo hacemos de la siguiente forma:

using System;

namespace HolaMundo
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Este es nuestro primer programa en C#");
        }
    }
}

// namespace y class agrupan el código
// static indica que el método Main pertenece a la clase y no a una instancia de la clase
// es el punto de entrada del programa

// para probar un método u otro recuerda descomentar el que vayas a usar y comentar el que no uses con // al inicio de la línea
// para ejecutar el programa en la terminal escribe dotnet run