using System;

namespace MathMethods
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

        public static double Max(double sayi1, double sayi2)
        {
            if(sayi1 > sayi2)
            {
                return sayi1;
            }
            else
            {
                return sayi2;
            }
        }
        static void Main(string[] args)
        {
            EkranaYaz("Sayı 1: ");
            double sayi1 = Oku();

            EkranaYaz("Sayı 2: ");
            double sayi2 = Oku();

            EkranaYaz($"Büyük Olan Sayı : {Max(sayi1, sayi2)}");
        }
    }
}
