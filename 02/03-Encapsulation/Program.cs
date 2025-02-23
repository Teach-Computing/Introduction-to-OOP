using System;


public class BankAccount
{
    // Public field for the account balance (problematic as it allows unvalidated direct access)
    public decimal balance;

    // Private field for internal validation of the balance
    private decimal accountBalance;

    // Property for account balance with validation
    public decimal AccountBalance
    {
        get { return accountBalance; }
        set
        {
            // Validation to prevent negative balance
            if (value < 0)
            {
                Console.WriteLine("Error: Account balance cannot be negative.");
            }
            else
            {
                accountBalance = value;
            }
        }
    }

    // Constructor to set initial balance
    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;  // Directly set public balance (no validation)
        AccountBalance = initialBalance;  // Use the property to validate the initial balance
    }

    // Method to deposit money into the account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;  // Directly modify the public balance (no validation here)
            AccountBalance += amount;  // Use the property to update internal account balance with validation
            Console.WriteLine($"Deposited: {amount:C}. New balance: {AccountBalance:C}");
        }
        else
        {
            Console.WriteLine("Error: Deposit amount must be positive.");
        }
    }

    // Method to withdraw money from the account
    public void Withdraw(decimal amount)
    {
        if (amount <= balance && amount > 0)
        {
            balance -= amount;  // Directly modify the public balance (no validation here)
            AccountBalance -= amount;  // Use the property to update internal account balance with validation
            Console.WriteLine($"Withdrew: {amount:C}. New balance: {AccountBalance:C}");
        }
        else
        {
            Console.WriteLine("Error: Insufficient funds or invalid withdrawal amount.");
        }
    }

    // Method to display the balance (both public and validated)
    public void DisplayBalance()
    {
        Console.WriteLine($"Public balance: {balance:C}");
        Console.WriteLine($"Validated balance: {AccountBalance:C}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a BankAccount object with an initial balance of $1000
        BankAccount account = new BankAccount(1000m);
        account.DisplayBalance();  // Output: Public balance: $1000.00, Validated balance: $1000.00

        // Depositing $500
        account.Deposit(500m);
        account.DisplayBalance();  // Output: Public balance: $1500.00, Validated balance: $1500.00

        // Withdrawing $200
        account.Withdraw(200m);
        account.DisplayBalance();  // Output: Public balance: $1300.00, Validated balance: $1300.00

        // Withdrawing $1500 (insufficient funds)
        account.Withdraw(1500m);
        account.DisplayBalance();  // Output: Error: Insufficient funds or invalid withdrawal amount.
    }
}
