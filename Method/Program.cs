class Program 
{
    /*
        Main Method
        Merupakan method utama yang akan dijalankan pada saat memberikan perintan `dotnet run`.
        
        Method ini berisi parameter string[] args, merupakan sebuah array string yang berisi argumen yang diberikan 
        saat program dijalankan. Misalnya, jika Anda menjalankan program dari baris perintah seperti ini:

        `dotnet run arg1 arg2 arg3`

        Maka, args akan menjadi array string ["arg1", "arg2", "arg3"]. Program dapat menggunakan nilai-nilai ini untuk 
        membaca input tambahan atau untuk mengatur perilaku program sesuai dengan argumen yang diberikan.
    */
    static void Main(string[] args)
    {
        // Contoh penggunaan args
        Console.WriteLine("Jumlah argumen: " + args.Length);

        Console.WriteLine("Argumen yang diberikan:");
        for (int i = 0; i < args.Length; i++)
        {
            // Mencetak argument yang dikirimkan via console
            Console.WriteLine($"{i + 1}. {args[i]}");
        }
        Console.WriteLine("");

        // memanggil method yang bernama MyMethod sebanyak 3 kali
        MyMethod();
        MyMethod();
        MyMethod();
        Console.WriteLine("");

        // memanggil MethodWithParam dengan mengisi parameter (string) "Jaenal" dan (int) 12
        MethodWithParams("Jaenal", 12);

        // ketika tidak memberikan nilai pada parameternya, maka akan menggunakan default valuenya
        // parameter pertama (string name) default valuenya "John doe", dan parameter kedua (int age) defaultnya 15
        MethodWithParams();

        // memanggil MethodWithReturn yang dimana method tersebut mengembalikan nilai integer
        int hasilKalkulasi = MethodWithReturn(5, 10);
        Console.WriteLine($"Hasil dari 5 + 10 = {hasilKalkulasi}\n");

        // contoh penggunaan method overloading
        int number1 = MethodOverloadingPlus(5, 5);
        double number2 = MethodOverloadingPlus(5.25, 8.2);
        Console.WriteLine($"Number1 bernilai {number1}");
        Console.WriteLine($"Number2 bernilai {number2}\n");
    }

    /* Contoh method sederhana dengan menampilkan teks pada console */
    static void MyMethod()
    {
        Console.WriteLine("Saya sangat ganteng.");
    }

    /* Contoh method yang diiringi dengan parameter */
    static void MethodWithParams(string name = "John Doe", int age = 15)
    {
        Console.WriteLine($"Hello, {name}.\nOh youre {age}yo, it's great!\n");
    }

    /*
        Method with Return
        Method ini dapat mengembalikan nilai yang sesuai dengan tipe data yang dideklarasikan.

        Misal method MethodWithReturn di bawah ini mengembalikan nilai int yang ditandai dengan
        keyword int sebelum nama method tersebut.
    */
    static int MethodWithReturn(int numberX, int numberY)
    {
        return numberX + numberY;
    }

    /*
        Method Overloading
        Merupakan method yang dapat memiliki nama yang sama, namu parameternya berbeda.

        Contohnya adalah method berikut yang bernama MethodOverloadingPlus(). Terdapat dua method
        dengan nama yang sama, namun parameter yang berbeda.

        Method overloading akan tetap berlaku selama namanya sama dan jumlah dan/atau jenis parameternya berbeda.
    */
    static int MethodOverloadingPlus(int x, int y)
    {
        return x + y;
    }

    static double MethodOverloadingPlus(double x, double y)
    {
        return x + y;
    }
}