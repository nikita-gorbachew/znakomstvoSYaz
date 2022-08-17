//Напишите программу, которая выводит случ число из отрезка 
//[10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
//12 -> 2
//85 -> 8

// 78 -> 7(нацело 78 на цело на 10) 78/10 = 7
//78 -Ю 8(остаток от деления на 10) -> 78 % 10

int number = new Random().Next(10, 100);
//Console.WriteLine($"Рандомное число: {number}"); //Интерполяция "$"
//Console.WriteLine("Рандомное число" + number); // Конкатенация - сложение строк
//camelCase

int firstDigit = number / 10;
int secondDigit = number % 10;

int maximum = firstDigit; //пусть максимум -  это 1 число (количество десятков)
if (maximum < secondDigit) maximum = secondDigit;

Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}");
//Console.WriteLine($"Текст: {В фигурных скобках - переменная}")
