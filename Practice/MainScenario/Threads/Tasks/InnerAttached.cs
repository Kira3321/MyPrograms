namespace Practice.MainScenario.Threads.Tasks;

public class Inners
{
    public static async Task Papka(string path)
    {
        var dir = new DirectoryInfo(path);
        if (!dir.Exists) return;
        var innerDirs = new List<Task>();
        foreach (var dr in dir.GetDirectories())
        {
            innerDirs.Add(Task.Factory.StartNew(() =>
            {
                Papka(dr.FullName);
                return dr.GetFiles().Length;
            }, TaskCreationOptions.AttachedToParent | TaskCreationOptions.RunContinuationsAsynchronously));
        }

        foreach (var variFile in dir.GetFiles())
        {
            Console.WriteLine($"Файл: {variFile.Name} каталога: {dir.Name}");
        }

        Task.WaitAll(innerDirs.ToArray());
    }
}