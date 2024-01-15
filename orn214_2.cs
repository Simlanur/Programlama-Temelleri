using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace or214
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sayi;
            string s = " ";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yuzler = { "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };

            Console.Write("Bir Sayı Giriniz (1-999): ");
            sayi = int.Parse(Console.ReadLine());

            if (sayi < 1 || sayi > 999)
            {
                Console.WriteLine("Geçerli bir sayı girmediniz.");
            }
            else
            {
                int birler = sayi % 10;
                int onlar = (sayi / 10) % 10;
                int yuzler = sayi / 100;

                if (yuzler > 0)
                {
                    s = Yuzler[yuzler - 1];
                }

                if (onlar > 0)
                {
                    s += Onlar[onlar - 1];
                }

                if (birler > 0)
                {
                    s += Birler[birler - 1];
                }

                Console.WriteLine(s);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
