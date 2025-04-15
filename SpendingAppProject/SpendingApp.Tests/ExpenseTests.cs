namespace SpendingApp.Tests;

public class ExpenseTests
{
    [Fact]
    public void AddExpenseTestList()
    {
        var expense = new Expense(50, "Food", "Monday");

        ExpenseDataStore.AddExpense(expense);
        var allExpenses = ExpenseDataStore.GetAllExpenses();

        Assert.Single(allExpenses);
        Assert.Equal(50, allExpenses[0].Total);
        Assert.Equal("Food", allExpenses[0].Type);
        Assert.Equal("Monday", allExpenses[0].Day);
    }

    [Fact]
    public void GetAllExpenses()
    {
        ExpenseDataStore.ClearExpenses();
        var e1 = new Expense(20, "Transport", "Tuesday");
        var e2 = new Expense(35, "Groceries", "Wednesday");

        ExpenseDataStore.AddExpense(e1);
        ExpenseDataStore.AddExpense(e2);
        var allExpenses = ExpenseDataStore.GetAllExpenses();

        Assert.Equal(2, allExpenses.Count);
        Assert.Contains(allExpenses, e => e.Type == "Transport" && e.Total == 20);
        Assert.Contains(allExpenses, e => e.Type == "Groceries" && e.Total == 35);
    }

}