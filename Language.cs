abstract class Language
{

    // abstract method
    public abstract void display1();

    // non-abstract method
    public void display2()
    {
        Console.WriteLine("Non abstract method");
    }
}

class English : Language
{
    public override void display1()
    {
        Console.WriteLine("display1 method");
    }
}