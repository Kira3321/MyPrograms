namespace Practice.TemplatesOOP.Behavior;

public class Publisher
{
    private readonly List<Subscriber> _observers;
    private string _topic = "";

    public Publisher()
    {
        _observers = new List<Subscriber>();
    }

    public string Topic
    {
        get => _topic;
        set
        {
            _topic = value;
            Notify();
        }
    }

    public void Attach(Subscriber subscriber)
    {
        _observers.Add(subscriber);
    }

    public void Detach(Subscriber subscriber)
    {
        _observers.Remove(subscriber);
    }

    public void Notify()
    {
        foreach (var observer in _observers) observer.Update(_topic);
    }
}

public abstract class Subscriber
{
    public abstract void Update(string value);
}

public class ConsoleSubscriber : Subscriber
{
    public override void Update(string value)
    {
        Console.WriteLine($"Новая тема: {value}\nОтправленно в консоль.");
    }
}

public class EmailSubscriber : Subscriber
{
    public override void Update(string value)
    {
        Console.WriteLine($"Новая тема: {value}\nОтправленно на email.");
    }
}