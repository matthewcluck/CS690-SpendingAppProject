namespace SpendingApp.Tests;

public class BalanceTests
{
    [Fact]
    public void AddIncomeTest()
    {
        var balance = new Balance(100);
        balance.AddIncome(50);

        Assert.Equal(150, balance.Total);
    }

    [Fact]
    public void AddExpenseTest()
    {
        var balance = new Balance(100);
        balance.AddExpense(50);

        Assert.Equal(50, balance.Total);
    }
}