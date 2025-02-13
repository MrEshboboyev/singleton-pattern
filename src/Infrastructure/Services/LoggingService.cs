using Domain.Interfaces;
using System;

namespace Infrastructure.Services;

public sealed class LoggingService : ILoggingService
{
    private static readonly Lazy<LoggingService> _instance = new(
        () => new LoggingService());

    public static LoggingService Instance => _instance.Value;

    private LoggingService() { }

    public void Log(string message)
    {
        Console.WriteLine($"[{DateTime.UtcNow}] {message}");
    }
}
