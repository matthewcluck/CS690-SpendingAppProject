namespace SpendingApp.Tests
{
    public class TrackerTests
    {
        [Fact]
        public void NoExpenseMessage()
        {
            ExpenseDataStore.ClearExpenses();

            using var sw = new StringWriter();
            Console.SetOut(sw);

            TrackerFunctions.PrintExpenseList();

            var output = sw.ToString();
            Assert.Contains("No expenses recorded.", output);
        }
    }
}
