// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

/*
21.1
Console.Write("Введите координаты точки A по оX ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А по оY ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оX ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B по оY ");
int By = Convert.ToInt32(Console.ReadLine());

double lengthAB = Math.Sqrt((Bx-Ax)*(Bx-Ax)+(By-Ay)*(By-Ay)); //Math - для математич решений
Console.WriteLine("Длина отрезка AB" + lengthAB );

21.2*/
Console.Write("Введите координату Х  точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y  точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х  точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y  точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2,2) + (Math.Pow(y1-y2,2)));
Console.WriteLine($"Расстояние: {Math.Round(result,3)}");

