class BankAccount: IFinacialAsset{

    protected double balance; 
    string id;
    ILogger logger; 

    public BankAccount(string id, ILogger logger){
        balance = 0;
        this.id = id;
    }

    public virtual void Deposit(double amount){
        balance += amount;
    }

    public virtual void Withdraw(double amount){
        balance -= amount;
    }

    public virtual double GetBalance(){
        return balance;
    }

    public double IFinacialAsset.GetValue(){
        return balance;
    }
}



