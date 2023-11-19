/* 
    Operator Aritmatika
    Operator yang digunakan untuk melakukan kalkulasi antar bilangan.

    (+)	    Addition	    Menjumlahkan dua atau lebih bilangan
    (-)	    Subtraction	    Mengurangu suatu bilangan
    (*)	    Multiplication	Proses perkalian bilangan
    (/)	    Division	    Membagi bilangan
    (%)	    Modulus	        Operasi yang mengembalikan sisa bagi
    (++)	Increment	    Pertambahan bilangan sebanyak 1
    (--)	Decrement	    Pengurangan bilangan sebanyak 1
*/

int x = 10 + 50;
int y = x - 20;
int z = y * 5;
int a = z / 2;

Console.WriteLine("=========================");
Console.WriteLine("ARITMATHIC OPERTATOR");
Console.WriteLine("=========================");
Console.WriteLine("x = 10 + 50 = " + x);
Console.WriteLine("y = "+ x + " - 20 = " + y);
Console.WriteLine("z = " + y + " x 5 = " + z);
Console.WriteLine("a = " + z + " / 2 = " + a);
Console.WriteLine("");

/*
    Comparison Operator
    Operator yang digunakan untuk membandingkan dua nilai

    "=="	Sama dengan
    "!="	Tidak sama dengan
    ">"	    Lebih besar
    "<"	    Lebih kecil
    ">="	Lebih besar atau sama dengan
    "<="	Lebih kecil atau sama dengan
*/
int pahala = 100;
int dosa = 50;

bool hasilBanding = pahala > dosa;

Console.WriteLine("=========================");
Console.WriteLine("COMAPARISON OPERTATOR");
Console.WriteLine("=========================");
Console.WriteLine("Jumlah pahala: " + pahala);
Console.WriteLine("Jumlah dosa: " + dosa);
Console.WriteLine("Apakah pahala saya lebih besar dari dosa? " + hasilBanding);
Console.WriteLine("");

/*
    Logical Operator
    Operator yang digunakan menentukan kondisi berdasarkan logika

    "&&" 	Mengembalikan nilai true apabila seluruh nilai perbandingannya bernilai true
    "||" 	Mengembalikan nilai true apabila salah satu dari nilai perbandingannya bernilai true
    "!"	    Mengembalikan nilai true apabila nilai dari pembanding dengan yang dibandingkan bertolak belakang
*/

bool nikmat  = pahala > dosa || pahala == dosa || dosa == 0;
bool celaka = pahala < dosa || pahala == dosa;
bool tobat = pahala < dosa || dosa > 0;

Console.WriteLine("=========================");
Console.WriteLine("LOGICAL OPERTATOR");
Console.WriteLine("=========================");
Console.WriteLine("Apakah saya akan mendapatkan nikmat? " + nikmat);
Console.WriteLine("Apakah saya bisa celaka? " + celaka);
Console.WriteLine("Apakah saya harus meminta ampunan? " + tobat);
Console.WriteLine("");
