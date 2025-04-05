namespace SpendingApp;

public static class ExpenseDataStore
{
    private static List<Expense> expenses = new List<Expense>();

    public static void AddExpense(Expense expense)
    {
        expenses.Add(expense);
    }

    public static List<Expense> GetAllExpenses()
    {
        return new List<Expense>(expenses);
    }

    public static void ClearExpenses()
    {
        expenses.Clear();
    }
}