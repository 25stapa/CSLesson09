/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int Amount(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;           // If M = 0;
    else if (N == 0) return (M * (M + 1)) / 2;      // If N = 0;
    else if (M == N) return M;                      // If M = N;
    else if (M < N) return N + Amount(M, N - 1);    // If M < N;
    else return N + Amount(M, N + 1);               // If M > N;
}

Console.WriteLine($"The sum of natural elements between {m} and {n}: {Amount(m, n)}");