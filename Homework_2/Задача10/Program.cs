//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа."
//456 -> 5
//782 -> 8
//918 -> 1
void getSecondDigit(int number)
{
	int result = number / 10 % 10;
	
	Console.WriteLine($"Задача №10");
	Console.Write($"3x значное число: {number}, ");
	Console.WriteLine($"вторая цифра: {result} ");
}
getSecondDigit(new Random().Next(100, 1000));
Console.WriteLine();
