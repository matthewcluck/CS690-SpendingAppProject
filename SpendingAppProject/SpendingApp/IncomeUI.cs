namespace SpendingApp
{
    public class IncomeUI
    {
        private Balance balance;

        public IncomeUI(Balance balance)
        {
            this.balance = balance;
        }

        public void Show()
        {
            int incomeDollarInt = 0;
            string incomeSource = "";
            string incomeDay = "";

            while (true)
            {
                string incomeDollar = UserInputHelper.AskForInput("Now please enter an income rounded to the nearest dollar.");

                if (int.TryParse(incomeDollar, out incomeDollarInt) && incomeDollarInt >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again and enter a valid whole number.");
                }
            }

            while (true)
            {
                incomeSource = UserInputHelper.AskForInput("Now enter type of income, such as Job or Gift.");

                if (true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again.");
                }
            }

            while (true)
            {
                incomeDay = UserInputHelper.AskForInput("Now finally enter a day of the week, like Tuesday.");
                if (incomeDay == "Monday" || incomeDay == "Tuesday" || incomeDay == "Wednesday" ||
                    incomeDay == "Thursday" || incomeDay == "Friday" || incomeDay == "Saturday" ||
                    incomeDay == "Sunday")
                {
                    Console.WriteLine("Successfully added income to your data!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid day of the week.");
                }
            }

            Income newIncome = new Income(incomeDollarInt, incomeSource, incomeDay);
            IncomeDataStore.AddIncome(newIncome);
            Console.WriteLine($"You received ${newIncome.Total} from {newIncome.Source} on {newIncome.Day}. Data collected!");

            balance.AddIncome(newIncome.Total);

            Console.WriteLine($"Your new balance is: ${balance.Total}");

            ConsoleUI theUI = new ConsoleUI(balance);
            theUI.Show();
        }
    }
}
