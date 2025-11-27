
public class Program
{
    public static void Main(string[] args)
    {
        // Create account object
        
        BankAccount acc = new BankAccount("ACC12345", 1000);
        

        Console.WriteLine("=== Bank Account Info ===");
        Console.WriteLine($"Account Number: {acc.AccountNumber}");
        Console.WriteLine($"Initial Balance: {acc.Balance}");

        // Deposit some amount
        acc.Deposit(500);

        // Withdraw some amount
        acc.Withdraw(300);

        // Display final balance
        Console.WriteLine($"Remaining Balance: {acc.Balance}");
    }
}