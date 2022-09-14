/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

void PrintArr(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}


string[] arr = {"1234", "1567", "-2", "computer science"};
int count = 0;
int i  = 0;
while(i<arr.Length)
{
    if (arr[i].Length<=3)
    {
        count++;
    }
    i++;
}
string[] newArr = new string[count];

int j = 0;
for (i=0; i < arr.Length; i++)
{
    if(arr[i].Length<=3)
    {
        newArr[j] = arr[i];
        j++;
    }
}
PrintArr(newArr);
