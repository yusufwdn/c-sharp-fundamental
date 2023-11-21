// Membuat file baru yang berisi string

// Membuat teks berupa string
string writeText = "Hello world"; 
// Membuat sebuah file dan memasukkan writeText ke dalamnya
File.WriteAllText("filename.txt", writeText); 

// Membaca konten yang ada di dalam file
string readText = File.ReadAllText("filename.txt"); 
// Tampilkan hasilnya di console
Console.WriteLine(readText); 