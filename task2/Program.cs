// Программа,которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Программа определения максимального из трех чисел");
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()); // читаем, что ввел пользователь в качестве первого числа
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()); // читаем, что ввел пользователь в качестве второго числа
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine()); // читаем, что ввел пользователь в качестве третьего числа

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("Максимальное из трех чисел = ");
Console.WriteLine(max);