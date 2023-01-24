// Задача 2: Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

//  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// создаем ф вводв
int Input(string message)
{
    System.Console.WriteLine(message + ">");
    string inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}
int Factorial(int number)
{
    int Fact = 1;
   
    while (number > 0)
    {
        Fact = number * Fact;
        number = number - 1;
    }

    return Fact;
}
int number = Input ("ввод пользователем числа");
System.Console.WriteLine(Factorial (number));