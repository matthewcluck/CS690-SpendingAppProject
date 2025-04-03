namespace SpendingApp;

public class ConsoleUI {
    public ConsoleUI() {
    }

    public void Show() {

        while (true)
        {
            string mode = UserInputHelper.AskForInput("You may now choose from the following options: (1) Enter Expense, (2) Enter Income, (3) View Data Tracker, (4) View Balance, (5) Exit.");

            if(mode=="1") {
                ExpenseUI theExpenseUI = new ExpenseUI();
                theExpenseUI.Show();
                break;
            } else if(mode=="2") {
                Console.WriteLine("2");
                //Income function
                break;
            } else if(mode=="3") {
                Console.WriteLine("3");
                //Data tracker function
                break;
            } else if(mode=="4") {
                Console.WriteLine("4");
                //Balance function
                break;
            } else if(mode=="5") {
                Console.WriteLine("5");
                //End application function
                return;
            } else {
                Console.WriteLine("Invalid option please enter a number.");
                //Restart menu
            } 
        }
    }
}