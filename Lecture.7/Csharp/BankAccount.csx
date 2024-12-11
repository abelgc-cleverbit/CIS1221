// FILE: BANKACCOUNT.CSX
// This script demonstrates a simple bank account system in C#.
// To run this file interactively using C# Interactive (csi), follow these steps:
// 1. Open a terminal.
// 2. Navigate to the directory containing this file.
// 3. Run the C# Interactive shell by typing `csi`.
// 4. Load this file using `#load "BankAccount.csx"`.
// 5. Create instances of the classes and call their methods to see the results.

using System;
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
        logger.LogMessage($"Added this amount {amount}")
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



