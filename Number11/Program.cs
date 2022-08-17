// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

/* 11.

int number = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число: {number}");
int firstDigit = number / 100; //Digit -цыфра
int secondDigit = number % 10;
Console.WriteLine($"Искомое число: {firstDigit}{secondDigit}");

*/

// 12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

/* 12.

Console.WriteLine($"Первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(secondNumber % firstNumber == 0)
{
    Console.WriteLine($"Второе число: {secondNumber} кратно первому числу: {firstNumber}");
}
else
{
    Console.WriteLine($"Второе число: {secondNumber} не кратно первому числу: {firstNumber} остаток от деления {secondNumber % firstNumber}");
}
*/

// 14.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да


//14.

Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine("Yes");
}
  else
{
    Console.WriteLine("No");
}

