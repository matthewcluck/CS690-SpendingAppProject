namespace SpendingApp;

public class IncomeUI {

    public void Show() {
        int incomeDollarInt = 0;
        string incomeSource = "";
        string incomeDay = "";

        while (true)
        {
            string incomeDollar = UserInputHelper.AskForInput("Now please enter an income rounded to the nearest dollar.");

            if (int.TryParse(incomeDollar, out incomeDollarInt) && incomeDollarInt >= 0) {
                //Income function
                break;
            } else {
                Console.WriteLine("Please try again and enter a valid whole number.");
                //Restart menu
            } 
        }

        while (true)
        {
            incomeSource = UserInputHelper.AskForInput("Now enter type of income, such as shopping.");

            if(true) {
                //Income function
                break;
            } else {
                Console.WriteLine("Invalid option please try again.");
                //Restart menu
            } 
        }

        while (true)
        {
            incomeDay = UserInputHelper.AskForInput("Now finally enter a day of the week, like Tuesday.");
            if(incomeDay == "Monday" || incomeDay == "Tuesday" || incomeDay == "Wednesday" || 
            incomeDay == "Thursday" || incomeDay == "Friday" || incomeDay == "Saturday" || 
            incomeDay == "Sunday") {
                Console.WriteLine("Successfully added income to your data!");
                //Income function
                break;
            } else {
                Console.WriteLine("Please enter a valid day of the week.");
                //Restart menu
            } 
        }

        Income newIncome = new Income(incomeDollarInt, incomeSource, incomeDay);
        IncomeDataStore.AddIncome(newIncome);
        Console.WriteLine($"You spent ${newIncome.Total} on {newIncome.Source} on {newIncome.Day}. Data collected!");

        ConsoleUI theUI = new ConsoleUI();
        theUI.Show();
    }
}