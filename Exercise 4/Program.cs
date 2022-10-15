// Написать программу,которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Enter the first number: a= ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second number: b= ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Enter the third number: c= ");
int c = int.Parse(Console.ReadLine()!);
int max = a;

if (b > max) {max = b; if (c > max) {max = c; Console.Write("The maximum number is: max=c= " + max ); }
                   else {max = b; Console.Write("The maximum number is: max=b= " + max); } }
else if (c > max) {max = c; Console.Write("The maximum number is: max=c= " + max); }
     else {Console.Write("The maximum number is: max=a= " + max); }
