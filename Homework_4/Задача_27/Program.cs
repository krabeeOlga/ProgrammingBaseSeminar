// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Для решения задания использование цикла for является обязательным условием

int GetSumDigit (int a)
{
    string b = Convert.ToString(a);
    int sum = 0;

    for(int i = 0; i < b.Length; i++)
    {
        sum = sum + Convert.ToInt32(b[i].ToString());
    }

    return sum;
}

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = GetSumDigit(a);
Console.Write(sum);
