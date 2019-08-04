using System;

namespace Karekok
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

        static void Main(string[] args)
        {
            EkranaYaz("Bir sayı girin");
            double sayi = Oku();

            double karekok = Karekok(sayi);

            EkranaYaz($"Sayının Karekökü = { karekok}");
        }

        private static double Karekok(double sayi)
        {
            double i, n = (double)sayi, t;
            double r = sayi;
            for (i = 0; i < n; i++)
            {
                r = (r + (sayi / r)) * 0.5;
                t = (double)r;
                if ((t * t) < t)
                    break;
            }

            return r;
        }
    }
}
