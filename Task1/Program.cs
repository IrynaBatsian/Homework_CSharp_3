// Задача №19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом.

Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a1 = n % 10;
int a2 = n / 10000;
int b1 = (n / 10) % 10;
int b2 = (n / 1000) % 10;
int c = (n / 100) % 10;
int n2 = (a1 * 10000 + b1 * 1000 + c * 100 + b2 * 10 + a2);
if (n == n2)
    Console.Write("YES");
else    
    Console.Write("NO");

