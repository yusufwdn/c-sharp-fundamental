interface IFirstInterface
{
    void firstMethod(); // method interface
}

interface ISecondInterface
{
    void secondMethod(); // method interface
}

// melakukan implementasi dua interface
// hal ini mengharuskan kelas MyClass membuat seluruh method yang dimiliki oleh interface 
// yang diimplementasi
class MyClass : IFirstInterface, ISecondInterface
{
    public void firstMethod()
    {
        Console.WriteLine("Saya adalah firstMethod dari IFirstInterface");
    }

    public void secondMethod()
    {
        Console.WriteLine("Saya adalah secondMethod dari ISecondInterface");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass kelasSaya = new MyClass();
        kelasSaya.firstMethod();
        kelasSaya.secondMethod();
    }
}