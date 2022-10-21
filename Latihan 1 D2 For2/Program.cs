using System;
namespace Loops{
   class Program   {
      static void Main(string[] args)  {
        int  a, b, c;

         Console.Write("masukan nilai awal  perulangan :");
         b=Convert.ToInt32(Console.ReadLine());
         Console.Write("masukan nilai akhir  perulangan :");
         c=Convert.ToInt32(Console.ReadLine());

         for (  a=b  ; a < c; a = a + 1)         {
            Console.WriteLine("Perulangan for ke: {0}", a);
         }
         Console.ReadLine();
      }
   }
} 
