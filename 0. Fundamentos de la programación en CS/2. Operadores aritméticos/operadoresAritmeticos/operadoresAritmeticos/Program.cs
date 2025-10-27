// Operadores aritméticos en C#

using System;
class Program
{
    static void Main()
    {
        // Operadores aritméticos básicos
        int resultadoDivision = 7 / 2;
        double resultadoDivisionExacta = 7.0 / 2.0;
        Console.WriteLine(resultadoDivision + " | " + resultadoDivisionExacta);

        // Concatenacion

        Console.WriteLine("Resultado: " + 10 + 5);

        // Suma

        Console.WriteLine("Resultado: " + (10 + 5));

        int suma = 10 + 4;
        Console.WriteLine(suma);

        // Asignación arigmética

        int numero = 100;
        Console.WriteLine(numero);

        numero += 10;
        Console.WriteLine(numero);

        numero -= 20;
        Console.WriteLine(numero);

        numero *= 2;
        Console.WriteLine(numero);

        numero /= 5;
        Console.WriteLine(numero);

        numero %= 7;
        Console.WriteLine(numero);

        // Incremento y Decremento

        int vidas = 3;
        Console.WriteLine(vidas);

        vidas++;
        Console.WriteLine(vidas);

        vidas--;
        Console.WriteLine(vidas);

        // Prioridad de operadores

        int resultado = 10 + 5 * 2;
        Console.WriteLine(resultado);

        resultado = (10 + 5) * 2;
        Console.WriteLine(resultado);
    }
}