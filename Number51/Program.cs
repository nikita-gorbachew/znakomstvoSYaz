﻿// Задача №51. найти сумму элементов главной диагонали
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++) // строчки
{
    for (int j = 0; j < matrix.GetLength(1); j++)  // столбцы
    {
        matrix[i, j] = new Random().Next(11); //[0;10]
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Result array:");
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j) sum += matrix[i,j]; // sum = sum + matrix[i,j]
    }
}
Console.WriteLine(sum);