// Control de flujos!!

using System;
class Program
{
    static void Main(string[] args)
    {
        // If-else

        int edad = 20;

        if (edad >= 18)
        {
            Console.WriteLine("Puedes pasar!!");
        }
        else
        {
            Console.WriteLine("No puedes pasar uwu");
        }

        // Else-if

        edad = 5;

        if (edad >= 18)
        {
            Console.WriteLine("Puedes pasar!!");
        }
        else if (edad == 5)
        {
            Console.WriteLine("No puedes pasar pero te regalo una priuleta :3");
        }
        else
        {
            Console.WriteLine("No puedes pasar uwu");
        }

        // Estructura switch

        Console.WriteLine("Este es el menú de tu juego, elige 1, 2 o 3 para ver las opciones!");

        int opcionElegida = 2;

        switch (opcionElegida)
        {
            case 1:
                Console.WriteLine("Has elegido: Nueva Partida");
                break;

            case 2:
                Console.WriteLine("Has elegido: Cargar Partida");
                break;

            case 3:
                Console.WriteLine("Has elegido: Opciones");
                break;

            default:
                Console.WriteLine("¡Esa opción no existe, chatito/a!");
                break;
        }

        // Bucles

        // While

        int contador = 0;

        while (contador < 5)
        {
            Console.WriteLine("Número " + contador);
            contador++;
        }

        Console.WriteLine("Bucle finalizado gracias al contador++!!!! El contador vale " + contador);

        // For

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("El número es: " + i);
        }

        // Bucle do-while

        string password = "teweleelqloakk";
        string intento;

        do
        {
            Console.WriteLine("Introduzca su contraseña: ");
            intento = Console.ReadLine();

            if (intento != password)
            {
                Console.WriteLine("Incorrecto! Intentelo de nuevo!!");
            }
        }

        while (intento != password);

        Console.WriteLine("Por finnn!! Pasa anda!!");

        // For each

        string[] frutas = { "Manzana", "Banana", "Cereza" };

        foreach (string fruta in frutas)
        {
            Console.WriteLine("Fruta: " + fruta);
        }

    }
}
