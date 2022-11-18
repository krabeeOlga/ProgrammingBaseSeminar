// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// new Random().Next(2, 5)

int result = 0;

for (int i = 1; i <= new Random().Next(3, 8); i++)
{
    Console.Write($"Введите число №{i}: ");
    if (Convert.ToInt32(Console.ReadLine()) > 0) 
    {
        result++;
    }
} 
Console.WriteLine($"Количество положительных чисел среди введенных: {result}");