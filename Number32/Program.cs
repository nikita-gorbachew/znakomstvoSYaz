// Задача 32: Напишите программу замена элементов массива: положительные
// элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int[length];

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,9);
    Console.WriteLine(array[i]);
    array[i] *= (-1);
    Console.WriteLine(array[i]);
}
