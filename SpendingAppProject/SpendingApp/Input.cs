namespace SpendingApp;

public static class UserInputHelper {
    public static string AskForInput(string message) {
        Console.Write(message);
        return Console.ReadLine();
    }
}
