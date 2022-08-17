// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
/*
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
*/

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


/*
int num = Convert.ToInt32(Console.ReadLine());

int GetMultiply (int number)
{
    int result = 1; // 2*0 = 2; при умножении указываем 1: любое число на 1 = число
    // Multiply[1;N]
    for (int i = 1; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
System.Console.WriteLine($"Факториал от {num} = {GetMultiply(num)}");
*/


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8];
// Random x = new Random();
// for (int i = 0; i < 8; i++)
// {
//     array[i] = x.Next(0, 2);
//     Console.Write(array[i] + " ");
// }

int[] GetBinaryArray(int size)
{
    int[] result = new int[size]; // size = 2; result = [0,0]
    for (int i = 0; i < result.Length; i++) // size = result.Length
    {
        result[i] = new Random().Next(2); // если указано одно число, то идем от 0 до этого числа
    }
    return result;
}
int[] testArray = GetBinaryArray(8);
Console.WriteLine($"Массив: [ {String.Join("; ",testArray)} ]");
