//напишите программу , которая  на вход принимает два целых числа и проверяет является ли первое число квадратом второго


// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2*num2);
// {
//     Console.WriteLine($"квадрат числа {num1} равен {num2}");
// }
// else  Console.WriteLine("квадрат числа {0} не равен {1}", num1, num2);  


Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2 )
{
Console.WriteLine($"Квадрат числа {number2} равен {number1}");
}
else Console.WriteLine("Квадрат числа {0} НЕ равен {1}", number2, number1);