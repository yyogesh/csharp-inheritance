abstract class MotorBike
{
    public abstract void brake();
}


class SportsBike : MotorBike
{
    // provide implementation of abstract method
    public override void brake()
    {
        Console.WriteLine("Sports Bike Brake");
    }
}

class MountainBike : MotorBike
{
    // provide implementation of abstract method
    public override void brake()
    {
        Console.WriteLine("Mountain Bike Brake");
    }

}