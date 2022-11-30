// Задача №23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
double i = 1;
while (i <= n)
{
  Console.Write($"{Math.Pow(i, 3)}, ");
  i++;
}
