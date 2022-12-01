Console.Clear();
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int cube = 0;
for (int i = m; i <= n; i++)
{
    cube = i * i * i;
    Console.WriteLine($"Куб числа {i} = {cube}");
}