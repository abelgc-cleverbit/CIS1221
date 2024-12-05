# use py to interactively run this file
# use exec(open("stackcode.py").read()) to dynamically load defintions in this file or directly run 'py -i .\typing.py'

import dis

# Function to add two numbers
def f(x, y):
    return x + y

# Function to demonstrate a simple addition using f
def g():
    x = 1
    y = 2
    z = f(x, y)
    print(f"g: x = {x}, y = {y}, z = {z}")

# Recursive function to calculate factorial
def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n - 1)

# Function to demonstrate the factorial calculation
def h():
    n = 5
    result = factorial(n)
    print(f"factorial({n}) = {result}")

# Disassemble the bytecode of the functions
print("Disassembly of function f:")
dis.dis(f)

print("\nDisassembly of function g:")
dis.dis(g)

print("\nDisassembly of function factorial:")
dis.dis(factorial)