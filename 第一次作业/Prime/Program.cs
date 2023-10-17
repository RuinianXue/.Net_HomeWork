using System;

public class PrimeFactor
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime factors of " + number + " are:");
        for (int i = 2; i <= number; i++)
        {
            while (number % i == 0)
            {
                Console.WriteLine(i);
                number /= i;
            }
        }
    }
}
