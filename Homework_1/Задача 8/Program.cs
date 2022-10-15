// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = 1;

Console.Write($"Все чётные числа от 1 до {number}: ");

while(temp < number)
{
    if (temp % 2 == 0)
    Console.Write($"{temp} ");
    temp++;   
}   
