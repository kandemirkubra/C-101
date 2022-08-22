using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();


            // while 
            /* 1 den başlayarak konsoldan girilen sayıya kadar ortalama hesaplayıp konsola yazdıran program */
            Console.Write("Ortamasını bulmak istediğin sayi dizesinin en büyük elemanını yaz bakalım: ");

            int sayi = int.Parse(Console.ReadLine().Trim());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac += 1;
            }

            if (sayi != 0)
                Console.WriteLine("Ortalama: " + toplam / sayi);

            /* 'a' dan 'z' ye kadar olan tüm harfleri console a yazdır.  */
            char character = 'a';
            Console.Write("Characters => ");
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine();

            // foreach
            string[] arabalar = { "BMV ", "Ford ", "Seat ", "Volvo " };
            foreach (var araba in arabalar)
            {
                Console.Write(araba);
            }

            Console.WriteLine();
        }
    }
}
