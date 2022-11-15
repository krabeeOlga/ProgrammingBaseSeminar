// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

double[] array = new double[7];

for (int i = 0; i < array.Length; i++)
{
    array[i] = (new Random().NextDouble() * 100) - 30;
    Console.Write("{0,8:F2}", array[i]);
}

double GetDiff(double[] array)
{
    double max = array.Max();
    double min = array.Min();
    double diff = Math.Round((max - min), 2);
    return diff;
}

Console.WriteLine();

double result = GetDiff (array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");