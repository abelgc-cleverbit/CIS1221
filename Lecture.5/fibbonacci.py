import time
import math

# Decorator to measure the execution time of a function
def timed(func):
    def wrapper(*args, **kwargs):
        start_time = time.time()  # Record the start time
        result = func(*args, **kwargs)  # Execute the function
        end_time = time.time()  # Record the end time
        duration = end_time - start_time  # Calculate the duration
        print(f"Function took {duration:.6f} seconds")  # Print the duration
        return result  # Return the result of the function
    return wrapper

# Decorator to memoize the results of a function
def memoized(func):
    cache = {}  # Initialize an empty cache
    def wrapper(n):
        if n not in cache:  # Check if the result is already in the cache
            cache[n] = func(n)  # If not, compute and store it in the cache
        return cache[n]  # Return the cached result
    return wrapper

# Iterative method to calculate Fibonacci number
@timed
def fibonacci_iterative(n):
    if n <= 0:
        return 0  # Return 0 for non-positive input
    elif n == 1:
        return 1  # Return 1 for input 1
    else:
        a, b = 0, 1  # Initialize the first two Fibonacci numbers
        for _ in range(2, n + 1):  # Loop from 2 to n
            a, b = b, a + b  # Update the Fibonacci numbers
        return b  # Return the nth Fibonacci number

# Recursive method to calculate Fibonacci number without memoization
def fibonacci_recursive(n):
    if n <= 0:
        return 0  # Return 0 for non-positive input
    elif n == 1:
        return 1  # Return 1 for input 1
    else:
        return fibonacci_recursive(n - 1) + fibonacci_recursive(n - 2)  # Recursive call

# Recursive method to calculate Fibonacci number with manual memoization
def fibonacci_recursive_manual_memo(n, memo=None):
    if memo is None:
        memo = {}  # Initialize the memoization dictionary
    if n in memo:
        return memo[n]  # Return the cached result if available
    if n <= 0:
        return 0  # Return 0 for non-positive input
    elif n == 1:
        return 1  # Return 1 for input 1
    else:
        memo[n] = fibonacci_recursive_manual_memo(n - 1, memo) + fibonacci_recursive_manual_memo(n - 2, memo)  # Recursive call with memoization
        return memo[n]  # Return the result and store it in the memo

# Recursive method to calculate Fibonacci number with memoization and timing
@memoized
def fibonacci_memoized(n):
    if n <= 0:
        return 0  # Return 0 for non-positive input
    elif n == 1:
        return 1  # Return 1 for input 1
    else:
        return fibonacci_memoized(n - 1) + fibonacci_memoized(n - 2)  # Recursive call

# Function to time any given function with a specific input
@timed
def timeit(fn, n):
    return fn(n)  # Call the function with the input and return the result

# Closed-form method to calculate Fibonacci number using Binet's formula
@timed
def fibonacci_closed_form(n):
    phi = (1 + math.sqrt(5)) / 2  # Golden ratio
    psi = (1 - math.sqrt(5)) / 2  # Conjugate of the golden ratio
    return int((phi**n - psi**n) / math.sqrt(5))  # Binet's formula

