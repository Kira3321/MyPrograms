namespace Practice.TemplatesOOP.Generative;

public interface ICall
{
    void Calling();
}

public class MobilePhone: ICall
{
    public void Calling() => Console.WriteLine("Звоним через мобильный");
}

public class Telephone : ICall
{
    public void Calling() => Console.WriteLine("Звоним со стационарного телефона");
}

public abstract class PhoneCreator
{
    public abstract ICall FactoryMethod();
}

public class MobilephoneCreator : PhoneCreator
{
    public override ICall FactoryMethod() => new MobilePhone();
}

public class TelephoneCreator : PhoneCreator
{
    public override ICall FactoryMethod() => new Telephone();
}

public class Client
{
    private ICall _phone;

    public Client(ICall phone)
    {
        _phone = phone;
    }

    public void Call() => _phone.Calling();
}