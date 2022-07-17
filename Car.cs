class Car2
{

    // constructor with string and int parameter
    Car2(string brand, int price)
    {

        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Price: " + price);
    }

    // constructor with int and string parameter
    Car2(int speed, string color)
    {

        Console.WriteLine("Speed: " + speed + " km/hr");
        Console.WriteLine("Color: " + color);
    }
    static void Main(string[] args)
    {
        // call constructor  with string and int parameter
        Car2 car = new Car2("Bugatti", 50000);

        Console.WriteLine();

        // call constructor with int and string parameter
        Car2 car2 = new Car2(60, "Red");

        Console.ReadLine();
    }
}