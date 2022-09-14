/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
["1234", "1567", "-2", "computer science"] → [“-2”]
["Russia", "Denmark", "Kazan"] → []*/

void PrintArr(string[] array)
{
    Console.Write("[");
    if (array.Length == 0) Console.Write("]");
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length - 1) Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1]);
        Console.Write("]");
    }
}

string[] ChangeArray(string[] array)
{
    int count = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3) count++;
        i++;
    }
    string[] newArray = new string[count];
    int j = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

string[] arr = { "Russia", "Denmark", "Kazan", "Hello", "1234", "1567", "-2", "computer science"};
string[] result = ChangeArray(arr);
PrintArr(result);
