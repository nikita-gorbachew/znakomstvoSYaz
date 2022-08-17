// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

///////1. for
/*
int A = Convert.ToInt32(Console.ReadLine()); // [1;A]
// 4 -> от 1 до 4 = 1+2+3+4
//for (начало; условие; увеличение счетчика)
int sum = 0; // Сумма чисел - изначально 0
for(int i = 1; i <= A; i++)
{
    sum += i; // sum sum + i
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {sum} ");
*/

///////2. Методы
// Метод - подпрограмма, которая выполняет рутинный код
// Заполнить 50 массивов: если есть метод, он вызывается 50 раз
// 50 циклов for

// type NameMethod (params)
// int Calculate (int a, int b)
/*
int A = Convert.ToInt32(Console.ReadLine()); //[1;A]

int GetSumNumbers(int number)
{
    int sum = 0; // Результат
    int start = 1; // начало нашего цикла
    while (start <= number) // [1;A]
    {
        sum += start; // sum = sum + start
        start++; // start = start + 1
    }
    return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");
*/

///////3.