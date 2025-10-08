using System;

// Calculamos el área de un triángulo usando doubles  
// BTW base en C# es una palabra reservada, por eso usamos baseTriangulo

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo = 10.5;
            double altura = 5.5;
            double area = (baseTriangulo * altura) / 2;

            Console.WriteLine("El área del triángulo es: " + area);
        }

    }

}