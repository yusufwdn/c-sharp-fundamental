int totalMatkul = 4;
int nilaiBahasa = 0;
int nilaiMatematika = 83;
int nilaiSains = 61;
int nilaiKomputer = 76;

int totalAkumulasi = nilaiBahasa + nilaiMatematika + nilaiSains + nilaiKomputer;
double nilaiAkhir  = Convert.ToDouble(totalAkumulasi) / Convert.ToDouble(totalMatkul);

bool statusKelulusan;

// Melakukan pengecekan nilaiAkhir dengan metode if else
if (nilaiAkhir > 75)
{
    statusKelulusan = true;
} else {
    statusKelulusan = false;
}

// Contoh shorthand dari kondisi if else
string labelKelulusan = statusKelulusan ? "Ya" : "Tidak";

Console.WriteLine("=========================");
Console.WriteLine("IF ELSE CONDITION");
Console.WriteLine("=========================");
Console.WriteLine("Nilai akhir bahasa: " + nilaiBahasa);
Console.WriteLine("Nilai akhir matematika: " + nilaiMatematika);
Console.WriteLine("Nilai akhir sains: " + nilaiSains);
Console.WriteLine("Nilai akhir komputer: " + nilaiKomputer);
Console.WriteLine("");

Console.WriteLine("Total mata kuliah: " + totalMatkul);
Console.WriteLine("Total nilai: " + totalAkumulasi);
Console.WriteLine("Nilai akhir: " + nilaiAkhir);
Console.WriteLine("");

Console.WriteLine("Apakah siswa ini lulus ujian? " + labelKelulusan);
Console.WriteLine("");