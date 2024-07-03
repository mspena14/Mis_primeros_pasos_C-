// // 1. Escribe un programa que pida al usuario un número y muestre si es par o impar usando una condición if.
// Console.Write("Ingrese un numero entero: ");
// byte numero = Convert.ToByte(Console.ReadLine());

// if (!(numero % 2 == 0))
// {
//     Console.WriteLine("El número ingresado es impar");
// }
// else
// {
//     Console.WriteLine("El número ingresado es par");
// }
// /*  2. Escribe un programa que pida al usuario que ingrese su nombre. Luego, verifica si el
// nombre ingresado no es nulo ni está vacío. Si el nombre es válido, muestra un mensaje de
// bienvenida; de lo contrario, muestra un mensaje de error. */
// Console.Write("Ingresa tu nombre: ");
// string nombre = Console.ReadLine();

// if (!string.IsNullOrWhiteSpace(nombre))
// {
//     Console.WriteLine($"Bienvenid@ {nombre}");
// }
// else
// {
//     Console.WriteLine("¡Error!: el dato ingresado no puede ser nulo ni estar vacío ni ser un espacio en blanco.");
// }

// // 3. Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad
// // usando if-else.
// Console.Write("Ingresa tu edad: ");
// byte edad = Convert.ToByte(Console.ReadLine());

// if (!(edad > 18))
// {
//     Console.WriteLine("No eres mayor de edad ");
// }
// else
// {
//     Console.WriteLine("Eres mayor de edad");
// }

// // 4. Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) y
// // muestre el nombre del día correspondiente usando switch.
// Console.Write("Ingrese el día de la semana en el que estás (ingrese un número entre 1 y 7): ");
// string dia = Console.ReadLine();

// if (!string.IsNullOrWhiteSpace(dia))
// {
//     switch (Convert.ToByte(dia))
//     {
//         case 1:
//             Console.WriteLine("Es domingo");
//             break;

//         case 2:
//             Console.WriteLine("Es lunes");
//             break;

//         case 3:
//             Console.WriteLine("Es martes");
//             break;

//         case 4:
//             Console.WriteLine("Es miercoles");
//             break;

//         case 5:
//             Console.WriteLine("Es jueves");
//             break;

//         case 6:
//             Console.WriteLine("Es viernes");
//             break;

//         case 7:
//             Console.WriteLine("Es sabado");
//             break;

//         default:
//             Console.WriteLine("Ingresaste un número fuera del rango");
//             break;
//     }

// }
// else
// {
//     Console.WriteLine("¡Error!: el dato ingresado no puede ser nulo ni estar vacío ni ser un espacio en blanco.");
// }

/* 5. Escribe un programa que pida al usuario su equipo de nacionalidad, si es colombiana debe
decirle que es nativo el país y si no lo es debe decir que es extranjeto (hacer ejercicio con
operador ternario) */
// Console.Write("Ingresa tu nacionalidad: ");
// string nacionalidad = Console.ReadLine().ToLower();

// Console.WriteLine(nacionalidad == "colombiana" ? "Eres nativo":"Eres extranjero");

// 6. Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando if-else.
// byte num1, num2, num3;
// Console.Write("Ingresa el primer número: ");
// num1 = Convert.ToByte(Console.ReadLine());
// Console.WriteLine(" ");
// Console.Write("Ingresa el segundo número: ");
// num2 = Convert.ToByte(Console.ReadLine());
// Console.WriteLine(" ");
// Console.Write("Ingresa el tercer número: ");
// num3 = Convert.ToByte(Console.ReadLine());
// Console.WriteLine(" ");

// if (num1 > num2 && num1 > num3)
// {
//     Console.WriteLine($"El primer número ({num1}) es el mayor.");
// } else if (num2 > num1 && num2 > num3) {
//     Console.WriteLine($"El segundo número ({num2}) es el mayor.");
// } else {
//     Console.WriteLine($"El tercer número ({num3}) es el mayor.");
// }

/* // 7. Escribe un programa que pida al usuario que ingrese una contraseña. Verifica si la
contraseña no es nula ni está vacía. Si la contraseña es válida, muestra un mensaje
indicando que la contraseña es aceptada; de lo contrario, muestra un mensaje indicando
que la contraseña no puede estar en blanco. */
// Console.Write("Ingresa una contraseña: ");
// string contraseña = Console.ReadLine();

// if (!string.IsNullOrWhiteSpace(contraseña))
// {
//     Console.WriteLine("Su contraseña es válida");
// }
// else
// {
//    Console.WriteLine("¡Error!: el dato ingresado no puede ser nulo ni estar vacío ni ser un espacio en blanco.");
// }

// 8. Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del mes correspondiente usando switch.
// Console.Write("Ingrese el mes del año en el que estás (ingrese un número entre 1 y 12): ");
// string mes = Console.ReadLine();

// if (!string.IsNullOrWhiteSpace(mes))
// {
//     switch (Convert.ToByte(mes))
//     {
//         case 1:
//             Console.WriteLine("Es enero");
//             break;

//         case 2:
//             Console.WriteLine("Es febrero");
//             break;

//         case 3:
//             Console.WriteLine("Es marzo");
//             break;

//         case 4:
//             Console.WriteLine("Es abril");
//             break;

//         case 5:
//             Console.WriteLine("Es mayo");
//             break;

//         case 6:
//             Console.WriteLine("Es junio");
//             break;

//         case 7:
//             Console.WriteLine("Es julio");
//             break;

//         case 8:
//             Console.WriteLine("Es agosto");
//             break;

//         case 9:
//             Console.WriteLine("Es septiembre");
//             break;

//         case 10:
//             Console.WriteLine("Es octubre");
//             break;

//         case 11:
//             Console.WriteLine("Es noviembre");
//             break;

//         case 12:
//             Console.WriteLine("Es diciembre");
//             break;

//         default:
//             Console.WriteLine("Ingresaste un número fuera del rango");
//             break;
//     }

// }
// else
// {
//     Console.WriteLine("¡Error!: el dato ingresado no puede ser nulo ni estar vacío ni ser un espacio en blanco.");
// }

// 9. Escribe un programa que pida al usuario una calificación numérica y muestre la letra correspondiente (A, B, C, D, F) usando if-else.
Console.Write("Ingrese su calificación númerica en el rando de 0 a 5: ");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if (!(nota < 0 || nota > 5)) {
    if (nota > 4) {
        Console.WriteLine("Tu calificación es A");
    } else if (nota > 3 && nota <= 4) {
        Console.WriteLine("Tu calificación es B");
    } else if (nota > 2 && nota <= 3) {
        Console.WriteLine("Tu calificación es C");
    } else if (nota > 1 && nota <= 2) {
        Console.WriteLine("Tu calificación es D");
    } else {
        Console.WriteLine("Tu calificación es F");
    }
} else {
    Console.WriteLine("Ingresaste una calificación fuera de rango");
}

// 10. Escribe un programa que pida al usuario un carácter y determine si es una vocal o una
// consonante usando switch.
// 11. Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes
// usando if-else.
// 12. Escribe un programa que solicite al usuario que ingrese su dirección. Verifica si la dirección
// no es nula, no está vacía y no consiste sólo en espacios en blanco. Si la dirección es válida,
// muestra un mensaje de confirmación; de lo contrario, muestra un mensaje de error.
// 13. Escribe un programa que pida al usuario un número y determine si es positivo, negativo o
// cero usando if-else.
// 14. Escribe un programa que pida al usuario una letra y determine si es una vocal usando
// if-else.
// 15. Escribe un programa que pida al usuario una temperatura en grados Celsius y determine si
// es caliente (mayor a 30), templada (entre 10 y 30) o fría (menor a 10) usando if-else.
// 16. Escribe un programa que pida al usuario un año y determine si es un año bisiesto usando
// if-else.
// 17. Escribe un programa que pida al usuario que ingrese un valor. Verifica si el valor ingresado
// no es nulo, no está vacío y no contiene solo espacios en blanco. Si la entrada es válida,
// muestra el valor; de lo contrario, pide al usuario que ingrese un valor válido.
// 18. Escribe un programa que pida al usuario un número del 1 al 7 y determine si es un día
// laborable o de fin de semana usando switch.