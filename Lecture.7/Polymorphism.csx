List<BankAccount> accounts = new List<BankAccount>();

accounts.Add(new BankAccount("My HSBC"));
accounts.Add(new SavingsBankAccount(0.03, "My HSBC Savings"))

foreach(var account in accounts)
    accounts.Deposit(100);

var total = 0.0;
foreach(var account in accounts)
    total += account.GetBalance();

Console.WriteLine(total); //??


SavingsBankAccount sba = (SavingsBankAccount)accounts[1];
Console.WriteLine(sba.GetEffectiveValue()); //??