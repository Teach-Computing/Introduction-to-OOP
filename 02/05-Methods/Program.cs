using System;


namespace MemberMethodsDemo
{
    class BankAccount
    {
        private decimal _balance;
        public string AccountHolder { get; set; }

        // Constructor
        public BankAccount(string accountHolder, decimal initialBalance)
        {
            AccountHolder = accountHolder;
            _balance = initialBalance;
        }

        // Instance Method (Operates on Object Data)
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method Overloading (Same Name, Different Parameters)
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {_balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }

        public void Withdraw(decimal amount, string reason) // Overloaded Method
        {
            Console.WriteLine($"Processing withdrawal for: {reason}");
            Withdraw(amount); // Calls the other Withdraw method
        }

        // Static Method (Belongs to Class, Not Instance)
        public static void ShowBankPolicy()
        {
            Console.WriteLine("Minimum balance required: $100.");
        }

        // Read-Only Property using a Method (Encapsulation)
        public decimal GetBalance()
        {
            return _balance; // Returns balance safely without allowing direct modification
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an instance of BankAccount
            BankAccount myAccount = new BankAccount("John Doe", 500);

            // Calling instance methods
            myAccount.Deposit(200);
            myAccount.Withdraw(100);
            myAccount.Withdraw(50, "Shopping");

            // Displaying balance safely
            Console.WriteLine($"Current Balance: {myAccount.GetBalance():C}");

            // Calling static method
            BankAccount.ShowBankPolicy();
        }
    }
}
