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
import gc

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
    print(f"Size of list [1, 2, 3]: {sys.getsizeof([1, 2, 3])} bytes")
    print(f"Size of integer 30: {sys.getsizeof(30)} bytes")
    print(f"Size of large integer 30000000000000: {sys.getsizeof(30000000000000)} bytes")

def reference_counting():
    a = []
    print(f"Initial reference count of a: {sys.getrefcount(a)}")
    b = a
    print(f"Reference count of a after assigning b = a: {sys.getrefcount(a)}")
    del b
    print(f"Reference count of a after deleting b: {sys.getrefcount(a)}")

def garbage_collection():
    class MyClass:
        def __del__(self):
            print("MyClass instance is being deleted")

    obj = MyClass()
    print(f"Object created: {obj}")
    del obj
    gc.collect()  # Force garbage collection

# Run all examples
# main()
# sizechecker()
# reference_counting()
# garbage_collection()
