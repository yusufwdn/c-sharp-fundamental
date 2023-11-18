/* 
    Variable

    Dalam pendeklarasian variable, harus memiliki format seperti ini:    
    type variableName = value;

    Untuk memudahkan dalam pemahaman, berikut adalah contoh beberapa pendeklarasian 
    variable.
*/

int myNum = 5;
double myDoubleNum = 5.99D;
float myFloatNum = 3.14f;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

Console.WriteLine("=========================");
Console.WriteLine("V A R I A B L E");
Console.WriteLine("=========================");
Console.WriteLine("int value: " + myNum);
Console.WriteLine("double value: " + myDoubleNum);
Console.WriteLine("float value: " + myFloatNum);
Console.WriteLine("char value: " + myLetter);
Console.WriteLine("bool value: " + myBool);
Console.WriteLine("string value: " + myText);
Console.WriteLine("");

/* 
    Constant

    Sama seperti variabel di atas, namun variabel constant memiliki behavior khusus
    dimana value yang telah dideklarasikan tidak dapat dirubah kembali. Jadi valuenya
    merupakan suatu ketetapan yang tidak dapat dirubah lagi.
*/
Console.WriteLine("=========================");
Console.WriteLine("C O N S T A N T");
Console.WriteLine("=========================");

const float Pi = 3.14f;
// Pi = (22/7); // Value dari variabel Pi Tidak dapat direplace karena merupakan sebuah constant

Console.WriteLine("Nilai dari Pi adalah " + Pi + ". Nilai ini adalah nilai tetap, tidak bisa dirubah sejak awal pendeklarasiannya.");
Console.WriteLine("");

/*
    Declare Multiple Variables

    Kita juga diperbolehkan mendeklarasikan beberapa variabel secara bersamaan apabila tipe data atau value dari 
    variabel tersebut sama persis satu sama lain.
*/
Console.WriteLine("=========================");
Console.WriteLine("DECLARE MULTIPLE VARIABLES");
Console.WriteLine("=========================");

// Melakukan deklarasi variabel x, y, dan z yang bertipe int dan memberikan nilai ke dalamnya dalam satu baris
int x = 10, y = 20, z = 30;

// Melakukan deklarasi variabel jumlahMakanan dan jumlahMinuman tanpa memberikan nilainya
int jumlahMakanan, jumlahMinuman;
jumlahMakanan = jumlahMinuman = 5; // Lalu nilainya dideklarasikan bersama seperti ini

Console.WriteLine("nilai dari x: " + x);
Console.WriteLine("nilai dari y: " + y);
Console.WriteLine("nilai dari z: " + z);
Console.WriteLine("jumlah makanan: " + jumlahMakanan);
Console.WriteLine("jumlah minuman: " + jumlahMinuman);