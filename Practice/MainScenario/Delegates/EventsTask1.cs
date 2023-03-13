namespace Practice.MainScenario.Delegates;

public class Counter
{
    private int _count = 0;

    public int Count
    {
        get => _count;
        set
        {
            _count = value;
            CountChange();
        }
    }

    public delegate void Changed();

    /// <summary>
    /// Событие вызывается при изменении значения в свойсте Count
    /// </summary>
    public event Changed CountChange;

    public void Increment() => Count++;
    public void Decrement() => Count--;
}

public class CounterDisplay
{
    private Counter _counter;

    public int Count
    {
        get => _counter.Count;
    }

    public CounterDisplay(Counter counter)
    {
        _counter = counter;
        _counter.CountChange += Display;
    }

    private void Display() => Console.WriteLine(_counter.Count);
}


/*Тестовые данные*/
/*Counter counter = new Counter();
CounterDisplay display = new CounterDisplay(counter);

// увеличение счетчика на 3
counter.Increment();
counter.Increment();
counter.Increment();

// уменьшение счетчика на 2
counter.Decrement();
counter.Decrement();

// ожидаемое значение счетчика: 1
int expectedCount = 1;

// проверка значения счетчика в экземпляре счетчика
if (counter.Count != expectedCount)
{
    Console.WriteLine($"Error: counter count is {counter.Count}, but expected {expectedCount}");
}

// проверка значения счетчика в экземпляре дисплея
if (display.Count != expectedCount)
{
    Console.WriteLine($"Error: display count is {display.Count}, but expected {expectedCount}");
}*/