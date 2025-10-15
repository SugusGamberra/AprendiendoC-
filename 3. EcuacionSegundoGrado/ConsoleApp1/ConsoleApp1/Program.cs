// Vamos a calcular ecuaciones de segundo grado

using System;

namespace EcuacionesSegundoGradoSimple

    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a calcular ecuaciones de segundo grado");

            Console.WriteLine("Introduce el valor de a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el valor de b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce el valor de c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminante = b * b - 4 * a * c;
            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"Las soluciones son reales y diferentes: x1 = {x1}, x2 = {x2}");
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Las soluciones son reales e iguales: x = {x}");
            }
            else
            {
                Console.WriteLine("Las soluciones son complejas y no reales.");

                Console.WriteLine("\nPulsa una tecla para finalizar...");
                Console.ReadKey();
            }
        }
    }
}