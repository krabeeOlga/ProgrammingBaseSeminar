// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());



double GetPointX (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);    
    return x;
}

double GetPointY (double b1, double k1, double b2, double k2)
{
    double y = k2 * (b2 - b1) / (k1 - k2) + b2;
    return y;
}

double X = GetPointX(b1, k1, b2, k2);
double Y = GetPointY(b1, k1, b2, k2);

Console.WriteLine("Точка пересечения двух прямых, заданных уравнениями");
Console.Write($"y=k1*x+b1, y=k2*x+b2: ({Math.Round(X, 2)}; {Math.Round(Y, 2)})");
//Console.Write("{0,8:F2}", X);


