using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value of n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of k:");
        int k = int.Parse(Console.ReadLine());

        double pnk = CalculatePnk(n, k);

        Console.WriteLine($"The value of P({n},{k}) is {pnk}.");
    }

    public static double CalculatePnk(int n, int k)
    {
        double factorialN = Factorial(n);
        double factorialNK = Factorial(n - k);
        double pnk = factorialN / factorialNK;
        return pnk;
    }

    private static double Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}

