namespace Practice;

public class Logger
{
    private static Logger _instance;
    
    private Logger() { }

    public static Logger GetInstance()
    {
        if (_instance is Logger) return _instance;
        _instance = new Logger();
        return _instance;
    }
    
    public void Log(string toLog) => Console.WriteLine(toLog);
}