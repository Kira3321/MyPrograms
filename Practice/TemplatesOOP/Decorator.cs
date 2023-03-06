namespace Practice.TemplatesOOP;

public interface IPizza
{
    string GetDescription();
    int GetCost();
}

public class Pizza: IPizza
{
    public string GetDescription() => "Пицца";

    public int GetCost() => 100;
}

public abstract class PizzaDecorator: IPizza
{
    protected IPizza Pizza;

    protected PizzaDecorator(IPizza pizza)
    {
        Pizza = pizza;
    }

    public abstract string GetDescription();
    public abstract int GetCost();
}

public class PizzaMargarita: PizzaDecorator
{
    public PizzaMargarita(IPizza pizza) : base(pizza) { }

    public override string GetDescription() =>  Pizza.GetDescription() + " с кетцупом, пармезаном, и томатами";

    public override int GetCost() => Pizza.GetCost() + 30;
}

public class PizzaHumMushrooms : PizzaDecorator
{
    public PizzaHumMushrooms(IPizza pizza) : base(pizza) {}

    public override string GetDescription() => Pizza.GetDescription() + " с ветчиной и грибами";

    public override int GetCost() => Pizza.GetCost() + 50;
}

public class Chef
{
    private IPizza _pizza;
    
    public Chef(IPizza pizza)
    {
        _pizza = pizza;
    }

    public IPizza DoMargarita() => new PizzaMargarita(_pizza);
}