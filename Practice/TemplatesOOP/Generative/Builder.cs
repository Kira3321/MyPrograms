namespace Practice.TemplatesOOP.Generative;

public class House
{
    public string Id { get; private set; }
    public int Floors { get; set; }
    public int Rooms { get; set; }
    public bool HasElevator { get; set; }
    public bool HasGarage { get; set; }
    public bool HasPool { get; set; }

    public House() => Id = Guid.NewGuid().ToString();
}

public abstract class Builder
{
    /// <summary>
    /// устанавливает количество этажей здания.
    /// </summary>
    /// <param name="floors"></param>
    public abstract void setFloors(int floors);

    /// <summary>
    /// устанавливает количество комнат на каждом этаже.
    /// </summary>
    /// <param name="rooms"></param>
    public abstract void setRooms(int rooms);

    /// <summary>
    /// устанавливает наличие лифта.
    /// </summary>
    /// <param name="hasElevator"></param>
    public abstract void setHasElevator(bool hasElevator);

    /// <summary>
    /// устанавливает наличие гаража.
    /// </summary>
    /// <param name="hasGarage"></param>
    public abstract void setHasGarage(bool hasGarage);

    /// <summary>
    /// устанавливает наличие бассейна.
    /// </summary>
    /// <param name="hasPool"></param>
    public abstract void setHasPool(bool hasPool);

    /// <summary>
    /// создает и возвращает новый объект здания с установленными свойствами.
    /// </summary>
    public abstract House build();
}

public class HouseBuilder : Builder
{
    private House _house;

    public HouseBuilder() => _house = new House();

    public override void setFloors(int floors) => _house.Floors = floors;

    public override void setRooms(int rooms) => _house.Rooms = rooms;

    public override void setHasElevator(bool hasElevator) => _house.HasElevator = hasElevator;

    public override void setHasGarage(bool hasGarage) => _house.HasGarage = hasGarage;

    public override void setHasPool(bool hasPool) => _house.HasPool = hasPool;

    public override House build()
    {
        var oldHouse = _house;
        _house = new House();
        return _house;
    }
}

public class Constructor
{
    private Builder _builder;

    public Constructor(Builder builder)
    {
        _builder = builder;
    }

    public void Constract(int setFloors = 2, int rooms = 6, bool hasElevator = false, bool hasGarage = true,
        bool hasPool = true)
    {
        _builder.setFloors(setFloors);
        _builder.setRooms(rooms);
        _builder.setHasElevator(hasElevator);
        _builder.setHasGarage(hasGarage);
        _builder.setHasPool(hasPool);
    }
}