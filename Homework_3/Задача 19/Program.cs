// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void isPalindrome()
{
	Console.WriteLine($"Задача №13 Проверка на палиндром");
	Console.WriteLine("Введите число: ");
	int number = Convert.ToInt32(Console.ReadLine());
	
	if (number == reverseInt(number))
	{
		Console.WriteLine($"{number} -> да");
	} 
	else
	{
		Console.WriteLine($"{number} -> нет");
	}
}

int reverseInt(int num)
{
    int result = 0;
    while (num > 0) 
    {
       result = result * 10 + num % 10;
       num /= 10;
    }
    return result;
}

isPalindrome();
