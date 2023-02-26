/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29
*/

//  Initialization and declaration of variable M and N
int m = GetNumberN("Enter number M: ");
int n = GetNumberN("Enter number N: ");


//  Method for obtaining the number M and N 
int GetNumberN(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
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

//  Calling the Ackermann function
void FunctionAkkerman(int m, int n)
{
    Console.Write($"Function Akkerman = {Akk(m, n)};");
}

//  Ackermann function
int Akk(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akk(m - 1, 1);
    }
    else
    {
        return (Akk(m - 1, Akk(m, n - 1)));

    }
}

FunctionAkkerman(m, n);