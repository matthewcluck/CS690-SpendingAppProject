namespace SpendingApp;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int balance;
        
        do {
            Console.WriteLine("Please enter your bank account balance. No dollar sign, round to the nearest dollar.");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out balance))
            {
                    Console.WriteLine("Invalid input. Please enter a whole number.");
                    continue;
            }
        } while (balance != 700);

    }
}