/*
    Array
    Merupakan suatu tipe data terstruktur yang dapat menyimpan banyak data dengan suatu 
    nama yang sama dan menempati tempat di memori yang berurutan serta bertipe data sama pula. 
    Array dapat diakses berdasarkan indeksnya.
*/

Console.WriteLine("=========================");
Console.WriteLine("A R R A Y");
Console.WriteLine("=========================");

// Deklarasi array

// Array yang berisi string
string[] cars = {"Volvo", "BMW", "Mercy", "Mazda"};

// Array yang berisi string
int[] scores = {78, 80, 76, 90};

// Accessing element of an array
string currentCar = cars[0];
Console.WriteLine($"Value of cars array with index 0 is '{currentCar}'");

// Change array value
cars[0] = "Tesla";

string newCar = cars[0];
Console.WriteLine($"Now it's value changed to '{newCar}'\n");
Console.WriteLine("");

// Membuat array yang dapat diisi dengan 4 element, namun belum terisi value apapun
string[] array0 = new string[4];

// Membuat array yang dapat diisi dengan 4 element dan langsung memberikan nilainya
string[] array1 = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Membuat array tanpa mengisi batasan dari array yang dibuat
string[] array2 = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Membuat array tanpa menggunakan kata kunci new
string[] array3 = {"Volvo", "BMW", "Ford", "Mazda"};

/*
    Looping Array
    Kita dapat melakukan looping terhadap array dengan beberapa metode. Berikut adalah
    contoh dari pengimplementasian looping pada sebuah array.
*/

// Dengan perulangan loop
Console.WriteLine("=========================");
Console.WriteLine("A R R A Y   F O R   L O O P");
Console.WriteLine("=========================");

for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}
Console.WriteLine("");


Console.WriteLine("=========================");
Console.WriteLine("A R R A Y   F O R E A C H   L O O P");
Console.WriteLine("=========================");
foreach (string i in cars) 
{
  Console.WriteLine(i);
}
Console.WriteLine("");

// Sort array
Array.Sort(cars);

Console.WriteLine("=========================");
Console.WriteLine("A R R A Y   A G G R E G A T");
Console.WriteLine("=========================");

Console.WriteLine("Skor tertinggi   : " + scores.Max());  // mengembalikan nilai terbesar
Console.WriteLine("Skor terendah    : " + scores.Min());  // mengembalikan nilai terkecil
Console.WriteLine("Akumulasi skor   : " + scores.Sum());  // mengembalikan akumulasi nilai
Console.WriteLine("");

/*
    Array Multidimensional
    Di dalam array dapat berisi array lagi, itulah yang disebut multideimensional array.
*/

Console.WriteLine("=========================");
Console.WriteLine("A R R A Y   M U L T I D I M E N S I O N A L");
Console.WriteLine("=========================");

// Deklarasi array multidimensional
int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
Console.WriteLine("Index pertama dari array numbers berisi array, dari array tersebut ambil lagi indeks ke 2. Dan nilainya adalah " + numbers[0, 2]);  // Output 2
Console.WriteLine("");

numbers[0, 0] = 5;  // Merubah value indeks pertama di array pertama 5
Console.WriteLine("Merubah isian dari array pertama di numbers dari 1 menjadi " + numbers[0, 0]); // Sebelum dirubah outputnya 1, setelah dirubah outputnya 5
Console.WriteLine("");


// Contoh looping menggunakan multidimensional array
Console.WriteLine("Array Loop");
foreach (int i in numbers)
{
  Console.WriteLine(i);
} 