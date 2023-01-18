// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Программа определения большего из двух чисел");
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()); // читаем, что ввел пользователь в качестве первого числа
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()); // читаем, что ввел пользователь в качестве первого числа

if (number1 > number2) Console.WriteLine ("Результат: Первое число больше второго");

if (number1 < number2) Console.WriteLine ("Результат: Второе число больше первого");

if (number1 == number2) Console.WriteLine ("Результат: Два числа равны");