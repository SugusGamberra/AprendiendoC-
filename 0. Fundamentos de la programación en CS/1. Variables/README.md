# VARIABLES

## Introducción

Las variables se usan para guardar datos que el programa necesita durante la ejecución (números, textos, fechas...). Son como cajitas donde guardas información temporal.

## Estructura de la variable

- Nombre: Cómo la identificas (string usuario, int puntuacion...)
- Tipo de datos que almacena: 
    - String: Texto "Hola"
    - Int: Numeros enteros 10
    - Double: Números decimales 3.21
    - Float: Igual que double pero menos preciso y poco común para empezar.
    - Boolean: Valores lógicos (true or false)
    - Char: Caracter de una letra o símbolo 'A'
    - Hay muchos más, iremos viendo a medida que creemos cositas!
- Valor: Lo que guarda la variable

No podemos llamar a la variable de cualquier forma, tienes que tenerlas bien organizadas! Existen unas normas para que su uso no sea un dolor de cabeza ni de errores!

- No pueden empezar por un numero.
- No pueden tener espacios.
- Nada de caracteres raros, salvo _.
- C# distingue mayusculas y minusculas, por lo que edad y Edad serian dos variables diferentes.
- Buena práctica: Empieza siempre en minúsculas, si son varias palabras para separarlas usa mayúsculas: edadUsuario.

## Cómo se declara?

Para declarar (crear) una variable usamos la estructura anterior, es como una fórmula: Tipo de dato + Nombre = Valor.

Casi todas las líneas en C# usan ;, acostumbrate de antemona xd Con eso le estás diciendo "aquí acaba la instrucción colega".

Para asignarle un valor usamos =. Cuidao, = no es como el de las mates, aquí le decimos "guarda esto aquí" con ese simbolito.

Ejemplo:

int edad = 32;

double precio = 19.23;

string username = "SugusGamberra";

bool VIP = true;

## Cómo se usa?

Pues una vez la tienes declarada tan solo usa su nombre para ver lo que contiene o trabajar con ella, por ejemplo:

string username = "SugusGamberra";
int edad = 32;

Console.WriteLine(username);
Console.WriteLine(edad);

## Concatenar

Si queremos unir texto con variables, o juntar varias variables, concatenamos con el simbolo +. Con el ejemplo anterior haríamos:

Console.WriteLine("Holiii! Soy " + username + " y tengo " + edad + " años!");

Y por hoy ya seria str estadoCurso = finiquitado;!!

Así que nada, un abrazote ;D