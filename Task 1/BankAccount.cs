namespace Task_1;

public class BankAccount
{
    private string accountNumber;
    private double balance;

    // Constructor to set account number
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;

        if (initialBalance > 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    // Account number - only get
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Balance - get only, set private
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
                balance = value;
        }
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
            return;
        }

        Balance = Balance + amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than 0.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        Balance = Balance - amount;
        Console.WriteLine($"Withdrawn: {amount}");
    }
}