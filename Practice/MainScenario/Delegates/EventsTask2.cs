namespace Practice.MainScenario.Delegates;

public class Stock
{
    private int _price;

    public delegate void Notify();

    public event Notify PriceChanged;

    public int Price
    {
        get => _price;
        set
        {
            _price = value;
            PriceChanged();
        }
    }

    public void UpdatePrice() => Price = new Random().Next(100);
}

public class StockDisplay
{
    public int Price { get; set; }
    private Stock _stock;

    public StockDisplay(Stock stock)
    {
        _stock = stock;
        _stock.PriceChanged += Display;
    }

    private void Display()
    {
        Price = _stock.Price;
        Console.WriteLine(Price);
    }
}

/*Тестовые данные*/
/*Stock stock = new Stock();
StockDisplay stockDisplay = new StockDisplay(stock);

for (int i = 0; i < 10; i++)
{
    stock.UpdatePrice();
}*/