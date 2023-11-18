// Menampilkan teks awal
Console.WriteLine("Hello! Welcome to my world.");

// Menampilkan pertanyaan yang menanyakan nama user
Console.WriteLine("But, what is your name?");

// Menampung isian user dari terminal ke dalam variabel userName
string? userName = Console.ReadLine();

// Menampilkan nama user sesuai dengan apa yang diinputkan sebelumnya
Console.WriteLine("Nice name, Hello " + userName);

// Menampilkan pertanyaan terkait dengan umur
Console.WriteLine("How old are you?");

// Menampung umur user
string? userAge = Console.ReadLine();

// Melakukan konversi tipe data menjadi int
int convertedAge = Convert.ToInt32(userAge);

// Menampilkan umur user sesuai dengan yang diinputkan sebelumnya
Console.WriteLine("Oh you're " + convertedAge + ", it's great!");