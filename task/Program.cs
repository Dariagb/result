/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

Console.Clear();

string[] mainarray = new string[5] {"7765", "45", "87", "progres", "run"};
string[] resultarray = new string[mainarray.Length];

FillArray(mainarray, resultarray);
PrintArray(resultarray);

void FillArray(string[] mainarray, string[] resultarray)
{
    int count = 0;
    for (int i = 0; i < mainarray.Length; i++)
    {
    if(mainarray[i].Length <= 3)
        {
        resultarray[count] = mainarray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

