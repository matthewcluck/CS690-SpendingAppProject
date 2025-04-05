namespace SpendingApp;

public class Balance {
    public int Total { get; set; }

    public Balance(int total) {
        Total = total;
    }

    public void AddExpense(int expenseTotal) {
        Total -= expenseTotal;
    }

    public void AddIncome(int incomeTotal)
    {
        Total += incomeTotal;
    }

}

public class Expense {
    public int Total { get; }
    public string Type { get; }
    public string Day { get; }

    public Expense(int total, string type, string day) {
        Total = total;
        Type = type;
        Day = day;
    }
}

public class Income {
    public int Total { get; }
    public string Source { get; }
    public string Day { get; }

    public Income(int total, string source, string day) {
        Total = total;
        Source = source;
        Day = day;
    }
}