namespace SpendingApp
{
    public class TrackerUI
    {
        private Balance balance;

        public TrackerUI(Balance balance)
        {
            this.balance = balance;
        }

        public void Show()
        {

            while (true)
            {
                string mode = UserInputHelper.AskForInput("You may now choose from the following options: (1) View All Expenses (2) View Expense by Day, (3) View Expense by Type, (4) View Income by Day, (5) View Income By Source, (6) Exit to Main Menu");

                if (mode == "1")
                {
                    TrackerFunctions.PrintExpenseList();
                    break;
                }
                else if (mode == "2")
                {
                    TrackerFunctions.ViewExpensesByDay();
                    break;
                }
                else if (mode == "3")
                {
                    TrackerFunctions.ViewExpensesByType();
                    break;
                }
                else if (mode == "4")
                {
                    TrackerFunctions.ViewIncomeByDay();
                    break;
                }
                else if (mode == "5")
                {
                    TrackerFunctions.ViewIncomeBySource();
                    break;
                }
                else if (mode == "6")
                {
                    Console.WriteLine("Exiting to main menu...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please enter a valid number.");
                }
            }

            ConsoleUI theUI = new ConsoleUI(balance);
            theUI.Show();
        }
    }
}
