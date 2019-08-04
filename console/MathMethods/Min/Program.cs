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

        public static double Min(double sayi1, double sayi2)
        {
            if (sayi1 < sayi2)
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

            EkranaYaz($"Küçük Olan Sayı : {Min(sayi1, sayi2)}");
        }
    }
}
