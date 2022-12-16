# use py to interactively run this file
# use exec(open("Expressions.py").read()) to dynamically load defintions in this file or directly run 'py -i .\typing.py'


from abc import (ABC, abstractmethod)

class Expression(ABC):
    @abstractmethod
    def evaluate():
        ...

class ConstantExpression(Expression):
    def __init__(self, val):
        self.val = val

    def evaluate(self):
        return self.val

class SumExpression(Expression):
    def __init__(self, exp1, exp2):
        self.exp1 = exp1
        self.exp2 = exp2

    def evaluate(self):
        return self.exp1.evaluate() + self.exp2.evaluate()


# 2 + 2
(SumExpression(ConstantExpression(2),ConstantExpression(2))).evaluate()