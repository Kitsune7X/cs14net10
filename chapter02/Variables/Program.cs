object height = 1.88; // Storing a double in an object
object name = "Fox"; // Storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length; // Should give compiler error!
int length2 = ((string)name).Length; // Cast name to a string.
Console.WriteLine($"{name} has {length2} characters.");

// Testing GitHub SSH