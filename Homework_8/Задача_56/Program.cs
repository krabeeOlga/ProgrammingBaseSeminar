// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArrayRandom (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillArrayRandom (array);
Console.WriteLine();

int[] res = new int[array.Length];
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];   
    }
    res[i] = sum; 
    sum = 0; 
}

int min = 0;   
for (int i = 1; i < array.GetLength(0); i++)
{
    if (res[i] < res[min])   
    min = i;
}
Console.WriteLine($"Номер строки с минимальной суммой элементов: {min + 1}");



