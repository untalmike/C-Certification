﻿bool flag = true;
int value = 0;

if(flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

/**
    Instrucción IF con uso de Bloque de código
*/
if (flag)
    Console.WriteLine(flag);

if (flag) Console.WriteLine(flag);

/**
    Instrucciones de código compuestas
*/
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

// Código formateado para mejor legibilidad
if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

/**
    Desafío de código problemático
*/
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;

}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
