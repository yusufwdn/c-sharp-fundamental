class Car
{
    // private, menandakan bahwa field ini hanya dapat diakses di dalam kelasnya sendiri
    // jika dicoba diakses di kelas lain, maka akan memunculkan error
    private string model = "Mustang GT";

    // public, menandakan bahwa field di kelas Car ini dapat diakses dimanapun asalkan ada
    // kelas 'Car' yang dibuat instansiasi
    public int tiresTotal = 4;

    // jika tidak menuliskan access modifier, secara default akan dianggap private
    string exampleField = "test";

    static void Main(string[] args)
    {
        Console.WriteLine("======= Car Class =======");

        Car myCar = new Car();

        Console.WriteLine("Model: " + myCar.model);
        Console.WriteLine("Jumlah Roda: " + myCar.tiresTotal);

        Other otherClass = new Other();
        otherClass.Run();

    }
}

class Other
{
    public void Run()
    {
        Console.WriteLine("======= Other Class =======");

        Car car = new Car();

        /*
            Field 'model' dari kelas 'Car' tidak akan bisa dipanggil / tidak akan terbaca
            di instance yang telah dibuat, karena field tersebut adalah 'private'.

            error: 'Car.model' is inaccessible due to its protection level
        */
        // Console.WriteLine(car.model);

        // contoh mengakses field yang bersifat 'public' dari kelas lain.
        Console.WriteLine("Total roda Other: " + car.tiresTotal);
    }
}