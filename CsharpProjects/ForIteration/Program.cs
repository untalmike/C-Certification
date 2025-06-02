
/**
    Instrucciones básicas de un ciclo For
*/

// for (int i = 0; i < 10; i++)
// {
//     Console.Write($"{i} - ");
// }

//     Console.WriteLine("");

// for (int j = 10; j >= 0; j--)
// {
//     Console.Write($"{j} - ");
// }

//     Console.WriteLine("");

// for (int k = 0; k < 10; k += 3)
// {
//     Console.Write($"{k} - ");
// }

//     Console.WriteLine("");

// for (int l = 0; l < 10; l++)
// {
//     Console.Write($"{l} - ");
//     if (l == 7) break;
// }

/**
    For para recorrer todos los elementos
*/
// Console.WriteLine("");

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int m = names.Length - 1; m >= 0; m--)
// {
//     Console.Write($"{names[m]} ");
// }

/**
    Ejemplo de limitantes del ForEach
*/

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

// for (int n = 0; n < names.Length; n++)
//     if (names[n] == "David") names[n] = "Sammy";

// foreach (var name in names) Console.Write($"{name} ");

/**
    Desafio FizzBuzz
*/

for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}