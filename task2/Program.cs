// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// создаем ф вводв
int Input(string message)
{
    System.Console.WriteLine(message + ">");
    string inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
//  
int CountRank(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count = count + 1;
    }
    return count;
}
int number = Input ("ввод пользователем числа");
System.Console.WriteLine(CountRank (number));