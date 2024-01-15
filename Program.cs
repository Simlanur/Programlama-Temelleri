using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace İkiSayıToplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İki sayı girin (ayrı ayrı): ");

            if (int.TryParse(Console.ReadLine(), out int sayi1) && int.TryParse(Console.ReadLine(), out int sayi2))
            {
                Console.Write("TEK’leri mi ÇİFT’leri mi toplamak istersiniz? (TEK/ÇİFT): ");
                string secim = Console.ReadLine().ToUpper();

                if (secim == "TEK" || secim == "ÇİFT")
                {
                    int toplam = 0;

                    int baslangic = Math.Min(sayi1, sayi2);
                    int bitis = Math.Max(sayi1, sayi2);

                    for (int i = baslangic; i <= bitis; i++)
                    {
                        if ((secim == "TEK" && i % 2 != 0) || (secim == "ÇİFT" && i % 2 == 0))
                        {
                            toplam += i;
                        }
                    }

                    Console.WriteLine($"{sayi1} ile {sayi2} arasındaki {secim} sayıların toplamı: {toplam}");
                }
                else
                {
                    Console.WriteLine("Geçerli bir seçim yapmadınız (TEK/ÇİFT).");
                }
            }
            else
            {
                Console.WriteLine("Geçerli sayılar girmediniz.");
            }
        }
    }
}
