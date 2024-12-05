# FILE: BANKACCOUNT.PY
# This script defines a basic bank account system with a savings account that earns interest.
# To run this file interactively, you can use the following steps:
# 1. Open a terminal.
# 2. Navigate to the directory containing this file.
# 3. Run the Python interactive shell by typing `python` or `python3`.
# 4. Import the classes defined in this file using `from BANKACCOUNT import BankAccount, SavingsBankAccount`.
# 5. Create instances of the classes and call their methods to see the results.
# 6. use python -i to interactively run this file
# 7. use exec(open("operators.py").read()) to dynamically load defintions in this file or directly run 'py -i .\BankAccount.py'


from abc import (ABC, abstractmethod)

class BankAccount(ABC):
    def __init__(self, id):
        """
        Initialize a bank account with a unique ID and an initial amount of 0.
        """
        self.id = id
        self.amount = 0

    def deposit(self, amount):
        """
        Deposit a specified amount into the bank account.
        """
        self.amount += amount

    @abstractmethod
    def save(self, amount):
        """
        Abstract method to be implemented by subclasses for saving a specified amount.
        """
        pass

class SavingsBankAccount(BankAccount):
    def __init__(self, percent, id):
        """
        Initialize a savings bank account with a unique ID and an interest rate percentage.
        """
        self.percent = percent
        super().__init__(id)

    def deposit(self, amount):
        """
        Deposit a specified amount into the savings account and save a portion of it based on the interest rate.
        """
        super().deposit(amount)
        self.save(amount * self.percent)

    def save(self, amount):
        """
        Save a specified amount by adding it to the account balance.
        """
        self.amount += amount

# Example usage:
# account = SavingsBankAccount(0.05, '12345')
# account.deposit(100)
# print(account.amount)  # Output should be 105.0
