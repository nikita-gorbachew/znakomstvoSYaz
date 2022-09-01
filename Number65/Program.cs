// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int M = Convert.ToInt32(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
if (N > M) return;


string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString(); // Базовый случай
    return (start + ", " + PrintNumbers(start + 1, end)); // Рекурсивный случай
}

Console.WriteLine(PrintNumbers(M, N));
