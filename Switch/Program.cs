
/*
    Switch akan menampung argumen yang diberikan, lalu akan melakukan pengecekan dengan menyocokan
    satu per satu nilai dari parameternya. Jika ada, maka fungsi switch tersebut akan menjalankan
    perintah yang ada di dalam case tersebut.

    Misal di bawah ini kita berikan value berupa angka 4. Maka program akan menjalankan perintah sesuai dengan
    apa yang ada di case yang sama dengan angka 4

*/

start:

Console.Write("Pilih angka dari 1 hingga 7: ");

string? userInput = Console.ReadLine();
int hari = Convert.ToInt32(userInput);

switch (hari) 
{
  case 1:
    Console.WriteLine($"Hari ke-{hari} adalah hari Senin");
    break;
  case 2:
    Console.WriteLine($"Hari ke-{hari} adalah hari Selasa");
    break;
  case 3:
    Console.WriteLine($"Hari ke-{hari} adalah hari Rabu");
    break;
  case 4:
    Console.WriteLine($"Hari ke-{hari} adalah hari Kamis");
    break;
  case 5:
    Console.WriteLine($"Hari ke-{hari} adalah hari Jumat");
    break;
  case 6:
    Console.WriteLine($"Hari ke-{hari} adalah hari Sabtu");
    break;
  case 7:
    Console.WriteLine($"Hari ke-{hari} adalah hari Minggu");
    break;
  default: 
    Console.WriteLine("Input yang dimasukkan tidak valid\n");
    
    goto start; // jika tidak valid, maka akan kembali ke start
}