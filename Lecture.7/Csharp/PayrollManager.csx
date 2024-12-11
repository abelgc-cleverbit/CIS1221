// FILE: PAYROLLMANAGER.CSX
// This script demonstrates a simple payroll management system in C#.
// To run this file interactively using C# Interactive (csi), follow these steps:
// 1. Open a terminal.
// 2. Navigate to the directory containing this file.
// 3. Run the C# Interactive shell by typing `csi`.
// 4. Load this file using `#load "PayrollManager.csx"`.
// 5. Create instances of the classes and call their methods to see the results.


using System;
using System.Collections.Generic;

class Employee
{
    private double wage;
    private BankAccount bankAccount;

    public Employee(double wage, BankAccount bankAccount)
    {
        this.wage = wage;
        this.bankAccount = bankAccount;
    }

    public double GetWage()
    {
        return wage;
    }

    protected BankAccount GetBankAccount()
    {
        return bankAccount;
    }

    public void AddWage(double wage){

        //Add any validation, etc. 
        bankAccount.Deposit(value);
    }
}



class PayrollManager
{
    List<Employee> employees;
    BankAccount companyAccount;

    // Constructor to initialize the PayrollManager with a list of employees and the company's bank account
    public PayrollManager(List<Employee> employees, BankAccount companyAccount)
    {
        this.employees = employees;
        this.companyAccount = companyAccount;
    }

    // Method to pay wages to all employees
    public void PayWages()
    {
        foreach (var e in employees)
        {
            // Get the wage of the employee
            double valueToTransfer = e.GetWage();

            // Withdraw the wage amount from the company's bank account
            companyAccount.Withdraw(valueToTransfer);

            // Deposit the wage amount into the employee's bank account
            //e.GetBankAccount().Deposit(valueToTransfer);
            e.AddWage(valueToTransfer);

            //e.GetBankAccount().Withdraw(100)

            // Optional: If you need to withdraw the amount immediately after depositing, which is unusual
            // e.GetBankAccount().Withdraw(valueToTransfer);
        }
    }
}