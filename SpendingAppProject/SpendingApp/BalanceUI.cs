namespace SpendingApp
{
    public class BalanceUI
    {
        private int balance;
        private Balance initBalance;
        private FileSaver fileSaver;

        public BalanceUI()
        {
            fileSaver = new FileSaver("user-data.txt");
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("Let's start by entering your bank account balance. No dollar sign, round to the nearest dollar.");
                string input = Console.ReadLine();

                if (int.TryParse(input, out balance))
                {
                    fileSaver.AppendLine(balance.ToString());
                    initBalance = new Balance(balance);
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number for your balance.");
                }
            }

            ConsoleUI theUI = new ConsoleUI(initBalance);
            theUI.Show();
        }
    }
}
