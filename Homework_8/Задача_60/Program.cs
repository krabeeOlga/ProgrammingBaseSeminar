// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArrayRandom (int[,,] array)
{
    // список занятых чисел
    List<int> repsList = new List<int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = GetUniqueNumber(repsList);
                Console.Write($" {array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int GetUniqueNumber(List<int> repsList)
{
    Random r = new Random();
    int uniq;
    
    while(repsList.Contains(uniq  = r.Next(10, 100)))
    {
        // попали в повтор
    }
    repsList.Add(uniq);

    return uniq;
}

int[,,] array = new int[2, 2, 2];
FillArrayRandom (array);