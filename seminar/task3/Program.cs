﻿// Напишите программу, которая принимает на вход трёхзначное целое число
//  и на выходе показывает сумму первой и последней цифры этого числа.
//  456 =>10

// Console.WriteLine(" введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = n / 100;
// int b = n % 10;
// int sum = (a + b); // / 10;

// if (n < 100 || n > 1000)
// {
// Console.Write("это не трехзначное число...");
// }
// else
// {
// Console.Write($" сумма первого и третьего числа {n} равна {sum} ");
// }

// // может быть второй вариант  у меня не сработал.
// nt n = int.Parse(Console.ReadLine());
// int firstNum = n/100;
// int lastNum = n%10;
// int sum = firstNum + lastNum;
// Console.WriteLine(sum);
// Console.WriteLine((n/10)%10);

// вариант от преподавателя

Console.WriteLine(" введите трехзначное число: ");
string n = Console.ReadLine()!;

if (Convert.ToInt32(n) < 100 || Convert.ToInt32(n) > 1000)
{
Console.Write("это не трехзначное число...");
}
else
{
Console.WriteLine(Convert.ToInt32(Convert.ToString(n[0]))
+ Convert.ToInt32(Convert.ToString(n[2])));
}