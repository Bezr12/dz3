// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

// bool Palindrom(int num)
// {
//     int origNum = num;
//     int reverseNum = 0;
    
//     while (num > 0)
//     {
//         int lastDigit = num % 10;
//         reverseNum = (reverseNum * 10) + lastDigit;
//         num /=10;
//     }
//     return origNum == reverseNum;
// }

// Console.Write("Введите число для провреки на палиндромность: ");
// int chislo = Convert.ToInt32(Console.ReadLine());

// bool palim = Palindrom(chislo);
// if (palim)
// {
//     Console.WriteLine(chislo + " является палиндромом");
// }
// else
// {
//     Console.WriteLine(chislo + " не является палиндромом");
// }



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Koordinat(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double distX = x2 - x1;
//     double distY = y2 - y1;
//     double distZ = z2 - z1;
//     double result = Math.Sqrt(distX * distX + distY * distY + distZ * distZ);
//     return result;
// }

// Console.WriteLine("Введите значение х1 - ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение y1 - ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение z1 - ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение х2 - ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение y2 - ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение z2 - ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double rez = Math.Round(Koordinat(x1, y1, z1, x2, y2, z2), 2);

// Console.Write($"Расстояние между точками - {rez}");



//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TablKub(int N)
{
    int count = 1;
    while (count <= N)
    {
        Console.WriteLine($"Куб {count} составляет - {count * count * count}");
        count++;
    }
}

Console.Write("Введите значение - ");
int num = Convert.ToInt32(Console.ReadLine());
TablKub(num);
