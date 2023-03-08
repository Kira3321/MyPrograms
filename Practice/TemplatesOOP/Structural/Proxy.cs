namespace Practice.TemplatesOOP.Structural;

public class Data
{
    public int Id { get; set; }

    public string Information { get; set; }
}

public class Dbset<T> : IDisposable
{
    public List<T> Base = new();

    public void Dispose()
    {
        Console.WriteLine("Уничтожили объект Dbset");
    }
}

public interface IDatabase : IDisposable
{
    Data? ReadData(int id);
    void WriteData(Data data);
}

public class DataBase : IDatabase
{
    private readonly Dbset<Data> _store;

    public DataBase()
    {
        _store = new Dbset<Data>();
    }

    public Data? ReadData(int id)
    {
        return _store.Base.FirstOrDefault(x => x.Id == id);
    }

    public void WriteData(Data data)
    {
        _store.Base.Add(data);
    }

    public void Dispose()
    {
        _store.Dispose();
    }
}

public class ProxyDataBase : IDatabase
{
    private readonly List<Data> _datas;
    private DataBase? _store;

    public ProxyDataBase()
    {
        _datas = new List<Data>();
    }

    public Data? ReadData(int id)
    {
        var date = _datas.FirstOrDefault(x => x.Id == id);
        if (date != null) return date;
        if (_store == null) _store = new DataBase();
        date = _store.ReadData(id);
        _datas.Add(date);
        return date;
    }

    public void WriteData(Data data)
    {
        if (_datas.Contains(data)) return;
        var store = _store ?? new DataBase();
        store.WriteData(data);
    }

    public void Dispose()
    {
        _store.Dispose();
    }
}