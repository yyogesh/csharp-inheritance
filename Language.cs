// The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. The abstract modifier can be used with classes, methods, properties, indexers, and events. Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own. Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.
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