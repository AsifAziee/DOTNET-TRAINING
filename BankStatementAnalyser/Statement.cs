class Statement
{
    private readonly List<BankTransaction> _bankTransactions;

    public Statement()
    {
        _bankTransactions = new List<BankTransaction>();
    }

    public void AddStatement(BankTransaction transaction)
    {
        _bankTransactions.Add(transaction);
    }

    public double GetBalance()
    {
        double balance = 0.0;
        foreach(var item in _bankTransactions)
        {
            if(item.Balance > 0)
            balance = balance + item.Balance;
        }
        return balance;
    }
    public double GetBalanceOn(DateOnly startMonth, DateOnly endMonth)
    {
        double monthbalance = 0.0;
        foreach (var item in _bankTransactions)
        {
            if (item.Date >= startMonth && item.Date<= endMonth)
            {
                if(item.Balance > 0)
                {
                    monthbalance = monthbalance + item.Balance;
                }
            }
        }
        return monthbalance;
    }

    public void PrintBalance()
    {
        foreach(var item in _bankTransactions)
        {
            Console.WriteLine(item);
        }

    }
}