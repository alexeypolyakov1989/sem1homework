﻿// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Программа определения четности числа");
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Число четное");
} 

else
{
    Console.WriteLine("Число нечетное");
}
