namespace Geca.Services;

public class LoggingService : ILoggingService
{
    private readonly string _logFilePath;

    public LoggingService()
    {
        _logFilePath = Path.Combine(Directory.GetCurrentDirectory(), $"Geca_{DateTime.Now:yyyy_MM_dd}.txt");
        InitializeLogFile();
    }

    private void InitializeLogFile()
    {
        if (!File.Exists(_logFilePath))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(_logFilePath))
            {
                sw.WriteLine("Initializing Geca logs");
            }	
        }
    }

    public void LogCommand(string? command)
    {
        using (StreamWriter sw = File.AppendText(_logFilePath))
        {
            sw.WriteLine($"{DateTime.Now:HH:mm:ss} Command: {command}");
        }	
    }
    
    
}
