using System;

namespace MathMethods
{
    class Program
    {
        
        static double sonuc = 1;

        public static void EkranaYaz(string a)
        {
            Console.WriteLine(a);
        }

        public static double Oku()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double UsAlma(double taban, double us)
        {
            
            for (double i = 1; i <= us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }
        static void Main(string[] args)
        {
            EkranaYaz("Taban: ");
            double taban = Oku();

            EkranaYaz("Üs: ");
            double us = Oku();
            
            EkranaYaz($"Sonuç : {UsAlma(taban, us)}");
        }
    }
}
