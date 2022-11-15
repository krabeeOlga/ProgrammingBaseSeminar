// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[7];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 1000);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int result = CountEven(array);
Console.WriteLine($"Количество четных чисел в массиве: {result}");

