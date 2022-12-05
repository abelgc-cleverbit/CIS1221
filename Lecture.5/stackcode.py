# use py to interactively run this file
# use exec(open("stackcode.py").read()) to dynamically load defintions in this file or directly run 'py -i .\typing.py'

def f(x, y):
    return x + y

def g():
    x = 1
    y = 2
    z = f(x, y)

import dis
dis.dis(g)