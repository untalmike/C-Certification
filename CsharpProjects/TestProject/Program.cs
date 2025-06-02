﻿/**
    Demostration using Signed and unsigned types
*/

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte: {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte :{byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort :{ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint :{uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong :{ulong.MinValue} to {ulong.MaxValue}");

/**
    Examples with Floating point types
*/
// Console.WriteLine("Floating point types:");

// Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
// Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");

int[] data = new int[3];

string shortedString = "Hello World!";
Console.WriteLine(shortedString);

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");