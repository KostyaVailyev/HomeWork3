﻿Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int pal = 0, num = number;
while (number > 0)
{
    pal = pal * 10 + number % 10;
    number /= 10;
}
Console.WriteLine(num == pal ? $"Число {num} является палиндромом" : $"Число {num} не является палиндромом");
