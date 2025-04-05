namespace SpendingApp;

public static class IncomeDataStore
{
    private static List<Income> incomes = new List<Income>();

    public static void AddIncome(Income income)
    {
        incomes.Add(income);
    }

    public static List<Income> GetAllIncomes()
    {
        return new List<Income>(incomes);
    }

    public static void ClearIncomes()
    {
        incomes.Clear();
    }
}