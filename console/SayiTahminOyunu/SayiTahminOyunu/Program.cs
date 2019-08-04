using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int kHak = 3;
            int oHak = 5;
            int zHak = 7;
            string isim = "";
            double puan = 0;
            string[] isimler = new string[3];
            double[] puanlar = new double[3];
            Random rnd = new Random();

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Adınızı Giriniz: ");
                isim = Console.ReadLine();
                isimler[j] = isim;

                Console.WriteLine("Seviye Seçiniz: \n1-)Kolay \n2-)Orta \n3-)Zor");
                int seviye = Convert.ToInt32(Console.ReadLine());

                switch (seviye)
                {
                    case 1:
                        Console.WriteLine("3 Hakkınız var");
                        int rndSayi1 = rnd.Next(1, 6);
                        for (int i = 1; i < 4; i++)
                        {
                            Console.WriteLine($"Sayı Giriniz: {rndSayi1}");
                            int girilenSayi = Convert.ToInt32(Console.ReadLine());

                            if (girilenSayi == rndSayi1)
                            {
                                puan = 10 / i;

                                Console.WriteLine($"Tebrikler Bildiniz :) {puan}");
                                break;
                            }
                            kHak--;
                            Console.WriteLine($"Kalan Hakkınız : {kHak}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("5 Hakkınız var");
                        int rndSayi2 = rnd.Next(1, 11);
                        for (int i = 1; i < 6; i++)
                        {
                            Console.WriteLine($"Sayı Giriniz: {rndSayi2}");
                            int girilenSayi = Convert.ToInt32(Console.ReadLine());

                            if (girilenSayi == rndSayi2)
                            {
                                puan = 20 / i;

                                Console.WriteLine($"Tebrikler Bildiniz :) {puan}");
                                break;
                            }
                            oHak--;
                            Console.WriteLine($"Kalan Hakkınız : {oHak}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("7 Hakkınız var");
                        int rndSayi3 = rnd.Next(1, 26);
                        for (int i = 1; i < 8; i++)
                        {
                            Console.WriteLine($"Sayı Giriniz: {rndSayi3}");
                            int girilenSayi = Convert.ToInt32(Console.ReadLine());

                            if (girilenSayi == rndSayi3)
                            {
                                puan = 30 / i;

                                Console.WriteLine($"Tebrikler Bildiniz :) {puan}");
                                break;
                            }
                            zHak--;
                            Console.WriteLine($"Kalan Hakkınız : {zHak}");
                        }
                        break;
                }


                puanlar[j] = puan;

            }

            foreach (double puanx in puanlar)
            {
                Console.WriteLine(puanx);
            }

            foreach (string isimx in isimler)
            {
                Console.WriteLine(isimx);
            }



            Console.ReadLine();
        }
    }
}
