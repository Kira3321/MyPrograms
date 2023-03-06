namespace Practice.TemplatesOOP;

public class Publisher
{
    private string _topic;
    private List<Subscriber> _observers;

    public string Topic
    {
        get => _topic;
        set
        {
            _topic = value;
            Notify();
        }
    }

    public Publisher() => _observers = new List<Subscriber>();

    public void Attach(Subscriber subscriber) => _observers.Add(subscriber);
    public void Detach(Subscriber subscriber) => _observers.Remove(subscriber);

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
    public override void Update(string value) => Console.WriteLine($"Новая тема: {value}\nОтправленно в консоль.");
}

public class  EmailSubscriber: Subscriber
{
    public override void Update(string value) => Console.WriteLine($"Новая тема: {value}\nОтправленно на email.");
}