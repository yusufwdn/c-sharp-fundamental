class Program 
{
    static void Main(string[] args)
    {
        // menginisiasikan 2 objek dari kelas Car() dari file Car.cs
        Car myCar  = new Car();
        Car newCar = new Car();

        // memanggil property color dari myCar dan newCar
        string myCarColor = myCar.color;
        string newCarColor = newCar.color;

        int myCarMaxSpeed = myCar.maxSpeed;
        int newCarMaxSpeed = newCar.maxSpeed;

        Console.WriteLine($"myCar color is {myCarColor}.");
        Console.WriteLine($"myCar max speed is {myCarMaxSpeed}.\n");

        Console.WriteLine($"newCar color is {newCarColor}.");
        Console.WriteLine($"newCar max speed is {newCarMaxSpeed}.\n");

        // menginisiasi kelas dan mengisi value pada property kelasnya
        CarCustomable carCustom = new CarCustomable();
        string carCustomModel = carCustom.model = "Toyota Supra";
        string carCustomColor = carCustom.color = "Manta Black";
        int carCustomYear = carCustom.year = 2019;

        Console.WriteLine($"Car model is {carCustomModel}.");
        Console.WriteLine($"The main color is {carCustomColor}.");
        Console.WriteLine($"And it was released in {carCustomYear}.\n");

    }
}
