namespace SpendingApp
{
    public static class TrackerFunctions
    {
        public static void PrintExpenseList()
        {
            var expenses = ExpenseDataStore.GetAllExpenses();

            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses recorded.");
                return;
            }

            Console.WriteLine("Expense List:");
            Console.WriteLine("----------------------------------");
            foreach (var expense in expenses)
            {
                Console.WriteLine($"Type: {expense.Type}, Total: ${expense.Total}, Day: {expense.Day}");
            }
            Console.WriteLine("----------------------------------");
        }

        public static void ViewExpensesByDay()
        {
            var expenses = ExpenseDataStore.GetAllExpenses();

            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses recorded.");
                return;
            }

            var grouped = expenses.GroupBy(e => e.Day);

            Console.WriteLine("Expenses by Day:");
            Console.WriteLine("----------------------------------");
            foreach (var group in grouped)
            {
                Console.WriteLine($"Day: {group.Key}");

                int dayTotal = 0;
                foreach (var expense in group)
                {
                    Console.WriteLine($"  - {expense.Type}: ${expense.Total}");
                    dayTotal += expense.Total;
                }

                Console.WriteLine($"  Total for {group.Key}: ${dayTotal}\n");
            }
            Console.WriteLine("----------------------------------");
        }

        public static void ViewExpensesByType()
        {
            var expenses = ExpenseDataStore.GetAllExpenses();

            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses recorded.");
                return;
            }

            var grouped = expenses.GroupBy(e => e.Type);

            Console.WriteLine("Expenses by Type:");
            Console.WriteLine("----------------------------------");
            foreach (var group in grouped)
            {
                int total = group.Sum(e => e.Total);
                Console.WriteLine($"{group.Key}: ${total}");
            }
            Console.WriteLine("----------------------------------");
        }

        public static void ViewIncomeByDay()
        {
            var incomes = IncomeDataStore.GetAllIncomes();

            if (incomes.Count == 0)
            {
                Console.WriteLine("No income recorded.");
                return;
            }

            var grouped = incomes.GroupBy(i => i.Day);

            Console.WriteLine("Income by Day:");
            Console.WriteLine("----------------------------------");
            foreach (var group in grouped)
            {
                Console.WriteLine($"Day: {group.Key}");

                int total = 0;
                foreach (var income in group)
                {
                    Console.WriteLine($"  - Source: {income.Source}, Amount: ${income.Total}");
                    total += income.Total;
                }

                Console.WriteLine($"  Total for {group.Key}: ${total}\n");
            }
            Console.WriteLine("----------------------------------");
        }

        public static void ViewIncomeBySource()
        {
            var incomes = IncomeDataStore.GetAllIncomes();

            if (incomes.Count == 0)
            {
                Console.WriteLine("No income recorded.");
                return;
            }

            var grouped = incomes.GroupBy(i => i.Source);

            Console.WriteLine("Income by Source:");
            Console.WriteLine("----------------------------------");
            foreach (var group in grouped)
            {
                int total = group.Sum(i => i.Total);
                Console.WriteLine($"{group.Key}: ${total}");
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
