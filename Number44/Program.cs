// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите разряд числа Фибоначчи: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
array[0] = 0;
array[1] = 1;
for (int i = 0; i < size; i++)
{
    int nextElement = array[0] + array[1];
    Console.Write(nextElement);
    array[0] = array[1];
    array[1] = nextElement;
}

/*
int countFibonacci = -4;

if (countFibonacci < 3)
{
    return;
}

int firstElement = 0;

int secondElement = 1;

Console.WriteLine(firstElement); // i = 1
Console.WriteLine(secondElement); // i = 2

for (int i = 3; i <= countFibonacci; i++)
{
    int nextElement = firstElement + secondElement;
    Console.WriteLine(nextElement);
    firstElement = secondElement; //nextElement, от перемены мест слагаемых сумма не меняется
    secondElement = nextElement;
}
*/

