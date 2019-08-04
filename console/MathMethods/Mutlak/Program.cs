using System;

namespace Mutlak
{
    class Program
    {
        public static void EkranaYaz(string a)
        {
            Console.WriteLine(a);
        }

        public static double Oku()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double Mutlak(double sayi)
        {
            if(sayi < -1)
            {
                return sayi * (-1);
            }
            else
            {
                return sayi;
            }
        }
        static void Main(string[] args)
        {
            EkranaYaz("Sayı : ");
            double sayi = Oku();

            EkranaYaz($"{sayi} sayısının mutlak değeri : {Mutlak(sayi)}");

        }
    }
}
