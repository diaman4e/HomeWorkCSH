// See https://aka.ms/new-console-template for more information
//using System.Formats.Asn1;

//Console.WriteLine("Enter the value if X: ");
//int x = int.Parse(Console.ReadLine());
////  3x^2 + 4x + 4
//double expr = 3 * Math.Pow(x, 2) + 4 * x + 4;
//Console.WriteLine(expr);


// Mathematical methods/functions in C#


//int num1 = 2147483647;
//Console.WriteLine(Math.BigMul(num1,num1));  // this method does some biiiigg multiplications


//int num2 = -7;
//Console.WriteLine(Math.Abs(num2)); // it gives the absolute value of num2

//double num3 = 52.3;
//Console.WriteLine(Math.Ceiling(num3)); // rounds up

//double num4 = 56.8;
//Console.WriteLine(Math.Floor(num4)); // ronds down


//const double PI = Math.PI;
//Console.WriteLine($"The exact number of PI is {PI}");

//const double E = Math.E;
//Console.WriteLine($"The exact number of E is {E}");

//double angle = Math.PI;
//Console.WriteLine(Math.Cos(angle));  // cos in 180 is equal to -1
//Console.WriteLine(Math.Sin(angle/2)); // sin in pi/2 is equal to 1
//Console.WriteLine(Math.Tan(0)); // 0

//// also hsin, hcos, htan - hyperbolic & asin, acos, atan - (arc)

//int num5 = 5;
//int num6 = 9;
//Console.WriteLine(Math.Max(num5, num6)); // returnes the maximum
//Console.WriteLine(Math.Min(num5, num6)); // returnes the minimum

//int bajanarar = 6;
//int bajaneli = 45;
//int mnacord = 0;
//int quotient = Math.DivRem(bajaneli, bajanarar, out mnacord);
//Console.WriteLine(quotient); // maximum how many 6s does the 45 contain? - 7

//int a = 4;
//int b = 2;
//Console.WriteLine(Math.Pow(a, b)); // 2 power of 4 --- 16

//int c = 81;
//Console.WriteLine(Math.Sqrt(c)); // square root - 9


//double d = 654.2554;
//Console.WriteLine(Math.Truncate(d)); // it always r eturns the integer part of the number, subtracts the "kotorakayin mas"


//double g = 654.256;
//Console.WriteLine(Math.Round(g)); // rounds to the nearest

//int t = 4;
//int y = t++;
//Console.WriteLine(y); // prints before the incrementation - 4

//int o = 4;
//int p = ++o;
//Console.WriteLine(p); // prints after the incrementation - 5



////////////

int myInt = 0;

Console.WriteLine(myInt); // is available everywhere in this file, this is a global variable
// but

{
    int myInt1 = 7;  // this is a local variable and is available only here between these {...}
}


int a = 5;
a += 9;
Console.WriteLine(a);  // output: 14

a -= 4;
Console.WriteLine(a);  // output: 10

a *= 2;
Console.WriteLine(a);  // output: 20

a /= 4;
Console.WriteLine(a);  // output: 5

a %= 3;
Console.WriteLine(a);  // output: 2



