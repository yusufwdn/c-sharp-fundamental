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

        // memanggil method yang bernama MyMethod sebanyak 3 kali
        MyMethod();
        MyMethod();
        MyMethod();
    }

    static void MyMethod()
    {
        Console.WriteLine("Saya sangat ganteng.");
    }
}