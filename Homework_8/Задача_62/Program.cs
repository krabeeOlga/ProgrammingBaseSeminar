// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiral(int[,] array)
{
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = array.GetLength(1);
    
    for (int i = 0; i < array.Length; i++) 
    {
        array[row, col] = i + 1;
        if (--visits == 0) 
        {
            visits = array.GetLength(1) * (dirChanges %2) + array.GetLength(0) * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 3}",array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4,4];
FillSpiral(array);
PrintArray(array);