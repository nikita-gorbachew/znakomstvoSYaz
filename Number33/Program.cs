// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


/*33.1

int length = Convert.ToInt32(Console.ReadLine());
int [] array = new int[length];
System.Console.WriteLine("Какое число хотите найти");
int findNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;

if(count == 1){
  Console.WriteLine($"Да есть такое число {findNumber} ");
}else{
        Console.WriteLine($"Нет такого числа {findNumber} ");
    }

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1,10);
    if(array[i] == findNumber){
        count ++;
    }
    Console.WriteLine(array[i]);
}
*/

/*33.2

int[] testArray = {-2,-1,0,1,2};
int searchElement = Convert.ToInt32(Console.ReadLine());

string foundResult = "не найден"; // false - element not found
for (int i = 0; i < testArray.Length; i++)
{
    if (testArray[i] == searchElement) 
    {
        foundResult = "найден"; // element found
        break;
    }
}
Console.WriteLine($"Элемент {searchElement}: {foundResult}");
// if (foundResult == "найден") Console.WriteLine($"Элемент {searchElement} присутствует ");
//  //foundResult == true => foundResult
// else Console.WriteLine($"Элемент {searchElement} ОТСУТСТВУЕТ ");
*/

//33.3

bool testNumber = false;
if (testNumber) System.Console.WriteLine("true"); // testNumber==true => testNumber
if(!testNumber) System.Console.WriteLine("false");// !testNumber => testNumber == false
