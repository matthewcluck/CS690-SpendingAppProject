namespace SpendingApp.Tests
{
    public class TrackerTests
    {
        [Fact]
        public void NoExpenseMessage_PrintsMessageWhenListIsEmpty()
        {
            ExpenseDataStore.ClearExpenses();

            using var sw = new StringWriter();
            Console.SetOut(sw);

            TrackerFunctions.PrintExpenseList();

            var output = sw.ToString();

            if (ExpenseDataStore.GetAllExpenses().Count == 0)
            {
                Assert.Contains("No expenses recorded.", output);
            }
            else
            {
                Assert.DoesNotContain("No expenses recorded.", output);
            }
        }
    }
}
