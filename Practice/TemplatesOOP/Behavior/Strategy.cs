namespace Practice.TemplatesOOP.Behavior;

public interface IStrategy
{
    void Execute();
}

public class BubbleSort : IStrategy
{
    public void Execute() => Console.WriteLine("Сортировка пузырьком");
}

public class MergeSort : IStrategy
{
    public void Execute() => Console.WriteLine("Сортировка слиянием");
}

public class QuickSort : IStrategy
{
    public void Execute() => Console.WriteLine("Быстрая сортировка");
}

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy) => _strategy = strategy;
    public void Execute() => _strategy.Execute();
}