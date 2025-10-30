# ESTRUCTURAS DE CONTROL DE FLUJOS

De momento estamos ejecutando código línea por línea. Estas estructuras nos sirven para saltar lineas, repetir bloques o ejecutar código con condicionales!

### Operadores de comparación

- Igual que: ==
- Distinto que: !=
- Mayor que: >
- Mayor o igual que: >=
- Menor que: <
- Menor o igual que: <=

### Operadores lógicos

- Y: &&
    - if (edad >= 18 && tieneEntrada == true) // es verdadero (true) si ambos son true
- O: ||
    - if (esSocio == true || tieneInvitacion == true) // Al menos una debe ser true
- No: !
    - if (!estaLloviendo) // Si estaLloviendo es true, !estaLloviendo seria false

## Condicionales

### If/Else

Mientras lo que esté entre parentesis sea cierto, ejecuta el codigo entre llavecitas!

int edad = 20;

if (edad >= 18) {
    Console.WriteLine("Puedes pasar!!");
}
else {
    Console.WriteLine("No puedes pasar uwu");
}

### Else if

int edad = 5;

if (edad >= 18) {
    Console.WriteLine("Puedes pasar!!");
}
else if (edad ==5) {
    Console.WriteLine("No puedes pasar pero te regalo una priuleta :3")
}
else {
    Console.WriteLine("No puedes pasar uwu");
}

### Switch

En vez de andar poniendo 40mil else if pues tenemos el switch :3

Console.WriteLine("Este es el menú de tu juego, elige 1, 2 o 3 para ver las opciones!");

int opcionElegida = 2;

switch (opcionElegida) {
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

## Bucles

### While

Mientras esta condicion se cumpla ejecuta el codigo. Cuiiiidao con los bucles infinitos!!! Cuando hagamos bucles o le metemos una condicion que haga que pare o le metemos breaks o lo que sea, que si no te peta todo!

int contador = 0;

while (contador < 5) {
    Console.WriteLine("Número " + contador);
    contador++;
}

Console.WriteLine("Bucle finalizado gracias al contador++!!!! El contador vale " + contador);

### Do...while

El do while primero ejecuta y luego pregunta ;P (muy masculino el ñ.ñ)

string password = "teweleelqloakk";
string intento;

do {
    Console.WriteLine("Introduzca su contraseña: ");
    intento = Console.ReadLine();

    if (intento != password) {
        Console.WriteLine("Incorrecto! Intentelo de nuevo!!");
    }
}

while (intento != password);

Console.WriteLine("Por finnn!! Pasa anda!!");

### For

Para repetir algo un número de veces.

for (int i = 0; i< 5; i++) {
    Console.WriteLine("El número es: " + i);
}

Te recomiendo descargar el [código](./controlFlujos/controlFlujos/Program.cs) o usarlo porque ya empieza la diversion jiji 