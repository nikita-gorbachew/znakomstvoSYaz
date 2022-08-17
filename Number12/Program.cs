// 12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


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