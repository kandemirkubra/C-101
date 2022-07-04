using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // string ifadeler

            string str1 = string.Empty;
            str1 = "Kübra Kandemir";
            string ad = "Kübra";
            string soyad = "Kandemir";
            string tamIsım = ad + " " + soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //Degisken Dönüsümleri

            string str20 = "20";
            int int20 = 20;

            string yediDeger = str20 + int20.ToString();
            Console.WriteLine("string Toplama: " + yediDeger);

            int yepYenideDeger = int20 + Convert.ToInt32(str20);
            Console.WriteLine("int Toplama: "+ yepYenideDeger);

            int int22 = int20 + int.Parse(str20);
            Console.WriteLine("string to int Parse kullanımı: " + int22);

            // dateTime
            
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime1);

            string hour = DateTime.Now.ToString("HH.MM");
            Console.WriteLine(hour);

        }
    }
}
