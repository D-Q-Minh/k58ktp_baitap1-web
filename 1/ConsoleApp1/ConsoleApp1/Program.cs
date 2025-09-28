using System;

public class PrimeChecker
{
    public static bool IsPrime(int number)
    {
        // 1. Handle base cases (numbers less than or equal to 1 are not prime)
        if (number <= 1)
        {
            return false;
        }

        // 2. Handle 2 (2 is the only even prime number)
        if (number == 2)
        {
            return true;
        }

        // 3. Handle even numbers greater than 2 (they are not prime)
        if (number % 2 == 0)
        {
            return false;
        }

        // 4. Check for divisibility by odd numbers from 3 up to the square root of the number
        // We only need to check up to Math.Sqrt(number) because if a number 'n' has a divisor
        // greater than its square root, it must also have a divisor smaller than its square root.
        int limit = (int)Math.Floor(Math.Sqrt(number));
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0)
            {
                return false; // Found a divisor, so it's not prime
            }
        }

        // 5. If no divisors were found, the number is prime
        return true;
    }

    public static void Main(string[] args)
    {
        Console.Write("nhap 1 so: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"\n{number} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"\n{number} khong la so nguyen to");
            }
        }
        else
        {
            Console.WriteLine("\nloi, nhap lai");
        }
    }
}