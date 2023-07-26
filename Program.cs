/* string texto1, texto2, texto3;
texto1 = "Pushita rosadita, nyah~~~~~~~";
texto2 = "Quiero que me la partan, que la repartan. Donde me la guardan en la garganta";
texto3 = "Tuka, Tuka, Tuka. Que me traten como puta, arriba abajo ponme en cuatro enxhulame la pusha.";
Console.WriteLine(texto1 + texto2 + texto3);
*/

/*
Console.WriteLine("Ingresa un número");
int primerDato;
primerDato = int.Parse(Console.ReadLine());

if(primerDato >= 8)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
*/

/*
Console.WriteLine("Digitaliza un número");
int Data;
Data = int.Parse(Console.ReadLine());

switch(Data)
{
    case 1:
        Console.WriteLine("Case #1");
        break;
    case 2:
        Console.WriteLine("Case #2");
        break;

    default:
        Console.WriteLine("Default");
        break;
}
*/

/*
// Pedir al usuario que opción quiere realizar: suma, resta, multiplicación, división y modúlo.

//Definición de variables
int data, num1, num2;

//Asignación de valores
num1 = 0;
num2 = 0;  

//Petición al usuario
Console.WriteLine("Calculadora");
Console.WriteLine("1. Suma\n2. Resta\n3. Multiplicación\n4. División\n5. Módulo");

//Lectura de dato
data = int.Parse(Console.ReadLine());

//Condición en la validación de dato.
if (data >= 1 && data <= 5)
{
    //Petición de dos valores númericos.
    Console.WriteLine("Ingresa un número");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa otro número");
    num2 = int.Parse(Console.ReadLine());
}

//Según el dato ingresado por el usuario hacer...
switch (data)
{
    case 1:
        Console.WriteLine("Suma: " + (num1+ num2));
        break;
    case 2:
        Console.WriteLine("Resta: " + (num1 - num2));
        break;
    case 3:
        Console.WriteLine("Multiplicación: " + (num1 * num2));
        break;
    case 4:
        Console.WriteLine("División: " + (num1 / num2));
        break;
    case 5:
        Console.WriteLine("Módulo: " +(num1 % num2) );
        break;
    default:
        Console.WriteLine("###########################\n#Está opción no es válida.#\n###########################");
        break;

}
*/

/*
//Realizar un programa que haga la verificación de edades de una discoteca; si es menor a 18 no puede ingresar; si es mayor o igual a 18 y menor de 30 sólo paga la tarifa normal; si es mayor a 30 y menor que 45 paga 20k adicional; si es mayor de 45 o igual paga 35k adicional

int edad;

Console.WriteLine("Ingresa la edad de la persona");
edad = int.Parse(Console.ReadLine());

if (edad > 0 && edad < 18)
{
    Console.WriteLine("No puedes ingresar -> tarifa anormal, pa' la casa mijito");
}
else if (edad >= 18 && edad < 30)
{
    Console.WriteLine("Tarifa: 80k -> tarifa normal");
}
else if (edad >= 30 && edad < 45)
{
    Console.WriteLine("Tarifa: 100k -> 80k tarifa normal + 20k sobrecarga por viejo");
}
else if (edad >= 45 && edad <= 65)
{
    Console.WriteLine("Tarifa: 115k -> 80k tarifa normal + 35k sobrecarga por anciano");
}
else
{
    Console.WriteLine("################\n#Edad no válida#\n################");
}
*/

int password = 0, i = 0;

while (password != 12345)
{
    i += 1;
    if(i == 4)
        return;
    password = int.Parse(Console.ReadLine());
}