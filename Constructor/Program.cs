class Car
{
    public string model = "";
    public string color = "";
    public int year;

    /*
        Constructor
        Method ini akan dieksekusi pertama kali ketika ada pembuatan objek atas kelas terkait.

        Method constructor memiliki beberapa aturan, seperti nama method yang harus sama 
        dengan nama kelasnya, tidak boleh ada return typenya (seperti void, int, string, dll).

        Method constructor juga dapat menerapkan konsep 'method overloading' dimana dapa membuat
        lebih dari satu method dengan nama yang sama namun parameternya bisa berbeda.
    */
    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year  = modelYear;
    }

    static void Main(string[] args)
    {
        // dalam menginisiasi objek kelas Car, kita harus memberikan parameterkei dalam kelas Car
        // karena akan digunakan pada method constructor yang telah dibuat.
        Car mercy = new Car("Mercedes C Class", "Blue Glossy", 2017);
        Console.WriteLine(mercy.model + " " + mercy.color + " " + mercy.year);
    }
}