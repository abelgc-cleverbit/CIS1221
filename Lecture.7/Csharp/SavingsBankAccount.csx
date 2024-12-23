class SavingsBankAccount:BankAccount
{
        double savingsBalance; 
        double depositPercentageToSave;

    public SavingsBankAccount(string id, double depositPercentageToSave):base(id){
        savingsBalance = 0;
        this.depositPercentageToSave = depositPercentageToSave;
    }

    //internal functionality, made protected so sub-classes can also make use of this method
    protected void Save(double amount){
        balance -= amount; 
        savingsBalance += amount;
    }

    //overrides the base class default behavior
    public override void Deposit(double amount)
    {
        //it does exactly the same behavior as the base class first
        base.Deposit(amount);

        //then adds an extension to execute the savings
        Save(amount * depositPercentageToSave);
    }

    public override double GetBalance(){
        return balance + savingsBalance;
    }


    public virtual double GetSavingsBalance()
    {
        return savingsBalance;
    }

    public virtual GetEffectiveValue(){
        return balance; //is this correct
    }

}

