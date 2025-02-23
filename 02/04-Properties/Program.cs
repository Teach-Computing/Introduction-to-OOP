using System;

class BankAccount
{
    // Automatic Property: No explicit backing field
    public string AccountHolder { get; set; }

    // Read-Only Property: Set only once at object creation
    public DateTime CreatedOn { get; } = DateTime.Now;

    // Private setter: Can only be set inside the class
    public string AccountNumber { get; private set; }

    // Backing field for a Manual Property
    private decimal _balance;

    // Manual Property: Includes validation logic
    public decimal Balance
    {
        get { return _balance; }
        private set // Prevents external modification
        {
            if (value >= 0) _balance = value;
        }
    }

    // Write-Only Property: Stores but does not expose the value
    private string _password;
    public string Password
    {
        set { _password = value; } // Can only be written, not read
    }

    // Expression-Bodied Read-Only Property
    public string AccountInfo => $"{AccountHolder} - {AccountNumber} (Balance: {Balance:C})";

    // Constructor: Initializes values
    public BankAccount(string accountHolder, string accountNumber, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        AccountNumber = accountNumber;
        Balance = initialBalance; // Uses private setter
        TotalAccounts++; // Increment static property
    }

    // Public method to modify balance safely
    public void Deposit(decimal amount)
    {
        if (amount > 0) Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance) Balance -= amount;
        else Console.WriteLine("Insufficient funds or invalid amount.");
    }
}

// Testing the implementation
class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("John Doe", "123456", 1000);
        acc1.Password = "SecurePass123"; // Write-only property, cannot be read

        Console.WriteLine($"Account Created: {acc1.CreatedOn}");
        Console.WriteLine(acc1.AccountInfo);

        acc1.Deposit(500);
        Console.WriteLine("After Deposit: " + acc1.AccountInfo);

        acc1.Withdraw(300);
        Console.WriteLine("After Withdrawal: " + acc1.AccountInfo);

        Console.WriteLine($"Total Bank Accounts Created: {BankAccount.TotalAccounts}");
    }
}
