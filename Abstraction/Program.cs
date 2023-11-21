/*
    Abstract Class & Method

    - Abstract Class
    Merupakan kelas terbatas yang tidak dapat digunakan untuk membuat objek (untuk mengaksesnya 
    harus diwarisi dari kelas lain).

    - Abstract Method
    Method yang hanya dapat digunakan di kelas abstrak, dan tidak memiliki isi (body) di dalamnya. 
    Nantinya isian tersebut disediakan oleh kelas turunan (dari pewarisan).

    Metode abstraction ini digunakan untuk menyembunyikan bagian detail dari objek dan merupakan 
    sebuah tindak pengamanan program.
*/

// Kelas abstrak dan kelas induk
abstract class Animal
{
    public abstract void animalSound();
    
    public void sleep()
    {
        Console.WriteLine("ZzZzZzZ");
    }
}

// Kelas anak dari kelas abstrak 'Animal'
class Pig : Animal
{
    public override void animalSound()
    {
        // Karena pada method animalSound di kelas induk (Animal) tidak ada isinya, maka di sinilah kita mengisinya
        // untuk mengatur fungsi dan logicnya.
        Console.WriteLine("Oink Oink Oink");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Kelas Animal tidak dapat diinstansiasi karena kelas tersebut adalah kelas abstrak
        // error: Cannot create an instance of the abstract type or interface 'Animal'
        // Animal animal = new Animal();

       Pig pig = new Pig();  // Membuat instance dari kelas Pig
       pig.animalSound(); // Memanggil method abstrak yang telah diisi body
       pig.sleep(); // Memanggil method sleep milik kelas abstrak 'Animal' melalui kelas Pig yang merupakan kelas anaknya

    }
}