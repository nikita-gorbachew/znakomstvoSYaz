﻿// Задача 45: Напишите программу, которая будет создавать копию заданного
//  массива с помощью поэлементного копирования.
int[] CopyArray(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];

}
return result;
}