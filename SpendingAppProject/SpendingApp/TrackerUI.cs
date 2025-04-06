// namespace SpendingApp
// {
//     public class TrackerUI
//     {
//         private Balance balance;

//         public TrackerUI(Balance balance)
//         {
//             this.balance = balance;
//         }

//         public void Show()
//         {
//             while (true)
//             {
//                 string mode = UserInputHelper.AskForInput("You may now choose from the following options: (1) Enter Expense, (2) Enter Income, (3) View Data Tracker, (4) View Balance, (5) Exit.");

//                 if (mode == "1")
//                 {
//                     ExpenseUI theExpenseUI = new ExpenseUI(balance);  // Pass balance to ExpenseUI
//                     theExpenseUI.Show();
//                     break;
//                 }
//                 else if (mode == "2")
//                 {
//                     IncomeUI theIncomeUI = new IncomeUI(balance);  // Pass balance to IncomeUI
//                     theIncomeUI.Show();
//                     break;
//                 }
//                 else if (mode == "3")
//                 {
//                     Console.WriteLine("Data tracker function");
//                     break;
//                 }
//                 else if (mode == "4")
//                 {
//                     Console.WriteLine("Your current balance is: $" + balance.Total);  // Access balance's Total property
//                     continue;
//                 }
//                 else if (mode == "5")
//                 {
//                     Console.WriteLine("Exiting the application...");
//                     return;  // End the program
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid option, please enter a valid number.");
//                     // Restart menu if input is invalid
//                 }
//             }
//         }
//     }
// }
