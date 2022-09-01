// Задача 69: Напишите программу, которая на вход принимает 
//два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int number = Convert.ToInt32(Console.ReadLine());
// Степень
int degree = Convert.ToInt32(Console.ReadLine());

int Power(int num, int power)
{
    // Базовый случай
    if (power == 1) return num; // num ^ 1 =  num
    if (power == 0) return 1;   // Любое число в 0 степени = 1
    // Рекурсивный случай
    // power - количество раз, благодаря которому мы умножаем number на number
    // power = 2, number * number
    return (num * Power(num, power - 1));
}

Console.WriteLine($"Число {number} в степени {degree} = {Power(number, degree)}");
