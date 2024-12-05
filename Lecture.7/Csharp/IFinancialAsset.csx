// FILE: IFINANCIALASSET.CSX
// This script defines an IFinancialAsset interface in C#.
// To run this file interactively using C# Interactive (csi), follow these steps:
// 1. Open a terminal.
// 2. Navigate to the directory containing this file.
// 3. Run the C# Interactive shell by typing `csi`.
// 4. Load this file using `#load "IFinancialAsset.csx"`.
// 5. Create instances of the classes and call their methods to see the results.

public interface IFinancialAsset
{
    double GetValue();
}

// Possible implementations of financial assets:
// 1. BankAccount: Represents a bank account with a balance.
// 2. Stock: Represents a stock with a certain number of shares and price per share.
// 3. Bond: Represents a bond with a face value and interest rate.
// 4. RealEstate: Represents a real estate property with a market value.
// 5. MutualFund: Represents a mutual fund with a net asset value (NAV).

// Example usage:
// var bankAccount = new BankAccount("12345", new ConsoleLogger());
// bankAccount.Deposit(1000);
// Console.WriteLine(bankAccount.GetValue()); // Should print the balance of the bank account