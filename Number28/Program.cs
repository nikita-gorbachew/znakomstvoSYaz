// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


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
