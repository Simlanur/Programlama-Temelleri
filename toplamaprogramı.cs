using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToplamaProgrami
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayi;

            Console.WriteLine("Sayıları toplamak için 83 girin.");

            while (true)
            {
                Console.Write("Bir sayı girin: ");
                if (int.TryParse(Console.ReadLine(), out sayi))
                {
                    toplam += sayi;

                    if (sayi == 83)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir sayı girmediniz. Lütfen tekrar deneyin.");
                }
            }

            Console.WriteLine($"Toplam = {toplam}");
        }
    }
}