// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int num)
{
    if (num > 10000 & num < 99999)
    {
        int div1 = num / 10000;
        int rem1 = num % 10;
        if (div1 == rem1)
        {
            num = num / 10;
            int div2 = (num / 100) % 10;
            int rem2 = num % 10;
            if (div2 == rem2) Console.WriteLine("Число является палиндромом!");
        }
        else
            Console.WriteLine("Число НЕ является палиндромом.");
    }
    else
    {
        Console.WriteLine("Введите ПЯТИЗНАЧНОЕ число");
    }
}
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistancePoint(int xa, int xb, int ya, int yb, int za, int zb)
{
    double abz = Math.Sqrt(((xb - xa) * (xb - xa)) + ((yb - ya) * (yb - ya)) + ((zb - za) * (zb - za)));
    return abz;
}

Console.Write("Введите координаты xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты zb: ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = DistancePoint(xa, xb, ya, yb, za, zb);
Console.WriteLine($"Расстояние между точками ({xa},{ya},{za}) и ({xb},{yb},{zb}) равно: {result}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void TableOfCube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{i * i * i} ");
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
TableOfCube(num);
