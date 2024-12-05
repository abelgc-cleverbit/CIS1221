// use csi to interactively run this file
// use #load "stack.csx" to dynamically load definitions in this file

using System;
using System.Diagnostics;

// Function to calculate factorial iteratively
int FactorialIterative(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

// Function to calculate factorial recursively
int FactorialRecursive(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * FactorialRecursive(n - 1);
    }
}

// Function to display memory usage
void DisplayMemoryUsage()
{
    Process currentProcess = Process.GetCurrentProcess();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Memory Usage: {currentProcess.PrivateMemorySize64 / 1024:N0} KB");
    Console.ResetColor();
}

// Function to display the call stack
void DisplayCallStack()
{
    StackTrace stackTrace = new StackTrace(true);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Call Stack:");
    foreach (StackFrame frame in stackTrace.GetFrames())
    {
        Console.WriteLine($"  Method: {frame.GetMethod()}, Line: {frame.GetFileLineNumber()}");
    }
    Console.ResetColor();
}

// Main function to demonstrate factorial calculations
void Main()
{
    int n = 5;

    // Iterative factorial calculation
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Calculating factorial of {n} iteratively:");
    Console.ResetColor();
    DisplayMemoryUsage();
    int iterativeResult = FactorialIterative(n);
    Console.WriteLine($"FactorialIterative({n}) = {iterativeResult}");
    DisplayMemoryUsage();
    DisplayCallStack();

    // Recursive factorial calculation
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\nCalculating factorial of {n} recursively:");
    Console.ResetColor();
    DisplayMemoryUsage();
    int recursiveResult = FactorialRecursive(n);
    Console.WriteLine($"FactorialRecursive({n}) = {recursiveResult}");
    DisplayMemoryUsage();
    DisplayCallStack();
}

// Run the main function
Main();