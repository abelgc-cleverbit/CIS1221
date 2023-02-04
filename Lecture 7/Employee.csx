class Employee{
    double wage;
    strign name; 
    BankAccount ba;

    //open closed principle
    public double GetWage()
    {
        return wage;
    }

    public BankAccount GetBankAccount()
    {
        return ba;
    }
}