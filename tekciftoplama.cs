using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TekCiftToplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out int sayi))
            {
                Console.Write("TEK’leri mi ÇİFT’leri mi toplamak istersiniz? (TEK/ÇİFT): ");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "TEK" || secim == "ÇİFT")
                {
                    int toplam = 0;

                    for (int i = 1; i <= sayi; i++)
                    {
                        if ((secim == "TEK" && i % 2 != 0) || (secim == "ÇİFT" && i % 2 == 0))
                        {
                            toplam += i;
                        }
                    }

                    Console.WriteLine($"{sayi}'e kadar olan {secim} sayıların toplamı: {toplam}");
                }
                else
                {
                    Console.WriteLine("Geçerli bir seçim yapmadınız (TEK/ÇİFT).");
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girmediniz.");
            }
        }
    }
}