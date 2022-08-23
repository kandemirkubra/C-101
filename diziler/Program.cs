using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dizi Tanımlama */
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymunlar"};

            int[] dizi;
            dizi = new int[5];

            /* Dizilere Değer Atama ve Erişim */
            renkler[0] = "Mavi";
            Console.WriteLine(hayvanlar[1]);
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            /* Döngülerde dizi kullanımı */ 
            // Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyıyı giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: " + toplam / diziUzunlugu );

        }
    }
}
