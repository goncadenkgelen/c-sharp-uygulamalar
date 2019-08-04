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

        public static int AsagiYuvarla(double sayi)
        {
            int yuvarlanmisSayi = (int)(sayi);

            return yuvarlanmisSayi;
        }

        public static int YukariYuvarla(double sayi)
        {
            int yuvarlanmisSayi = (int)(sayi + 1);

            return yuvarlanmisSayi;
        }

        public static int Yuvarla(double sayi)
        {
            int yuvarlanmisSayi = (int)(sayi + 0.5);

            return yuvarlanmisSayi;
        }

        static void Main(string[] args)
        {
            EkranaYaz("Sayı : ");
            double sayi = Oku();

            EkranaYaz($"Yuvarla: {Yuvarla(sayi)}");
            EkranaYaz($"Aşağı Yuvarla: {AsagiYuvarla(sayi)}");
            EkranaYaz($"Yukarı Yuvarla: {YukariYuvarla(sayi)}");
        }
    }
}
