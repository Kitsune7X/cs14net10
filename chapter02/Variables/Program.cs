using System.Drawing;
using System.Dynamic; // For ExpandoObject.
using System.Xml;

object height = 1.88; // Storing a double in an object
object name = "Fox"; // Storing a string in an object
Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length; // Should give compiler error!
var length2 = ((string)name).Length; // Cast name to a string.
Console.WriteLine($"{name} has {length2} characters.");

// Dynamic type
dynamic something;
// Storing an array of int values in a dynamic object.
// An array of any type has a Length property.
something = new[] { 3, 5, 7 };
// Storing an int in a dynamic object.
// int does not have a Length property.
something = 12;
// Storing a string in a dynamic object.
// string has a Length property.
something = "Foxy";
// This compiles but might throw an exception at run-time.
Console.WriteLine($"The length of something is {something.Length}");
// Output the type of something variable.
Console.WriteLine($"something is a {something.GetType()}");

#region ExpandoObject

dynamic person = new ExpandoObject();
// Add properties.
person.FirstName = "John";
person.LastName = "Doe";
person.Age = 30;
Console.WriteLine($"{person.FirstName} {person.LastName} is  {person.Age} years old");
// Cast the ExpandoObject into a dictionary.
var dictionary = (IDictionary<string, object>)person;
// Each item in the dictionary is a key-value pair.
foreach (var item in dictionary) Console.WriteLine($"{item.Key} = {item.Value}");

#endregion

// Specifying the type of a local variable
var population = 67_000_000; // UK population.
var weight = 1.88; // in kg.
var price = 4.99M; // in pounds sterling.
var fruit = "Apples";
var letter = 'Z';
var happy = true;


// Compare good and bad use cases of var
// Good use of var, avoid repeated type as shown
// in the more verbose 2nd statement.
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// Bad use of var because we cannot tell the type,
// we should use a specific type declaration as shown in
// the 2nd statement.
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

/* Value types have memory allocated on the stack automatically */
short age; // Allocates 2 bytes of memory on the stack to store a System.Int16 value.
long population; // Allocates 8 bytes of memory on the stack to store a System.Int64 value.
DateTime birthdate; // Allocates 8 bytes of memory on the stack to store a System.DateTime value.
Point location; // Allocates 8 types of memory on the stack to store a System.Drawing.Point value.

/* Reference types will only have memory allocated on the heap when new is used (but they automatically have 
some memory allocated on the stack to store information about themselves including the memory address of where they are
on the heap). */

// Person bob; // Allocate memory in the stack that can point to a Person object in the heap. Initially, bob will have the value null.