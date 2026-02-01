using System;

public enum LogLevel
{
    Error,
    Warning,
    Info
}

public static class Logger
{
    public static void Log(string message, LogLevel level)
    {
        Console.WriteLine($"{level.ToString().ToUpper()}: {message}");
    }
}

public static class AppConfig
{
    public static string ConnectionString =
        "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
}

public class DatabaseService
{
    public void Connect()
    {
        string connectionString = AppConfig.ConnectionString;
    }
}

public class LoggingService
{
    public void Log(string message)
    {
        string connectionString = AppConfig.ConnectionString;
    }
}
