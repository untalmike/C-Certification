/* int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result); */

// Conversión de ampliación
/* int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}"); */

// Conversión con restricción y coersión (int)variable
/* decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}"); */

/* decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}"); */

// Uso de ToString
/* int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message); */

// Uso de parse
/* string first = "5";
string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
int.TryParse(first, out int num1);
int.TryParse(second, out int num2);
int sum = num1+num2;
Console.WriteLine(sum); */

// Uso de clase convert
/* string first = "5";
string second = "7";
int result = Convert.ToInt32(first) * Convert.ToInt32(second);
Console.WriteLine(result); */

// Conversión de restricción
int value = (int)1.5m;
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2);