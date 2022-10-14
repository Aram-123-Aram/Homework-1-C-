/* Написать программу,который на вход принимает 2 числа и выдает,
какое число больше,какое меньше или они равны. */

Console.Write("Enter the first number a= ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second number b= ");
int b = int.Parse(Console.ReadLine()!);

if (a > b) {Console.WriteLine("The biggest number is: max=a= " + a); }
else if (a < b) {Console.WriteLine("The biggest number is: max=b= " + b); }
       else {Console.WriteLine("The numbers are equal: a = b !"); }
