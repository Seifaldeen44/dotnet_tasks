
interface IPrintable
{
    void PrintDetails();
}

interface ITransactable
{
    void Deposit(double amount);
    void Withdraw(double amount);
}

abstract class Account : IPrintable, ITransactable
{
    public int AccountNumber { get; }
    public string OwnerName { get; set; }
    public double Balance { get; protected set; }

    protected Account(int accountNumber, string ownerName, double balance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = balance;
    }

    public abstract double CalculateInterest();

    public virtual void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
    }

    public virtual void PrintDetails()
    {
        Console.WriteLine(AccountNumber);
        Console.WriteLine(OwnerName);
        Console.WriteLine(Balance);
    }
}

class SavingsAccount : Account
{
    double interestRate;
    double minimumBalance;

    public SavingsAccount(int accountNumber, string ownerName, double balance, double interestRate, double minimumBalance)
        : base(accountNumber, ownerName, balance)
    {
        this.interestRate = interestRate;
        this.minimumBalance = minimumBalance;
    }

    public override double CalculateInterest()
    {
        return Balance * interestRate / 100;
    }

    public void ApplyInterest()
    {
        Balance += CalculateInterest();
    }

    public override void Withdraw(double amount)
    {
        if (Balance - amount >= minimumBalance)
            Balance -= amount;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Savings");
    }
}

class CheckingAccount : Account
{
    double overdraftLimit;

    public CheckingAccount(int accNo, string name, double balance, double overdraftLimit)
        : base(accNo, name, balance)
    {
        this.overdraftLimit = overdraftLimit;
    }

    public override double CalculateInterest()
    {
        return 0;
    }

    public override void Withdraw(double amount)
    {
        if (Balance - amount >= -overdraftLimit)
            Balance -= amount;
    }

    public override void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("Checking");
    }
}

class Program
{
    static void Main()
    {
        Account[] accounts =
        {
            new SavingsAccount(1, "Ahmed", 1000, 5, 500),
            new CheckingAccount(2, "Mohamed", 2000, 1000)
        };

        accounts[0].Deposit(500);
        ((SavingsAccount)accounts[0]).ApplyInterest();
        accounts[1].Withdraw(2500);

        foreach (Account acc in accounts)
            acc.PrintDetails();
    }
}