// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

// 1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
// 6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

Main();

void Main()
{
    int[] array = GetArray(8, 0, 99);
    PrintArray(array);
}

int[] GetArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
    }
    return newArray;
}

void PrintArray(int[] userArray)
{
    Console.Write("[ ");
    for (int j = 0; j < userArray.Length; j++)
    {
        Console.Write($"{userArray[j]} ");
    }
    Console.Write("]");
}