
// An unsigned integer is a positive whole number or 0.
uint naturalNumber = 23;
Console.WriteLine(naturalNumber);

// An integer is a negative or positive whole number or 0.
const int integerNumber = -23;
Console.WriteLine(integerNumber);

// A float is a single precision floating-point number,
// The F or f suffix makes the value a float literal.
// The suffix is required to compile
const float realNumber = 2.3f;
Console.WriteLine(realNumber);

// A double is a double-precision floating-point number.
// double is the default for a number value with a decimal point.
const double anotherRealNumber = 2.3;
Console.WriteLine(anotherRealNumber);

const int decimalNotation = 2_000_000;
const int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
const int hexadecimalNotation = 0x_001E_8480;
// Check the three variables have the same value.
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

// Output the variable values in decimal.
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");

// Output the variable values in hexadecimal
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}");

// Show the size of three number data types
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue} to {decimal.MaxValue}");

Console.WriteLine("Using doubles:");
const double a = 0.1;
const double b = 0.2;
Console.WriteLine(a + b == 0.3 ? $"{a} + {b} equals {0.3}" : $"{a} + {b} does NOT equal {0.3}");


// Testing Decimal accuracy
Console.WriteLine("Using decimal:");
const decimal c = 0.1M;
const decimal d = 0.2M;

Console.WriteLine(c + d == 0.3M ? $"{c} + {d} equals {0.3M}" : $"{c} + {d} does NOT equal {0.3M}");

// Special number values
#region Special float and double values
Console.WriteLine($"double.Epsilon:{double.Epsilon}");
Console.WriteLine($"double.Epsilon to 324 decimal places:{double.Epsilon:N324}");
Console.WriteLine($"double.Epsilon to 330 decimal places:{double.Epsilon:N330}");

const int col1 = 37; // First column width.
const int col2 = 6; // Second column width.
string line = new string('-', col1 + col2 + 3);
Console.WriteLine(line);
Console.WriteLine($"{"Expression",-col1} | {"Value",col2}");
Console.WriteLine(line);
Console.WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}");
Console.WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity,col2}");
Console.WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity,col2}");
Console.WriteLine(line);
Console.WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0,col2}");
Console.WriteLine($"{"3.0 / 0.0",-col1} | {3.0 / 0.0,col2}");
Console.WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2}");
Console.WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {3.0 / 0.0 == double.PositiveInfinity,col2}");
Console.WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} | {-3.0 / 0.0 == double.NegativeInfinity,col2}");
Console.WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0,col2}");
Console.WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0,col2}");
Console.WriteLine(line);
#endregion

// Unsafe code block
#region Unsafe code block
unsafe
{
  Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}.");
  Console.WriteLine($"Int 128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}
#endregion

