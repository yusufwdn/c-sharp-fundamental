// Mendeklarasikan kelas Vehicle yang akan dijadikan kelas induk untuk kelas Car
class Vehicle
{
    public string brand = "Mercedes Benz";

    public void honk()
    {
        Console.WriteLine("Dor");
    }
}

// Dengan mengetik seperti ini, maka kelas Car adalah anak dari kelas Vehicle
class Car : Vehicle 
{
    public string modelName = "CLS";
}

// keyword sealed di bawah ini menandakan bahwa kelas ini tidak dapat menjadi parent
// bagi kelas lain.
sealed class SampleParent
{
    public int x = 0;
}

/*
    Kelas SampleChild tidak dapat menjadi child dari kelas SampleParent. Karena kelas
    SampleParent menggunakan keyword 'sealed' pada pendeklarasian kelasnya. Hal tersebut
    akan menyebabkan kelas tersebut tidak bisa jadi kelas induk bagi kelas manapun.

    Script dibawah ini akan memunculkan error karena memaksa SampleParent agar menjadi
    kelas induk dari SampleChild

    error: 'SampleChild': cannot derive from sealed type 'SampleParent'
*/
// class SampleChild : SampleParent
// {
//     public int y = 1;
// }

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek yang mereferensikan kelas Car
        Car car = new Car();

        // Memanggil method honk() milik kelas Vehicle melalui kelas Car yang merupakan
        // anak dari kelas Vehicle
        car.honk();

        // Menampilkan field modelName milik kelas Car dan juga field brand milik kelas Vehicle
        // yang telah diturunkan kepada kelas Car
        Console.WriteLine(car.brand + " " + car.modelName);
    }
}