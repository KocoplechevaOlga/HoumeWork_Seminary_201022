// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
//Например: A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistance3D (double X1, double Y1, double Z1, double X2, double Y2, double Z2)
{
double dis = Math.Round(Math.Sqrt(Math.Pow((Y1-Y2), 2) + (Math.Pow((X1-X2), 2) + Math.Pow((Z1-Z2), 2))), 2, MidpointRounding.ToZero);
return dis;
}

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1= ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1= ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1= ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2= ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2= ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2= ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = GetDistance3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками в 3D пространстве составляет {result}");
