// HOMEWORK 1

//Task 6
Console.WriteLine("What is the circle radius?");

var radius = double.Parse(Console.ReadLine());
var area = Math.PI * Math.Pow(radius, 2);
var circumference = 2 * Math.PI * radius;

Console.WriteLine($"The area of {radius} radius is {area} and circumference is {circumference}");



//Task 7
/*Console.WriteLine("What is the triangle height?");
var height = double.Parse(Console.ReadLine());

Console.WriteLine("What is the triangle base length?");
var baseLength = double.Parse(Console.ReadLine());

var area = 0.5 * baseLength * height;

Console.WriteLine($"The area of triangle is {area}");*/



//Improved Task 8
/*var numbers = new List<double>();
double perimeter = 0;

for (var i = 0; i < 3; i++)
{
    Console.WriteLine($"Enter {i + 1} side of the triangle");
    double side = double.Parse(Console.ReadLine());
    perimeter += side;
    numbers.Add(side);
}

var p = perimeter / 2;
var area = Math.Sqrt(p * (p - numbers[0]) * (p - numbers[1]) * (p - numbers[2]));

if (area > 0 )
{
    Console.WriteLine($"The area is {area} and perimeter is {perimeter}");
} else
{
    Console.WriteLine("You have entered wrong sides of triangle, try again");
}*/




//Improved Task 9
/*Console.Write("Enter temperature in Celsius: ");
var celsius = double.Parse(Console.ReadLine());

var fahrenheit = (celsius * 9 / 5) + 32;
var kelvin = celsius + 273.15;


Console.WriteLine($"The temperature in Celsius is {celsius}°C");
Console.WriteLine($"The temperature in Fahrenheit is {fahrenheit}°F");
Console.WriteLine($"The temperature in Kelvin is {kelvin}K");*/



// Improved task 10a
/*int sum = 0;
double average = 0;
for (var i = 0; i < 4; i++)
{
    Console.WriteLine($"Enter number {i + 1}");
    sum += int.Parse(Console.ReadLine());
}

average = 1.0 * sum / 4;
Console.WriteLine($"The sum is {sum} and average is {average}");*/



// Improved task 11a
/*Console.WriteLine("Enter number of numbers");
int numberOfNumbers = int.Parse(Console.ReadLine());

int[] numbers = new int[numberOfNumbers];

for (var i = 0; i < numberOfNumbers; i++)
{
    Console.WriteLine($"Enter number {i + 1}");
    numbers[i] = int.Parse(Console.ReadLine());
}

var sum = 0;

for (int i = 0; i < numberOfNumbers; i++)
{
    sum += numbers[i];
}

var average = 1.0 * sum / numberOfNumbers;
Console.WriteLine($"The sum is {sum} and average is {average}");
*/

// Improved task 11b
/*var numbers = new List<int>();

Console.WriteLine("Enter number of numbers");
int numberOfNumbers = int.Parse(Console.ReadLine());

for (var i = 0; i < numberOfNumbers; i++)
{
    Console.WriteLine($"Enter number {i + 1}");
    numbers.Add(int.Parse(Console.ReadLine()));
}

var sum = 0;

foreach (var number in numbers)
    sum += number;

var average = 1.0 * sum / numbers.Count;
Console.WriteLine($"The sum is {sum} and average is {average}");*/







// CLASS WORK
//Task 10c
/*var numbers = new List<int>();

for (var i = 0; i < 4; i++)
{
    Console.WriteLine($"Enter number {i + 1}");

    numbers.Add(int.Parse(Console.ReadLine()));
}

var sum = 0;

foreach(var number in numbers)
    sum += number;

var average = 1.0 * sum / numbers.Count;
Console.WriteLine($"The sum is {sum} and average is {average}");*/


//Task 10b
//var array = new int[4];

//for (var i = 0; i < array.Length; i++)
//{
//    Console.WriteLine($"Enter number {i + 1}");

//    array[i] = int.Parse(Console.ReadLine());
//}

//var sum = 0;

//for (var i = 0; i < array.Length; i++)
//    sum += array[i];

//var average = 1.0 * sum / array.Length;
//Console.WriteLine($"The sum is {sum} and average is {average}");

//Task 8
//Console.WriteLine("What is the first side?");
//var a = double.Parse(Console.ReadLine());

//Console.WriteLine("What is the second side?");
//var b = double.Parse(Console.ReadLine());

//Console.WriteLine("What is the third side?");
//var c = double.Parse(Console.ReadLine());

//var perimeter = a + b + c;

//var p = perimeter / 2;

//var area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

//Console.WriteLine($"The area is {area} and perimeter is {perimeter}");

//Task 5
/*Console.WriteLine("What is the radius?");

var radius = double.Parse(Console.ReadLine());

var area = Math.PI * radius * radius;

Console.WriteLine($"The area is {area}");
*/
//Task 4
//Console.WriteLine("What is your name?");
//string name = Console.ReadLine();
//Console.WriteLine($"Hello {name}");

//Task 3d
//string name = "Marcin";
//Console.WriteLine($"Hello {name}");

//Task 3c
//string name = "Marcin";
//Console.WriteLine(string.Format("Hello {0}", name));

//Task 3b
//string name = "Marcin";
//Console.WriteLine("Hello " + name);

//Task 3a
//string name = "Marcin";

//Console.Write("Hello ");
//Console.WriteLine(name);

//Task 2
//string name = "Marcin";
//Console.WriteLine(name);

//Task 1
//Console.WriteLine("Hello");
