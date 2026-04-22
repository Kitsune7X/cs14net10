using System.Globalization; // To use CultureInfo.
// Set current culture to US English
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
Console.WriteLine(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);
string formatted = string.Format(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);

// Three parameter values can use named arguments.
Console.WriteLine("{0} {1} lived in {2}.", arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

// Four or more parameter values cannot use named arguments.
Console.WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
"Roger", "Cevung", "Stockholm", "Education", "Optimizely");

Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

// Format String
string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
Console.WriteLine();
Console.WriteLine(format: "{0,-10} {1,6}", arg0: "Name", arg1: "Count");
Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: applesText, arg1: applesCount);
Console.WriteLine(format: "{0,-10} {1,6:N0}", arg0: bananasText, arg1: bananasCount);


double value = 123;
Console.WriteLine(value.ToString("00000"));
Console.WriteLine(String.Format("{0:00000}", value));