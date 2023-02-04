interface ILogger
{
    void LogMessage(string message);
    void LogException(string message, Exception e);

}

//how to use this to make the bank account class more robust
//which implementations should we get