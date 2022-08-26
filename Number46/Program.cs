//Задача 46: Задайте двумерный массив размера m на n, заполненный случайными числами.
// m =3, n = 4

Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
// m - строка, n - столбцы
int[,] GetArray (int m, int n)
{
    int [,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // столбцы
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}
int [,] result = GetArray(rows, columns); // числа от 0 - 10 в двумерном массиве

void PrintArray (int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)  // GetLength(0) строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)  // GetLength()1 столбцы
        {
            Console.Write(inputMatrix[i, m] + "\t"); // "\t" - Tab
        }
        Console.WriteLine();
    }
}
PrintArray(result);
