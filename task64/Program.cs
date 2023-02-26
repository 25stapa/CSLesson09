/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

//  Initialization and declaration of variable N
int number= GetNumberN("Enter number N: ");
int count = 1;
NumberCount(number, count);

//  Method for obtaining the number N
int GetNumberN(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("You entered not a number, or a number less than or equal to zero, please try again...");
        }
    }
    return result;
}

void NumberCount(int n, int count)
{
    if (count>n)
    {
        return;
    }
    else
    {
        NumberCount(n, count + 1);
        Console.Write($"{count}; ");
    }  
}
