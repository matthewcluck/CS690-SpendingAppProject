namespace SpendingApp
{
    public class ExpenseUI
    {
        private Balance balance;


        public ExpenseUI(Balance balance)
        {
            this.balance = balance;
        }

        public void Show()
        {
            int expenseDollarInt = 0;
            string expenseType = "";
            string expenseDay = "";

            while (true)
            {
                string expenseDollar = UserInputHelper.AskForInput("Now please enter an expense rounded to the nearest dollar. ");

                if (int.TryParse(expenseDollar, out expenseDollarInt) && expenseDollarInt >= 0)
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
                expenseType = UserInputHelper.AskForInput("Now enter type of expense, such as shopping. ");

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
                expenseDay = UserInputHelper.AskForInput("Now finally enter a day of the week, like Tuesday. ");
                if (expenseDay == "Monday" || expenseDay == "Tuesday" || expenseDay == "Wednesday" ||
                    expenseDay == "Thursday" || expenseDay == "Friday" || expenseDay == "Saturday" ||
                    expenseDay == "Sunday")
                {
                    Console.WriteLine("Successfully added expense to your data!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid day of the week.");
                }
            }

            Expense newExpense = new Expense(expenseDollarInt, expenseType, expenseDay);
            ExpenseDataStore.AddExpense(newExpense);
            Console.WriteLine($"You spent ${newExpense.Total} on {newExpense.Type} on {newExpense.Day}.");

            balance.AddExpense(newExpense.Total);

            Console.WriteLine($"Your new balance is: ${balance.Total}");

            ConsoleUI theUI = new ConsoleUI(balance);
            theUI.Show();
        }
    }
}
