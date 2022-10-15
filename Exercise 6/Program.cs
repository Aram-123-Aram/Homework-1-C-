/* Написать программу,которая на вход принимает число и выдает,
является ли число четным(делится ли оно на два без остатка). */

Console.Write("Enter the number a= ");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0) {Console.Write("Yes,the a is an even number !"); }
else {Console.Write("No,the a isn't an even number, it is an odd number !"); }
