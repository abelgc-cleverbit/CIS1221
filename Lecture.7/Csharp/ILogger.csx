// FILE: ILOGGER.CSX
// This script defines an ILogger interface and demonstrates a basic console logger implementation in C#.
// To run this file interactively using C# Interactive (csi), follow these steps:
// 1. Open a terminal.
// 2. Navigate to the directory containing this file.
// 3. Run the C# Interactive shell by typing `csi`.
// 4. Load this file using `#load "ILogger.csx"`.
// 5. Create instances of the classes and call their methods to see the results.

using System;

interface ILogger
{
    void LogMessage(string message);
    void LogException(string message, Exception e);
}

// Basic console logger implementation of ILogger
public class ConsoleLogger : ILogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }

    public void LogException(string message, Exception e)
    {
        Console.WriteLine($"Exception: {message}, Exception Details: {e.Message}");
    }
}

// Example usage:
// var logger = new ConsoleLogger();
// logger.LogMessage("This is a log message.");
// logger.LogException("This is an exception message.", new Exception("Example exception"));