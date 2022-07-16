// class OuterClass {
//   ...
//   class InnerClass {
//     ...
//   }
//}


// outer class
public class Car1
{
    public void displayCar()
    {
        Console.WriteLine("Car: Bugatti");
    }

    // inner class
    public class Engine
    {
        public void displayEngine()
        {
            Console.WriteLine("Engine: Petrol Engine");
        }
    }
}