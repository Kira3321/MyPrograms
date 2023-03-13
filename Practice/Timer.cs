using System.Diagnostics;

namespace Practice;

[AttributeUsage(AttributeTargets.Class)]
public class TimingAspectAttribute : Attribute
{
    public void OnEntry()
    {
        stopwatch = Stopwatch.StartNew();
    }

    public void OnExit(string className)
    {
        stopwatch.Stop();
        var elapsedTime = stopwatch.Elapsed;
        Console.WriteLine($"Class {className} executed in {elapsedTime.TotalMilliseconds} ms");
    }

    private Stopwatch stopwatch;

    public void Execute(Action method)
    {
        OnEntry();
        method();
        OnExit(method.Method.ReflectedType.Name);
    }
}