// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

Console.WriteLine("Первая матрица: ");
int[,] array1 = new int[2, 3];
FillArrayRandom (array1);
Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
int[,] array2 = new int[3, 2];
FillArrayRandom (array2);
Console.WriteLine();

int[,] GetProductMatrix (int[,] array1, int[,] array2)
{
int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int k = 0; k < array2.GetLength(0); k++)
        {
            result[i, j] += array1[i, k] * array2[k, j];
        }
    }
}
return result;
}

int[,] resultArray = GetProductMatrix(array1, array2);
Console.WriteLine("Произведение двух матриц: ");
for (int i = 0; i < resultArray.GetLength(0); i++)
{
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
        Console.Write(resultArray[i, j] + " ");
    }
    Console.WriteLine();
}

