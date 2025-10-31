# ➕ OPERADORES ARITMETICOS

Estos son los simbolitos que le dicen a C# que operacion aritmetica debe realizar con los valores (ya sean literales o almacenados en variables).

---

## 🔢 Operadores básicos

| Operador | Operación | Ejemplo | Resultado |
| :--- | :--- | :--- | :--- |
| `+` | Suma | `5 + 3` | 8 |
| `-` | Resta | `9 - 4` | 5 |
| `*` | Multiplicación | `2 * 6` | 12 |
| `/` | División | `8 / 2` | 4 |
| `%` | Módulo o resto | `7 % 2` | 1 |

### ⚙️ Importancia del tipo de variable

Aquí viene la importancia de declarar las variables como toca:

```C#
int resultado = 7 / 2;
```

Su resultado es **sin** decimales, si queremos decimales la declaramos como un `doouble`!!!

```C#
double resultadoDecimales = 7.0 / 2;
```
> 💡 Si uno de los dos valores es decimal (7.0 o 2.0), el resultado también lo será.

---

## 🧩 Que pasa con la concatenación y el simbolo `+`?

Para evitar que nos concatene todo como ocurriría en el siguiente ejemplo:

```C#
Console.WriteLine("Resultado: " + 10 + 5);
// La consola mostraria "Resultado: 105"
```

Hacemos:

```C#
Console.WriteLine("Resultado: " (10+5));
// La consola mostraria "Resultado: 15"
```

También podemos operar declarando variables:

```C#
int suma = 10 + 5;
Console.WriteLine(suma);
```

---

## 🧮 Asignación aritmética (abreviaturas)

| Operador | Equivale a | Ejemplo |
| :--- | :--- | :--- |
| `+=` | `a = a + b` | `a += 5;` |
| `-=` | `a = a - b` | `a -= 2;` |
| `*=` | `a = a * b` | `a *= 3;` |
| `/=` | `a = a / b` | `a /= 2;` |
| `%=` | `a = a % b` | `a %= 4;` |

## ⚡ Incremento y decremento

- `++` : Incremento
- `--` : Decremento

```C#
int vidas = 3;
vidas--
vidas++
```

---

## 🧠 Prioridad de operadores

El orden importa más que el tamaño 👀

Per sé C# hace primero multiplicaciones, divisiones y el resto, luego hace sumas y restas. Si quieres priorizar un orden concreto debes usar paréntesis, lo que esté dentro se calculará primero!

- **Normal**: `10 + 5 * 2 = 20` (Primero hace 5*2 y despues suma el resultado con 10)
- **Con paréntesis**: `(10 + 5) * 2 = 30` (Primero hace 10+5 y luego multiplica el resultado por 2)

---

> 🎉 Ya estaría todo! En un futuro haré una carpeta con ejercicios para que practiques lo que se va viendo ;3
> 😎 Mientras échale un vistazo al [código](./operadoresAritmeticos/operadoresAritmeticos/Program.cs) para que puedas ir viendo lo que explico y lo puedas probar por tu cuenta!