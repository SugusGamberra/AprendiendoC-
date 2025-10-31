# 🔁 ESTRUCTURAS DE CONTROL DE FLUJOS EN C#

De momento estamos ejecutando código **línea por línea**. Si quisieramos saltar lineas, repetir bloques o ejecutar código con condicionales usamos las estructuras de control de flujo ;D

---

### ⚖️ Operadores de comparación

| Operador | Significado | Ejemplo | Resultado |
| :--- | :--- | :--- | :--- |
| `==` | Igual que | `a == b` | True si son iguales |
| `!=` | Distinto que | `a != b` | True si son distintos |
| `>` | Mayor que | `a > b` | True si a es mayor |
| `>=` | Mayor o igual | `a >= b` | True si se cumple cualquiera |
| `<` | Menor que | `a < b` | True si a es menor |
| `<=` | Menor o igual | `a <= b` | True si se cumple cualquiera |

### 💡 Operadores lógicos

| Operador | Significado | Ejemplo | Resultado |
| :--- | :--- | :--- | :--- |
| `&&`   | Y (AND) | `if (edad >= 18 && tieneEntrada == true)` | True si **ambos** son true |
| `‖` | O (OR) | `if (esSocio == true ‖ tieneInvitacion == true)` | True si **uno o más** son true |
| `!` | No (NOT) | `if (!estaLloviendo)` | Invierte el valor lógico |

> ⚙️ Uso ‖ en vez de poner 2 barras verticales en el teclado || porque de otra me lo formatea raro con las tabalas x.x

---

## 🧠 Condicionales

### 🔸 If/Else

Mientras lo que esté entre parentesis sea cierto, ejecuta el codigo entre llavecitas!

```C#
int edad = 20;

if (edad >= 18) {
    Console.WriteLine("Puedes pasar!!");
}
else {
    Console.WriteLine("No puedes pasar uwu");
}
```

### 🔸 Else if

Permite comprobar **varias condiciones** en cadena :3

```C#
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
```

### 🔸 Switch

En vez de andar poniendo 40mil `else if` pues tenemos el switch :3

```C#
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
```

---

## 🔁 Bucles

Permiten **repetir código** muchas veces sin tener que escribirlo de nuevo!

### 🔸 While

Mientras esta condicion se cumpla ejecuta el codigo. 

> ⚠️ Cuiiiidao con los bucles infinitos!!! Cuando hagamos bucles o le metemos una condicion que haga que pare o le metemos breaks o lo que sea, que si no te peta todo!

```C#
int contador = 0;

while (contador < 5) {
    Console.WriteLine("Número " + contador);
    contador++;
}

Console.WriteLine("Bucle finalizado gracias al contador++!!!! El contador vale " + contador);
```

### 🔸 Do...while

El do while primero ejecuta y luego pregunta ;P (muy masculino el 😏)

```C#
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
```

### 🔸 For

Para repetir algo un **número de veces**. Se usa cuando necesitas saber la posicion/indice de un elemento, necesitas recorrer tu coleccion al reves (`i--`), para saltarte elementos como ir de 2 en 2 ( `i +=2` ) o modificar un elemento dentro del array :3

```C#
for (int i = 0; i< 5; i++) {
    Console.WriteLine("El número es: " + i);
}
```

### 🔸 For each

Es un bucle especialista para recorrer una colección de elementos (arrays o listas) y darte cada uno, uno por uno :3 Lo usaremos si queremos leer caaaada elemento de nuestra coleccion, no te importa nada la posicion y quieres que tu codigo quede limpito y bonito. Este es **solo de lectura**, aviso! **No puedes modificar** cosas dentro de tu coleccion con el :c

```C#
string [] nombres = {"Maria", "Paca", "La Piraña"};

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
```

---

> 😎 Ya tienes lo esencial de control de flujos en C# ;3
> 🎮 Te recomiendo descargar el [código](./controlFlujos/controlFlujos/Program.cs) o usarlo porque ya empieza la diversion jiji 