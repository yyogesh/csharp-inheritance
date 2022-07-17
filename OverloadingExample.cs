// void display() { ... }
// void display(int a) { ... }
// float display(double a) { ... }
// float display(int a, float b) { ... }

//there might be two or more methods in a class with the same name but different numbers, types, and order of parameters, it is called method overloading. 

class Overloading1
{

    Overloading1()
    {
        Console.WriteLine("Car constructor");
    }

    Overloading1(string name)
    {
        Console.WriteLine("Car constructor");
    }
    // method with one parameter
    public void display(int a)
    {
        Console.WriteLine("Arguments: " + a);
    }

    // method with two parameters
    public void display(int a, int b)
    {
        Console.WriteLine("Arguments: " + a + " and " + b);
    }

    public void display(string b)
    {
        Console.WriteLine("string type: " + b);
    }
}