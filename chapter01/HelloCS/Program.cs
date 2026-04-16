// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#");

// Revealing the namespace of the Program class
string name = typeof(Program).Namespace ?? "<null>";

Console.WriteLine($"Namespace: {name}");

throw new Exception();