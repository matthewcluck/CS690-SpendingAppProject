namespace SpendingApp;

public class ExpenseUI {
    public ExpenseUI() {
    }
    public void Show() {

        while (true)
        {
            string expenseDollar = UserInputHelper.AskForInput("Now please enter an expense rounded to the nearest dollar.");
            int expenseDollarInt;

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
            string expenseType = UserInputHelper.AskForInput("Now enter type of expense, such as shopping.");

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
            string expenseDay = UserInputHelper.AskForInput("Now finally enter a day of the week, like Tuesday.");
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

        ConsoleUI theUI = new ConsoleUI();
        theUI.Show();
    }
}