using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();   /* Başlangıç */

            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    {
                        Console.WriteLine("Ocak Ayı");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Mart Ayı");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Şubat Ayı");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Haziran Ayı");
                        break;
                    }
                default:
                        Console.WriteLine("Uygun case bulunmuyor!");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    {
                        Console.WriteLine("Kış Mevsimindesiniz...");
                        break;
                    }
                case 6:
                case 7:
                case 8:
                    {
                        Console.WriteLine("Yaz Mevsimindesiniz...");
                        break;
                    }
                default:
                        Console.WriteLine("Uygun case bulunmuyor!");
                    break;
            }

            Console.WriteLine();   /* Bitiş */
        }
    }
}
