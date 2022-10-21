using System;
namespace perulanagn_foreach{
    class Program {
        static void Main(string[] args)  {
            Console.WriteLine("Password yang anda masukkan salah, coba lagi");
            Console.Write(" Masukkan Password : ");
            String pass = Console.ReadLine();
            switch (pass)  {
            case "Mis":
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("Selamat Anda Berhasil ");
            Console.WriteLine("==========================================");
            break;
            default:
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("Anda tidak berhak masuk kedalam sistem ini");
            Console.WriteLine("==========================================");
            break;
            }
            Console.Read();
        }
    }
}