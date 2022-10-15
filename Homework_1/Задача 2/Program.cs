// Поиск максимального и минимального значения из двух чисел

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("Они равны");
}
else
{
    if (number1 > number2) Console.WriteLine($"Mаксимальное число = {number1}, минимальное число = {number2}");
    else Console.WriteLine($"Максимальное число = {number2}, минимальное число = {number1}"); 
}
