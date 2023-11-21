class Animal
{
    // Dengan menambahkan keyword 'virtual', maka dapat dikatakan bahwa method ini dapat
    // di-override oleh kelas turunan / kelas anak.
    public virtual void AnimalSound()
    {
        Console.WriteLine("Animals has their own sound.");
    }

}

class Pig : Animal
{
    // Membuat method bernama AnimalSound yang mana nama dari method ini sama seperti yang ada
    // di kelas induknya dan memberikan keyword override. Di sini method AnimalSound diganti 
    // untuk isi dari Console.WriteLine nya.
    public override void AnimalSound()
    {
        Console.WriteLine("Pig says: Oink Oink Oink");
    }
}

class Dog : Animal
{
    // Sama seperti AnimalSound di kelas Pig, isian dari method ini juga dirubah.
    public override void AnimalSound()
    {
        Console.WriteLine("Dog says: Whoof Whoof");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        Pig pig = new Pig();
        Dog dog = new Dog();

        animal.AnimalSound();
        pig.AnimalSound();
        dog.AnimalSound();
    }
}