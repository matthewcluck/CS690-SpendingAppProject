namespace SpendingApp;

class Program
{
    static void Main(string[] args)
    {
        FileSaver fileSaver = new FileSaver("user-data.txt");

        int balance;

        while(true)
        {
            Console.WriteLine("Lets start by entering your bank account balance. No dollar sign, round to the nearest dollar.");
            string input = Console.ReadLine();

            if (int.TryParse(input, out balance))
            {
                fileSaver.AppendLine(balance.ToString());
                
                break;
            }
        }
        
        ConsoleUI theUI = new ConsoleUI();
        theUI.Show();
    }
}