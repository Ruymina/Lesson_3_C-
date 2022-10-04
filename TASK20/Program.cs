// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите X1");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2");
// double y2 = Convert.ToInt32(Console.ReadLine());

// double Distance(double arg1, double arg2, double arg3, double arg4);
// {
//     double res1 = arg3 - arg1;
//     double res2 = arg4 - arg2;
//     double result = Math.Sqrt(Math.Pow(res1, 2) + Math.Pow(res2, 2));
//     return result;
// }

// double res = Math.Round(Distance(x1, x2, y1, y2), 2, MidpointRounding.ToZero);
// Console.WriteLine(res);

Console.WriteLine("Введите координаты первой точки ");
Console.Write("X1 ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
Console.Write("X2 ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int argX1, int argY1, int argX2, int argY2)
{
    double res = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2));
    return res;
}

double distance = Distance(X1, y1, X2, y2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

