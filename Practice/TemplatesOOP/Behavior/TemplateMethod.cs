namespace Practice.TemplatesOOP.Behavior;

public abstract class Delivery
{
    public void TemplateMethod()
    {
        Console.WriteLine(GetCost());
        Console.WriteLine(GetDeliveryType());
    }
        
    public abstract int GetCost();

    public abstract string GetDeliveryType();

    public abstract int UrgentDelivery();

    public abstract int PerCent();

    public abstract int Insurance();
}

public class AirDelivery : Delivery
{
    private int _cost;

    public AirDelivery()
    {
        _cost = 150;
    }

    public override int GetCost() => _cost;

    public override string GetDeliveryType() => this.GetType().ToString();

    public override int UrgentDelivery()
    {
        _cost += (int)(_cost * 0.25);
        return _cost;
    }

    public override int PerCent()
    {
        _cost -= (int)(_cost * 0.1);
        return _cost;
    }

    public override int Insurance()
    {
        _cost -= (int)(_cost * 0.05);
        return _cost;
    }
}

public class SeaDelivery : Delivery
{
    private int _cost;

    public SeaDelivery()
    {
        _cost = 120;
    }

    public override int GetCost() => _cost;

    public override string GetDeliveryType() => this.GetType().ToString();

    public override int UrgentDelivery()
    {
        _cost += (int)(_cost * 0.25);
        return _cost;
    }

    public override int PerCent()
    {
        _cost -= (int)(_cost * 0.1);
        return _cost;
    }

    public override int Insurance()
    {
        _cost -= (int)(_cost * 0.05);
        return _cost;
    }
}

public class GroundDelivery : Delivery
{
    private int _cost;

    public GroundDelivery()
    {
        _cost = 100;
    }

    public override int GetCost() => _cost;

    public override string GetDeliveryType() => this.GetType().ToString();

    public override int UrgentDelivery()
    {
        _cost += (int)(_cost * 0.25);
        return _cost;
    }

    public override int PerCent()
    {
        _cost -= (int)(_cost * 0.1);
        return _cost;
    }

    public override int Insurance()
    {
        _cost -= (int)(_cost * 0.05);
        return _cost;
    }
}