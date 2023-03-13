using System.Globalization;

namespace Practice.MainScenario.Threads.Thread;

public class MyThread : IDisposable
{
    private CancellationToken _cancellationToken;

    public MyThread(CancellationToken cancellationToken)
    {
        _cancellationToken = cancellationToken;
    }

    public void Run()
    {
        while (!_cancellationToken.IsCancellationRequested)
        {
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yy hh:mm:ss:fffffzz"));
            System.Threading.Thread.Sleep(995);
        }
    }
    
    public void Run(int count)
    {
        for (int i = 0; i < count || !_cancellationToken.IsCancellationRequested; i++)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(500);
        }
    }


    public void Dispose()
    {
    }
}