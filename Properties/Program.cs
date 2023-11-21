class Person
{
    private string name = ""; // field

    public string Name // property
    {
        // get, untuk mendapatkan field private bernama 'name' melalui property 
        // bernama 'Name'.
        get { return name; }

        // set, untuk memberikan nilai kepada field 'name' yang bersifat private.
        set { name = value; } 
    }

    public int Age { get; set; } // contoh shorthand property
    
    // contoh readonly property
    public string NameReadOnly { get {return name;} }
    
    // contoh readonly property
    public string WriteName { set {name = value;} }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Liam";
        person.Age  = 45;

        Console.WriteLine("Nama: " + person.Name);
        Console.WriteLine("Umur: " + person.Age);

        person.WriteName = "Hehehe";

        Console.WriteLine("Nama baru: "+ person.Name);
        Console.WriteLine("Nama readonly: " + person.NameReadOnly);
    }
}