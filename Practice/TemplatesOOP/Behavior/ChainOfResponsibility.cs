namespace Practice.TemplatesOOP.Behavior;

public class Auto
{
    public AutoEngeene? Engeene { get; set; }
    public AutoOil? Oil { get; set; }
    public AutoBrakes? Brakes { get; set; }
    public AutoGas? Gas { get; set; }
}

public abstract class AutoEngeene
{
}

public abstract class AutoOil
{
}

public abstract class AutoBrakes
{
}

public abstract class AutoGas
{
}

public abstract class AutoCheck
{
    public AutoCheck? Checker { get; set; }
    public abstract void Check(Auto auto);
}

public class AutoEngeeneCheck : AutoCheck
{
    public override void Check(Auto auto)
    {
        if (auto.Engeene == null)
        {
            Console.WriteLine("Нет двигателя");
            return;
        }

        Console.WriteLine("Двигатель есть");
        Checker?.Check(auto);
    }
}

public class AutoOilCheck : AutoCheck
{
    public override void Check(Auto auto)
    {
        if (auto.Oil == null)
        {
            Console.WriteLine("Нет масла");
            return;
        }

        Console.WriteLine("Масло есть");
        Checker?.Check(auto);
    }
}

public class AutoBrakesCheck : AutoCheck
{
    public override void Check(Auto auto)
    {
        if (auto.Brakes == null)
        {
            Console.WriteLine("Нет тормазов");
            return;
        }

        Console.WriteLine("Тормаза есть");
        Checker?.Check(auto);
    }
}

public class AutoGasCheck : AutoCheck
{
    public override void Check(Auto auto)
    {
        if (auto.Gas == null)
        {
            Console.WriteLine("Нет топлива");
            return;
        }

        Console.WriteLine("Топливо есть");
        Checker?.Check(auto);
    }
}