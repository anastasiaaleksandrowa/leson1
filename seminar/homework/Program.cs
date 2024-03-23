//         //задача 1 Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
// Console.Write ("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.Readline());
// Console.Write ("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.Readline());

//       if (firstNumber == secondNumber)
//       {
//         Console.Write("числа равны");
//       }
//       if (firstNumber > secondNumber)
//       {
//         Console.Write("первое число больше");
//       }
//       if (firstNumber < secondNumber)
//       {
//         Console.Write("второе число больше");
//       }
//     }

// задача 2 Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
//  для сдачи на сайте потребовалось переписать retern


// if(a>b&& a>c)
// {
//     return a;
// }
// else if(b>a && b>c)
// {
//      return b;
// }
// else 
// {
//     return c;
// }


// int max =1;
//     Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if(a > max)
// {
//     max = a;
// }
// if(b > max)
// {
//     max = b;
// }
// if(c > max)
// {
//     max = c;
// }

// Console.WriteLine("max = " + max);

// // задача 3 Внутри класса Answer напишите метод CheckIfEven, 
// // который на вход принимает число number и выводит, 
// // является ли число чётным (делится ли оно на два без остатка).
// // Console.Write ("Введите число: ");
// // int number = Convert.ToInt32(Console.Readline());


//       if (number % 2 == 0)
//       {
//         Console.Write("четное");
//       }
//       if (number % 2 != 0)
//       {
//         Console.Write("нечетное");
//       }


// задача 4 Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
// а на выходе выводит все чётные числа от 1 до number (включительно),
//  после каждого числа должен быть знак пробела.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}