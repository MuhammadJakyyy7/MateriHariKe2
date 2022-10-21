using System;
class ProgramPenugasan
{
    public static void Main(String[] args)
    {
        int Bilangan_Pertama = 10, Bilangan_Kedua = 20;
        int penjumlahan = 0, pengurangan = 0, perkalian = 0, modulus = 0;
        double pembagian = 0;

        penjumlahan = Bilangan_Pertama + Bilangan_Kedua;
        Console.WriteLine("penjumlahan : {1} + {1} = {2}", Bilangan_Pertama, Bilangan_Kedua, penjumlahan);

        pengurangan = Bilangan_Kedua + Bilangan_Pertama;
        Console.WriteLine("pengurangan :{0} - {1} = {2}", Bilangan_Pertama, Bilangan_Kedua, pengurangan);

        perkalian = Bilangan_Pertama * Bilangan_Kedua;
        Console.WriteLine("perkalian : {0} + {1} = {2}", Bilangan_Pertama, Bilangan_Kedua, perkalian);

        pembagian = Bilangan_Pertama / Bilangan_Kedua;
        Console.WriteLine("pembagian : {0} / {1} = {2}", Bilangan_Pertama, Bilangan_Kedua, pembagian);

        modulus = Bilangan_Pertama % Bilangan_Kedua;
        Console.WriteLine("modulus : {0} % {1} = {2}", Bilangan_Pertama, Bilangan_Kedua, modulus);
    }
}