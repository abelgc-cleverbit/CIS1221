# use py to interactively run this file
# use exec(open("memory.py").read()) to dynamically load defintions in this file or directly run 'py -i .\typing.py'

# try also examples like: 
# >>> sys.getsizeof(0)
# >>> sys.getsizeof(1)
# >>> sys.getsizeof(2 ** 30 - 1)
# >>> sys.getsizeof(2 ** 30)
# >>> sys.getsizeof(2 ** 60 - 1)
# >>> sys.getsizeof(2 ** 60)

import sys

def main():
    n = 9001
    print(f"Initial address of n: {id(n)}")
    increment(n)
    print(f"  Final address of n: {id(n)}")

def increment(x):
    print(f"Initial address of x: {id(x)}")
    x += 1
    print(f"  Final address of x: {id(x)}")

def sizechecker():
    print(sys.getsizeof([1,2, 3]))
    print(sys.getsizeof(30))
    print(sys.getsizeof(30000000000000))
