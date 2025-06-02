/**
    Uso de comparaciones de igualdad
*/
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

/**
    Uso de funciones para remover espacios en blanco y volver a minúsculas
*/
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

/**
    Uso de comparaciones en negación
*/
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

/**
    Uso de operadores de comparación
*/
// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

/**
    Métodos que retornan valor booleano
*/
// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

/**
    Ejemplos con negación lógica
*/
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

/**
    Operadores de desigualdad vs negación lógica
*/

int a = 7;
int b = 6;
Console.WriteLine(a != b);

string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2);