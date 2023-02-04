from abc import (ABC, abstractmethod)

class BankAccount(ABC):
    def __init__(self, id):
        self.id = id
        self.amount = 0

    def deposit(self, amount):
        self.amount += amount

class SavingsBankAccount(BankAccount):
    def __init__(self, percent, id):
        self.percent = percent
        super.__init__(id)

    def deposit(self, amount):
        super.deposit(amount)
        self.save(amount*self.percent)
