// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
void findDistance3d()
{		
	Console.WriteLine($"Задача №14: расстояние между двух координат в 3D");
	
	Console.WriteLine("Координаты 1 точки:");
	Console.WriteLine("Введите число x1: ");
	int x1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите число y1: ");
	int y1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите число z1: ");
	int z1 = Convert.ToInt32(Console.ReadLine());
	
	Console.WriteLine("Координаты 2 точки:");
	Console.WriteLine("Введите число x2: ");
	int x2 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите число y2: ");
	int y2 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите число z2: ");
	int z2 = Convert.ToInt32(Console.ReadLine());
	
	double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
	double round = Math.Round(result, 2);
	Console.WriteLine($" A({x1},{y1},{z1}) B({x2},{y2},{z2});  -> {round}");
	
}

findDistance3d();