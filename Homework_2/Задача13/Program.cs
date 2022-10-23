//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
void getThreeDigit()
{
  Console.WriteLine($"Задача №13");
  Console.WriteLine("Введите число: ");
  int number = Convert.ToInt32(Console.ReadLine());
  if (number < 100)
  {
    Console.WriteLine("третьей цифры нет");
  } 
  else
  {
  // переворачиваем число и берем 3 цифру справа
    // (% 1000) отсекаем сотни, (/ 100) достаем 3 цифру 
    int result = reverseInt(number) % 1000 / 100;
  
    Console.Write($"Число на входе: {number}, ");
    Console.WriteLine($"Третья цифра: {result} ");
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

getThreeDigit();

