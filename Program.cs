// See https://aka.ms/new-console-template for more information


class Program
{
    //In C#, there might be two or more methods in a class with the same name but different numbers, types, and order of parameters, it is called method overloading.
    // method with int parameter
    void display(int a)
    {
        Console.WriteLine("int type: " + a);
    }

    // method with string parameter
    void display(string b)
    {
        Console.WriteLine("string type: " + b);
    }

    // method with int and string parameters 
    void display(int a, string b)
    {
        Console.WriteLine("int: " + a);
        Console.WriteLine("string: " + b);
    }

    // method with string andint parameter
    void display(string b, int a)
    {
        Console.WriteLine("string: " + b);
        Console.WriteLine("int: " + a);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Car mycar = new Car();
        mycar.honk();

        Console.WriteLine(mycar.brand + " " + mycar.modelName);

        Square s1 = new Square();
        s1.calculateArea();
        s1.calculatePerimeter(s1.length, s1.sides);

        Rectangle t1 = new Rectangle();
        t1.calculateArea();
        t1.calculatePerimeter(t1.length, t1.sides);


        English eng = new English();
        eng.display1();

        // create an object of SportsBike class
        SportsBike s1 = new SportsBike();
        s1.brake();

        // create an object of MountainBike class
        MountainBike m1 = new MountainBike();
        m1.brake();

        Car1 sportsCar = new Car1();
        sportsCar.displayCar();


        Car1.Engine petrolEngine = new Car1.Engine();
        petrolEngine.displayEngine();

        Rectangle1 rectangle1 = new Rectangle1();
        rectangle1.calculateArea(10, 5);

        Overloading1 overloading1 = new Overloading1();
        overloading1.display("str");
        overloading1.display(10);
        overloading1.display(10, 20);
    }
}

class Vehicle // base class // parent class
{
    public string brand = "Ford";
    public void honk()
    {
        Console.WriteLine("honking sound");
    }
}

class Car : Vehicle // derived class or child class
{
    public string modelName = "Mustang";
}

class SupperCar : Car
{
    public string modelName = "Supper car";
}




class RegularPolygon
{

    public void calculatePerimeter(int length, int sides)
    {

        int result = length * sides;
        Console.WriteLine("Perimeter: " + result);
    }
}


class Square : RegularPolygon
{

    public int length = 200;
    public int sides = 4;
    public void calculateArea()
    {

        int area = length * length;
        Console.WriteLine("Area of Square: " + area);
    }
}

class Rectangle : RegularPolygon
{

    public int length = 100;
    public int breadth = 200;
    public int sides = 4;

    public void calculateArea()
    {

        int area = length * breadth;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}


// sealed class Human // when we don't want a class to be inherited by another class, we can declare the class as a sealed class.
// {
// }

// class Avi : Human
// {
// }






