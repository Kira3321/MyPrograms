namespace Practice.MainScenario.Threads.Tasks;

public class TaskResult
{
    public  static async Task<int> CalculateFactorialAsync(int num)
    {
        if (num == 0 || num == 1) return num;
        return await Task.Run(() => CalculateFactorialAsync(num - 1)) + await Task.Run(() => CalculateFactorialAsync(num - 2));
    }
}