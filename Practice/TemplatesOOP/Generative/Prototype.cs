namespace Practice.TemplatesOOP.Generative;

public abstract class Candy
{
    public string Name { get; private set; }

    protected Candy(string name)
    {
        Name = name;
    }

    public abstract Candy Clone();
}

public class StrawberryCandy : Candy
{
    public StrawberryCandy(string name) : base(name)
    {
    }

    public override Candy Clone() => new StrawberryCandy(Name);
}

public class IrisCandy : Candy
{
    public IrisCandy(string name) : base(name)
    {
    }

    public override Candy Clone() => new IrisCandy(Name);
}