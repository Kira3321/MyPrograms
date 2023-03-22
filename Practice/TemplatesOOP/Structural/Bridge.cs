namespace Practice.TemplatesOOP.Structural;

public abstract class Vehicle
{
    protected VehicleEngene _vehicleEngene;

    public VehicleEngene VehicleEngene
    {
        set
        {
            _vehicleEngene = value;
        }
    }

    public Vehicle(VehicleEngene vehicleEngene)
    {
        _vehicleEngene = vehicleEngene;
    }

    public void Work()
    {
        _vehicleEngene.Work();
    }
    
}

public class Car : Vehicle
{
    public Car(VehicleEngene vehicleEngene) : base(vehicleEngene)
    {
    }
}

public abstract class VehicleEngene
{
    public abstract void Work();
}

public class BioEngene : VehicleEngene
{
    public override void Work()
    {
    }
}

public class GasEngene : VehicleEngene
{
    public override void Work()
    {
    }
}