using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2A_sayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // bu adımda tahmin edilecek sayı random olarak üretiliyor
            Random rastgeleSayiUretici = new Random();
            int uretilenSayi = rastgeleSayiUretici.Next(1, 100);

            try
            {
                // sonsuz döngü, kullanıcı tekrar oynamak istemeyene kadar oyun baştan başlayacak
                while (true)
                {
                    // sonsuz döngü, kullanıcı sayıyı doğru tahmin edene kadar durmayacak
                    while (true)
                    {
                        Console.WriteLine("Tahmininizi giriniz=");
                        int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                        if (uretilenSayi > tahminEdilenSayi)
                        {
                            Console.WriteLine("Yukarı!");
                        }
                        else if (uretilenSayi < tahminEdilenSayi)
                        {
                            Console.WriteLine("Aşağı!");
                        }
                        else
                        {
                            Console.WriteLine("Eşittir");
                            break; // kullanıcı sayıyı doğru tahmin ettiğinde bu anahtar kelime sayesinde döngüden çıkılır
                        }

                    }
                    Console.WriteLine("Tekrar oynamak ister misiniz? (evet/hayır)");
                    string cevap = Console.ReadLine();
                    if (cevap == "evet")
                    {
                        Console.Clear();
                        uretilenSayi = rastgeleSayiUretici.Next(1, 100);
                    }
                    else
                    {
                        Console.WriteLine("Yine bekleriz!");
                        break; // kullanıcı oynamak istemediğinde bu anahtar kelime sayesinde döngüden çıkılır ve oyun sonlandırılır
                    }
                }
            }
            catch(Exception hata)
            {
                Console.WriteLine("Bir hata oluştu = " + hata);
            }
            Console.ReadLine();

        }
    }
}
