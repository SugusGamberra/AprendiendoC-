// Para que puedas ver con tus lindos ojitos la declaración y uso de variables en C#...
// Aquí tienes un ejemplo sencillo de como declararlas, usarlas y concatenarlas ;P

using System;
class Program
{
    static void Main(string[] args)
    {
        // Declaración de variables
        int edad = 32;
        double precio = 137.12;
        string username = "SuwusLaPerra";
        char caracter = '$';

        // Uso de variables
        Console.WriteLine(edad);
        Console.WriteLine(caracter);

        // Concatenación de variables
        Console.WriteLine("Holii! Soy " + username + " y mi edad es de " + edad + "años! Me he comprado un teclado wapisimo por " + precio + caracter);
    }
}