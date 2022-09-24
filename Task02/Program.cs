// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
using static System.Console;
Clear();
Write("Введите коордитнату x1=");
double x1=Convert.ToDouble(ReadLine());
Write("Введите коордитнату y1=");
double y1=Convert.ToDouble(ReadLine());
Write("Введите коордитнату z1=");
double z1=Convert.ToDouble(ReadLine());
Write("Введите коордитнату x2=");
double x2=Convert.ToDouble(ReadLine());
Write("Введите коордитнату y2=");
double y2=Convert.ToDouble(ReadLine());
Write("Введите коордитнату z2=");
double z2=Convert.ToDouble(ReadLine());

double distance=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y2-y1,2)+Math.Pow(z1-z2,2));
WriteLine($"Расстояние между точками равно {distance}");