// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void cube()
{		
	Console.WriteLine($"Задача №23: кубы");
	
	Console.WriteLine("Введите число: ");
	int N = Convert.ToInt32(Console.ReadLine());
	
	Console.Write($"{N} -> ");
	for (int i = 1; i <= N; i++) {
		double cube = Math.Pow(i, 3);
		Console.Write($"{cube}, ");
	}
	
}

cube();