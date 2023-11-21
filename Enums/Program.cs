/*
    Enum

    Merupakan kelas spesial yang merepresentasikan grup dari konstanta (constant, variabel yang tidak dapat dirubah).
    Untuk membuat enum, gunakan kata kunci "enum" (baik kelas maupun interface), dan pisahkan item dari enum dengan koma.
*/
class Program
{
    enum RiskLevel 
    {
        Low,
        Medium,
        High
    }

    static void Main(string[] args)
    {
        // contoh mengakses item dari enum RiskLevel
        // caranya sama dengan ketika kita mengakses member dari kelas yang dibuat instance objek (objek.metho atau objek.property)
        Console.WriteLine("Saat ini level resiko Anda adalah " + RiskLevel.Low + ".");
        Console.WriteLine("Level resiko Anda mendetkati  " + RiskLevel.Medium + ".");
    }

}