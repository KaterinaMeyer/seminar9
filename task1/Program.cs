// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Результат:");
        PrintNumbers(n);
    }

    static void PrintNumbers(int n)
    {
        if (n <= 0)
        {
            return;
        }

        Console.Write(n);
        if (n > 1)
        {
            Console.Write(", ");
        }

        PrintNumbers(n - 1);
    }
}
