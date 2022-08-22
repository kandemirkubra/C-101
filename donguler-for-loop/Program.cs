using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            /* Ekrandan girilen sayıya kadar tek olan sayıları yazdır */
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            /* 1 ile 1000 arasındaki tek ve cift sayıların kendi içlerindeki toplanlarını ekrana yazdır. */
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }
            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);


            //Döngü sonlandırmak için break kullanılır.
            //İterasyonu sonlandırmak için continue kullanılır.

            for (int i = 0; i < 10; i++)
            {
                if(i == 4){
                    break;
                }
                Console.WriteLine(i);  //output: 0 1 2 3 
            }

            for (int i = 0; i < 10; i++)
            {
                if(i == 4){
                    continue;
                }
                Console.WriteLine(i);  //output: 0 1 2 3 5 6 7 8 9 
            }


            Console.WriteLine();
        }
    }
}
