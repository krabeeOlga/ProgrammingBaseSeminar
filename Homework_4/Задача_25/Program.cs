// Напишите программу, которая принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. 
// Для решения задания использование цикла for является обязательным условием. 
// Не использовать встроенный метод возведения в степень.

int GetDegree(int a, int b)
{
   int result = a;
   for (int i = 1; i < b; i++)
   {
        result = result * a;
   }

    return result;
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b <= 0)
{
    Console.WriteLine("Число B должно быть больше 0");
    return;
}

int number = GetDegree(a, b);
Console.WriteLine(number);