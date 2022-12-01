Console.Clear();
Console.WriteLine("Введите координату точки Ax: ");
int Ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки Ay: ");
int Ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки Az: ");
int Az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки Bx: ");
int Bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки By: ");
int By = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату точки Bz: ");
int Bz = int.Parse(Console.ReadLine());
double distance = 0;
distance = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
Console.WriteLine(Math.Round(distance, 2));


