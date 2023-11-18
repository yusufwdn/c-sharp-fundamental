/*
    Implicit Casting (Automatically)
    
    Merupakan sebuah proses casting yang dilakukan secara otomatis  apabila tipe 
    data lebih kecil ke yang lebih besar.

    char -> int -> long -> float -> double
*/

int contohAngka = 9;
double contohAngkaDirubah = contohAngka; // casting dilakukan secara otomatis dari int ke double

Console.WriteLine("=========================");
Console.WriteLine("IMPLICIT CASTING");
Console.WriteLine("=========================");
Console.WriteLine(contohAngka); // ekspektasi: 9
Console.WriteLine(contohAngkaDirubah); // ekspektasi: 9
Console.WriteLine("");

/*
    Explicit Casting (Manually)
    
    Merupakan sebuah proses casting dimana data dengan otomatis akan dikonversi
    apabila tipe data lebih kecil ke yang lebih besar

    char <- int <- long <- float <- double
*/

double contohDouble = 9.78;
double contohInt = (int)contohDouble; // manual casting dari double ke int

Console.WriteLine("=========================");
Console.WriteLine("EXPLICIT CASTING");
Console.WriteLine("=========================");
Console.WriteLine(contohDouble); // ekspektasi: 9.78
Console.WriteLine(contohInt); // ekspektasi: 9
Console.WriteLine("");

/*
    Type Conversion Method
    
    Selain itu, kita dapat juga melakukan konversi tipe data menggunakan method built-in,
    seperti Convert.ToBoolean, Convert.ToDouble, Covert.ToString dan lainnya.
*/

int angkaLainnya = 10;
double angkaDoubleLainnya = 8.25;
bool isConditional = true;

Console.WriteLine("=========================");
Console.WriteLine("TYPE CONVERSION METHOD");
Console.WriteLine("=========================");
Console.WriteLine(Convert.ToString(angkaLainnya));
Console.WriteLine(Convert.ToDouble(angkaLainnya));
Console.WriteLine(Convert.ToInt32(angkaDoubleLainnya));
Console.WriteLine(Convert.ToString(isConditional));
Console.WriteLine("");