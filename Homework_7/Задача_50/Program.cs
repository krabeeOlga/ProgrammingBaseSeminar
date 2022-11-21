// Напишите программу, которая будет принимать от пользователя позицию (M, N)
// двумерного массива и возвращать значение элемента, 
// стоящего в этой позиции. Если такой позиции в массиве нет, 
// то сообщить об этом пользователю. Сгенерировать массив случайным образом. 
// Размерность массива определить самостоятельно. 
// Использование методов для заполнения массива обязательно. 
// Остальное можно реализовать в главной программе.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.

void FillArrayRandom (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[5, 6];
FillArrayRandom (array);
PrintArray (array);

Console.Write("Введите номер строки (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца (N): ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < array.GetLength(0) && n < array.GetLength(1))
{
    Console.Write($"Значение элемента, стоящего в позиции ({m},{n}): {array[m, n]}");
}
else
{
    Console.Write("Такой позиции в массиве нет!"); 
}
