namespace Practice.TemplatesOOP.Generative;

public abstract class Candy
{
    protected Candy(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract Candy Clone();
}

public class StrawberryCandy : Candy
{
    public StrawberryCandy(string name) : base(name)
    {
    }

    public override Candy Clone()
    {
        return new StrawberryCandy(Name);
    }
}

public class IrisCandy : Candy
{
    public IrisCandy(string name) : base(name)
    {
    }

    public override Candy Clone()
    {
        return new IrisCandy(Name);
    }
}