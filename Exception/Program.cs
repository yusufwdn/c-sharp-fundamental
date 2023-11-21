class Program
{
    static void Main(string[] args)
    {
        try {
            // inisiasi array of integers
            int[] myNumbers = {1, 2, 3};
            
            // mengambil data dari myNumber dengan index 10
            // karena tidak ada index bernomor 10, maka akan error. Tapi karena script kita berada 
            // di block try, maka error akan dilemparkan ke block catch.
            Console.WriteLine(myNumbers[10]); 

            // contoh custom error dari dalam fungsi checkAge()
            // tapi harus comment/matikan dulu script console.writeline diatas, karena jika tidak akan
            // langsung dilempar ke block catch
            checkAge(15);

        } catch (Exception e) {
            // error handling
            Console.WriteLine(e.Message);
        } finally {
            // fungsi pada block ini akan dijalankan baik proses berhasil maupun error.
            // block ini adalah penanda apabila proses di dalam block try-catch-fiinnaly telah berhenti 
            Console.WriteLine("The 'try catch' is finished.");
        }
    }

    static void checkAge(int age)
    {
        if (age < 18) {
            // kata kunci throw berguna untuk mengalokasikan error (custom error) agar lebih terstruktur.
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        } else {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }
}
