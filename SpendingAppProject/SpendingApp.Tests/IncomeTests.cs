namespace SpendingApp.Tests;

public class IncomeTests
{
    [Fact]
    public void CanCreateIncomeInstance()
    {
        var income = new Income(1000, "Job", "Tuesday");

        Assert.Equal(1000, income.Total);
        Assert.Equal("Job", income.Source);
        Assert.Equal("Tuesday", income.Day);
    }

    [Fact]
    public void IncomeDataStoreRet()
    {

        var income = new Income(500, "Freelance", "Friday");
        IncomeDataStore.AddIncome(income);

        var incomes = IncomeDataStore.GetAllIncomes();

        Assert.Single(incomes);
        Assert.Equal("Freelance", incomes[0].Source);
    }

    [Fact]
    public void Income_Update_Balance()
    {
        var balance = new Balance(1000);

        balance.AddIncome(250);

        Assert.Equal(1250, balance.Total);
    }
}