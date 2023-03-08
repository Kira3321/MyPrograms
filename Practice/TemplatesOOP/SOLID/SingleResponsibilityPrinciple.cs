using System.Diagnostics;

namespace Practice.TemplatesOOP.SOLID;

public class OnlineShop
{
    public IGoodCheck GoodCheck { get; set; }
    public IPaymentAcceptance Acceptance { get; set; }
    public IStatusNotify Notify { get; set; }

    public void Process(Good good, int money)
    {
        if (GoodCheck.Check(good) == -1) Console.WriteLine("Нет товара");
        Notify.Notify(Acceptance.Acceptance(good, money));
    }
}

public class Good
{
    public int Coast { get; set; }
}

public class Store
{
    public List<Good> Storage { get; set; }
}

public interface IGoodCheck
{
    int Check(Good good);
}

public class StoreGoodCheck : IGoodCheck
{
    private readonly Store _store;

    public StoreGoodCheck(Store store)
    {
        _store = store;
    }

    public int Check(Good good)
    {
        if (_store.Storage.Contains(good)) return _store.Storage.IndexOf(good);
        return -1;
    }
}

public interface IPaymentAcceptance
{
    PaymentStatus Acceptance(Good good, int money);
}

public class OnlinePaymentAcceptance : IPaymentAcceptance
{
    public PaymentStatus Acceptance(Good good, int money)
    {
        return good.Coast <= money ? PaymentStatus.Accept : PaymentStatus.Decline;
    }
}

public enum PaymentStatus
{
    Accept,
    Decline
}

public interface IStatusNotify
{
    void Notify(PaymentStatus status);
}

public class ConsoleNotify : IStatusNotify
{
    public void Notify(PaymentStatus status)
    {
        if (status == PaymentStatus.Accept) Console.WriteLine("Платёж принят");
        if (status == PaymentStatus.Decline) Console.WriteLine("Платёж отклонён");
    }
}