class PayrollManager
{
    List<Employee> employees;
    BankAccount companyAccount;

    //do we need a list?
    public PayrollManager(List<Employee> employees, BankAccount companyAccount)
    {
        this.employees = employees;
        this.companyAccount = companyAccount;
    }

    public void PayWages()
    {
        foreach(var e in employees){

            //is this a good idea?
            double valueToTransfer = e.GetWage(); 
            companyAccount.Withdraw(valueToTransfer);
            e.GetBankAccount.Deposit(valueToTransfer);
            e.GetBankAccount.Withdraw(valueToTransfer);
        }   
    }
}