/*
    I N T E R F A C E

    Merupakan versi full dari kelas abstrak, karena di dalamnya hanya dapat berisi metode dan properti 
    abstrak (dengan isi kosong, tanpa body).

    Untuk best practice, penamaan interface lebih baik menggunakan huruf "I" didepannya. Hal ini dilakukan untuk
    mempemudah kita atau orang lain untuk memahami bahwa yang digunakan tersebut adalah sebuah interface.

    Catatan untuk Interface:
    - Sama seperti kelas abstrak, interface tidak bisa digunakan langsung untuk membuat objek baru.
    - Interface tidak memiliki body pada methodnya, nanti body dari method tersebut diisi ketika di kelas yang 
      implement ke interfacenya.
    - Ketika ada kelas yang mengimplement interface, maka kelas tersebut harus melakukan override terhadap seluruh 
      method yang ada di interface.
    - Interface hanya mengandung property dan method, tidak ada field dan variable.
    - Secara default, member dari interface adalah abstract dan public.
    - Interface tidak memiliki constructor.

    Kenapa menggunakan Interface?
    1) Untuk keamanan, menyembunyikan informasi detail dan penting dari sebuah objek (interface).
    2) C# tidak mendukung "multiple inheritance" (kelas hanya bisa inherit dari satu kelas). Tapi hal tersebut dapat 
       dilakukan melalui interface, karena kelas dapat mengimplementasi lebih dari satu interface.
*/

// contoh script interface
interface IAnimal
{
    // method pada interface tidak memiliki body
    void animalSound();
}

// Hal ini menandakan bahwa kelas Pig mengimplementasikan interface IAnimal
class Pig : IAnimal
{
    public void animalSound()
    {
        // Body dari animal sound diisi disini
        Console.WriteLine("Pig says: Oink Oink Oink");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig pig = new Pig(); // membuat instance baru dari kelas Pig
        pig.animalSound();
    }
}