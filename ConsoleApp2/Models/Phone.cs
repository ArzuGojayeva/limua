using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkarma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");
                Console.WriteLine("5. Karekök");
                Console.WriteLine("6. Üs alma");
                Console.WriteLine("7. Faktöriyel");
                Console.WriteLine("8. Trigonometrik Fonksiyonlar");
                Console.WriteLine("9. Logaritma");
                Console.WriteLine("10. Mod Alma");
                Console.WriteLine("11. Çıkış");

                Console.Write("Seçiminizi yapın (1/2/3/4/5/6/7/8/9/10/11): ");
                string secim = Console.ReadLine();

                if (secim == "11")
                {
                    Console.WriteLine("Hesap makinesi kapatılıyor...");
                    break;
                }

                double sayi1, sayi2, sonuc;
                switch (secim)
                {
                    case "1":
                        sayi1 = SayiGir("Birinci sayıyı girin: ");
                        sayi2 = SayiGir("İkinci sayıyı girin: ");
                        sonuc = sayi1 + sayi2;
                        SonucuGoster(sonuc);
                        break;

                    case "2":
                        sayi1 = SayiGir("Birinci sayıyı girin: ");
                        sayi2 = SayiGir("İkinci sayıyı girin: ");
                        sonuc = sayi1 - sayi2;
                        SonucuGoster(sonuc);
                        break;

                    case "3":
                        sayi1 = SayiGir("Birinci sayıyı girin: ");
                        sayi2 = SayiGir("İkinci sayıyı girin: ");
                        sonuc = sayi1 * sayi2;
                        SonucuGoster(sonuc);
                        break;

                    case "4":
                        sayi1 = SayiGir("Birinci sayıyı girin: ");
                        sayi2 = SayiGir("İkinci sayıyı girin: ");
                        if (sayi2 == 0)
                        {
                            Console.WriteLine("Hata: Sıfıra bölme!");
                        }
                        else
                        {
                            sonuc = sayi1 / sayi2;
                            SonucuGoster(sonuc);
                        }
                        break;

                    case "5":
                        sayi1 = SayiGir("Karekökünü almak istediğiniz sayıyı girin: ");
                        if (sayi1 <


