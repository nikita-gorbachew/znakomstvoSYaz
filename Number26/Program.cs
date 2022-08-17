// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int num = Convert.ToInt32(Console.ReadLine());
int GetCountNumbers(int number)
{
    int count = 0; // счетчик
    while (number > 0)
    {
        count++;//count = count + 1
        number /= 10; // Деление на 10
    }
    return count;
}

Console.WriteLine($"Количество чисел: {GetCountNumbers(num)}");




