//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
void checkHoliday(int find)
{
	Console.WriteLine($"Задача №15");
	if (find % 6 == 0 || find % 7 == 0)
	{
		Console.Write($"{find} -> да");	
	}
	else
	{
		Console.Write($"{find} -> нет");	
	}
}
checkHoliday(new Random().Next(1, 8));
