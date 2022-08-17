// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//30.1

// int[] array = new int[8];
// Random x = new Random();
// for (int i = 0; i < 8; i++)
// {
//     array[i] = x.Next(0, 2);
//     Console.Write(array[i] + " ");
// }

//30.2

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