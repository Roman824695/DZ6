int ReadInt(string message)
{
Console.Write("Введите число " + message + " -> ");
return Convert.ToInt32(Console.ReadLine());
}
double b1 = ReadInt("b1");
double k1 = ReadInt("k1");
double b2 = ReadInt("b2");
double k2 = ReadInt("k2");

double SumX(double b1, double k1, double b2, double k2)
{
double x = (b2 - b1) / (k1 - k2);
return x;
}
double SumY(double k1,double x, double b1)
{
double y = k1 * x + b1;
return y;
}


if (k1 == k2 && b1 == b2)
{
Console.WriteLine("Прямые совпадают");
}
else if(k1 == k2)
{
Console.WriteLine("Прямые паралельны");
}
else
{
double x = SumX(b1, k1, b2, k2);
double y = SumY(k1, x, b1);
Console.WriteLine($"Пересечение в точке: ({x};{y})");
}