
public class Account
{
    private double balance;   // Closed field that cannot be changed directly
    public string Name { get; }

    // Read-only
    public double Balance
    {
        get { return balance; }
    }

    public Account(string name, double initialBalance)
    {
        Name = name;

        if (initialBalance < 0)
            balance = 0;
        else
            balance = initialBalance;
    }

    // Adding money
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("The replenishment amount must be greater than zero");
            return;
        }

        balance += amount;
    }

    // Withdrawal
    public void Withdrawal(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("The withdrawal amount must be greater than zero");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds in the account...");
            return;
        }

        balance -= amount;
    }
}
