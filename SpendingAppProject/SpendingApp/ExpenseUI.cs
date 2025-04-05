namespace SpendingApp;

public class ExpenseUI {

    public void Show() {
        int expenseDollarInt = 0;
        string expenseType = "";
        string expenseDay = "";

        while (true)
        {
            string expenseDollar = UserInputHelper.AskForInput("Now please enter an expense rounded to the nearest dollar.");

            if (int.TryParse(expenseDollar, out expenseDollarInt) && expenseDollarInt >= 0) {
                //Expense function
                break;
            } else {
                Console.WriteLine("Please try again and enter a valid whole number.");
                //Restart menu
            } 
        }

        while (true)
        {
            expenseType = UserInputHelper.AskForInput("Now enter type of expense, such as shopping.");

            if(true) {
                //Expense function
                break;
            } else {
                Console.WriteLine("Invalid option please try again.");
                //Restart menu
            } 
        }

        while (true)
        {
            expenseDay = UserInputHelper.AskForInput("Now finally enter a day of the week, like Tuesday.");
            if(expenseDay == "Monday" || expenseDay == "Tuesday" || expenseDay == "Wednesday" || 
            expenseDay == "Thursday" || expenseDay == "Friday" || expenseDay == "Saturday" || 
            expenseDay == "Sunday") {
                Console.WriteLine("Successfully added expense to your data!");
                //Expense function
                break;
            } else {
                Console.WriteLine("Please enter a valid day of the week.");
                //Restart menu
            } 
        }

        Expense newExpense = new Expense(expenseDollarInt, expenseType, expenseDay);
        ExpenseDataStore.AddExpense(newExpense);
        Console.WriteLine($"You spent ${newExpense.Total} on {newExpense.Type} on {newExpense.Day}. Data collected!");

        ConsoleUI theUI = new ConsoleUI();
        theUI.Show();
    }
}