using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SayiToplamOrtalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı gireceksiniz? ");
            if (int.TryParse(Console.ReadLine(), out int adet))
            {
                if (adet <= 0)
                {
                    Console.WriteLine("Geçerli bir adet girmelisiniz.");
                    return;
                }

                int toplam = 0;

                for (int i = 1; i <= adet; i++)
                {
                    Console.Write($"{i}. sayıyı girin: ");
                    if (int.TryParse(Console.ReadLine(), out int sayi))
                    {
                        toplam += sayi;
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir sayı girmediniz. Program sonlandırılıyor.");
                        return;
                    }
                }

                double ortalama = (double)toplam / adet;

                Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
                Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı adeti girmediniz. Program sonlandırılıyor.");
            }
        }
    }
}
