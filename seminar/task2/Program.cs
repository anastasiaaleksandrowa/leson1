// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int notN = -N;

while (notN <= N){
Console.Write($"{notN} ");
notN++;
}