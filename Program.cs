using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select a task:");
            Console.WriteLine("1 - Average earnings");
            Console.WriteLine("2 - Graph with stars");
            Console.WriteLine("3 - Generating Prime Numbers");
            Console.WriteLine("4 - Password verification");
            Console.WriteLine("5 - Fibonacci Sequence");
            Console.WriteLine("6 - Salary calculator");
            Console.WriteLine("7 - Multiplication table");
            Console.WriteLine("8 - Simplicity check");
            Console.WriteLine("9 - Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": CalculateAverageSalary(); break;
                case "2": DrawStarsGraph(); break;
                case "3": GeneratePrimeNumbers(); break;
                case "4": ValidatePassword(); break;
                case "5": GenerateFibonacci(); break;
                case "6": CalculateHourlyWage(); break;
                case "7": MultiplicationTable(); break;
                case "8": CheckPrimeNumber(); break;
                case "9": return;
                default: Console.WriteLine("Incorrect input. Please try again."); break;
            }
        }
    }

    // 1
    static void CalculateAverageSalary()
    {
        Console.Write("Enter the number of employees:");
        int count = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Salary {i + 1}-th employee: ");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Average earnings: {sum / count}");
    }

    // 2
    static void DrawStarsGraph()
    {
        Console.Write("Enter the number of lines:");
        int rows = int.Parse(Console.ReadLine());
        for (int i = 1; i <= rows; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    // 3
    static void GeneratePrimeNumbers()
    {
        Console.Write("Enter upper limit:");
        int max = int.Parse(Console.ReadLine());

        for (int num = 2; num <= max; num++)
        {
            if (IsPrime(num)) Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    // 4
    static void ValidatePassword()
    {
        Console.Write("Enter password:");
        string password = Console.ReadLine();

        bool hasDigit = password.Any(char.IsDigit);
        bool hasSpecial = password.Any(ch => "!@#$%^&*()_+".Contains(ch));

        if (password.Length >= 8 && hasDigit && hasSpecial)
            Console.WriteLine("Password accepted.");
        else
            Console.WriteLine("The password does not meet the requirements.");
    }

    // 5
    static void GenerateFibonacci()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }

    // 6
    static void CalculateHourlyWage()
    {
        Console.Write("Hours of operation per day:");
        double hours = double.Parse(Console.ReadLine());
        Console.Write("Hourly rate:");
        double rate = double.Parse(Console.ReadLine());
        Console.WriteLine($"Payment per day: {hours * rate}");
    }

    // 7
    static void MultiplicationTable()
    {
        Console.Write("Enter number:");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }

    // 8
    static void CheckPrimeNumber()
    {
        Console.Write("Enter number:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(num) ? "The number is prime" : "The number is not prime");
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
