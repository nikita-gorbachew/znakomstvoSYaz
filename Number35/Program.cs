// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите
//  количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте 
// для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

/*35.1

int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int[length];
int A = 10;
int B = 99;
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,123);
    i++;
}

 for(int j = 0; j < array.Length;j++)
{  
    System.Console.WriteLine(array[j]);
}
int d = 0;
while(d < array.Length)
{
    if(array[d] > A && array[d] < B)
    {
        Console.WriteLine(array[d]);
        d++;
    }
}
*/

//35.2

int[] testArray = { -2, -1, 0, 1, 2, 15, 22,99,100 };

int count = 0; // 0 чисел лежат в диапазоне

for (int i = 0; i < testArray.Length; i++) // tesArray.Length - длина массива
{
    if (testArray[i] >= 10 && testArray[i] <= 99) count++; // count = count + 1 
}

Console.WriteLine(count);

