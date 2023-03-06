
using System.Security.Cryptography.X509Certificates;
//Exercise 1

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
Console.WriteLine();

//Exercise 2
Console.WriteLine("What is the radius of your circle?");
var radius = 2;
var areaOfCircle = Math.PI * Math.Pow(radius, 2);


Console.WriteLine(radius);
Console.WriteLine($"The area of the circle with a radius of {radius} is {areaOfCircle}");

//Thought Experiment
var i = 3;
var j = 4;
var k = ++i * j++;

Console.WriteLine(k);

