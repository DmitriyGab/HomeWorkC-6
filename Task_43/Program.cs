// Вспомнить формулу прямой на плоскости

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y=5*x+2     5*-3 + 2 = x=-3 y=-15+2=-13 x=-2 y=-8 x=-1 y=-3 x=0 y=2 x=1 y=7 x=2 y=12
// y=9*x+4                                 x=-2 y=-14 x=-1 y=-5 x=0 y=4 x=1 y=13

// y=5*x + 2
// y=9*x + 4

// 5*x + 2 = 9*x + 4
// 5*x + (-9*x) = -2 + 4 // -4x=2 // x=2/(-4); x= -0.5; y= 5*(-0.5)+2 y=9*(-0.5)+4; y= -0.5
// (b1*(-1) +b2) / k1+(k2 * -1)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
double x = 0;
double y = 0;
// double b = 0;
// double k = 0;

x = (b1*-1+b2) / (k1+k2*-1);
// b = b1*-1 +b2;
// Console.WriteLine($"b: {b}");
// k = k1+k2*-1;
// Console.WriteLine($"k: {k}");
// x= b / k;
// Console.WriteLine($"x: {x}");
y = k1*x + b1;


Console.WriteLine($"x: {Math.Round(x,3)}; y: {Math.Round(y,3)}");