/*
    WHILE
    Fungsi perulangan yang dimana akan terus berjalan selama kondisi yang diinginkan belum terpenuhi.
*/

Console.WriteLine("=========================");
Console.WriteLine("W H I L E");
Console.WriteLine("=========================");

int i = 0;
while (i < 5) 
{
  Console.WriteLine(i);
  i++;
}
Console.WriteLine("");

/*
    DO WHILE
    Secara fungsional do while sama dengan while, namun hanya ada perbedaan style strukturnya.
*/
Console.WriteLine("=========================");
Console.WriteLine("D O   W H I L E");
Console.WriteLine("=========================");

int x = 0;
do 
{
  Console.WriteLine(i);
  x++;
}
while (x < 5);
Console.WriteLine("");

/*
    FOR
    Perulangan ini lebih baik digunakan ketika kamu tahu kapan perulangan ini berakhir.
*/
Console.WriteLine("=========================");
Console.WriteLine("F O R");
Console.WriteLine("=========================");
for (int z = 0; z <= 10; z = z + 2) 
{
  Console.WriteLine(z);
}
Console.WriteLine("");

/*
    FOREACH
    Perulangan ini digunakan untuk melakukan perulangan dari element-element yang ada 
    di dalam array.
*/
Console.WriteLine("=========================");
Console.WriteLine("F O R E A C H");
Console.WriteLine("=========================");
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string item in cars) 
{
  Console.WriteLine(item);
}