namespace Practice.TemplatesOOP.Structural;

public interface IPizza
{
    string GetDescription();
    int GetCost();
}

public class Pizza : IPizza
{
    public string GetDescription()
    {
        return "Пицца";
    }

    public int GetCost()
    {
        return 100;
    }
}

public abstract class PizzaDecorator : IPizza
{
    protected IPizza Pizza;

    protected PizzaDecorator(IPizza pizza)
    {
        Pizza = pizza;
    }

    public abstract string GetDescription();
    public abstract int GetCost();
}

public class PizzaMargarita : PizzaDecorator
{
    public PizzaMargarita(IPizza pizza) : base(pizza)
    {
    }

    public override string GetDescription()
    {
        return Pizza.GetDescription() + " с кетцупом, пармезаном, и томатами";
    }

    public override int GetCost()
    {
        return Pizza.GetCost() + 30;
    }
}

public class PizzaHumMushrooms : PizzaDecorator
{
    public PizzaHumMushrooms(IPizza pizza) : base(pizza)
    {
    }

    public override string GetDescription()
    {
        return Pizza.GetDescription() + " с ветчиной и грибами";
    }

    public override int GetCost()
    {
        return Pizza.GetCost() + 50;
    }
}

public class Chef
{
    private readonly IPizza _pizza;

    public Chef(IPizza pizza)
    {
        _pizza = pizza;
    }

    public IPizza DoMargarita()
    {
        return new PizzaMargarita(_pizza);
    }
}