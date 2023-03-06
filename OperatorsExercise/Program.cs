
using System.Security.Cryptography.X509Certificates;

int a = 6;
int b = 37;

Console.WriteLine($"Addition:{a + b}");
Console.WriteLine();

Console.WriteLine($"Subtraction:{a - b}");
Console.WriteLine();

Console.WriteLine($"Multiplication:{a * b}");
Console.WriteLine();

Console.WriteLine($"Division:{b / a}");
Console.WriteLine();

int quotient = (b / a);
int remainder = (b % a);

Console.WriteLine($"The quotient of b/a is {quotient}");
Console.WriteLine();
Console.WriteLine($"37/6 is {b/a} with a remainder of {remainder}");