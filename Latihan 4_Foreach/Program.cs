using System;
namespace perulanagn_foreach{
    class Program {
        static void Main(string[] args)  {
            string[] hari =  {"Senin", "Selasa","Rabu","Kamis","Jumat","Sabtu" };
            foreach (string urutan in hari)   {
                Console.WriteLine("Hari " + urutan);
            }
            Console.ReadLine();
        }
    }
}