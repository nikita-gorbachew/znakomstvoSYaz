// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух 
// других сторон.

Console.WriteLine("Введите длину сторон треугольника.");
Console.WriteLine("Введите первую сторону A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону C: ");
int C = Convert.ToInt32(Console.ReadLine());
if(A < B + C && B < A + C && C < A + B) Console.WriteLine("Треугольник возможен");
else Console.WriteLine("Треугольник не возможен");
//2
/*
int sideLengthA = Convert.ToInt32(Console.ReadLine());
int sideLengthB = Convert.ToInt32(Console.ReadLine());
int sideLengthC = Convert.ToInt32(Console.ReadLine());

void Check(int a, int b, int c)
{
    if( a > b + c && b < c + a && c < b + a)
    {
        System.Console.WriteLine($"Да существует");
    }
    System.Console.WriteLine($"Нет такого");
}
Check(sideLengthA,sideLengthB,sideLengthC);
*/
