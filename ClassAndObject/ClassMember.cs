// The class
class ClassMember
{
    // Class Member
    // Merupakan seluruh property/field dan method yang berada di dalam kelas

    string color = "red"; // field
    int maxSpeed = 200; // field

    public void fullThrottle() // method
    {
        Console.WriteLine("The car color is " + color);
        Console.WriteLine("The car max speed is " + maxSpeed);
        Console.WriteLine("The car is going as fast as it can!");
    }
}