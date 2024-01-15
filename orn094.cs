using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace or094
{
    class Program
    {
        public static void Main(string[] args)
        {
            int b;

            Console.Write("Bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out b))
            {
                string s = "Sayı Asal Sayı";

                if (b < 2)
                {
                    s = "Sayı Asal Sayı Değil";
                }
                else
                {
                    for (int a = 2; a <= Math.Sqrt(b); a++)
                    {
                        if (b % a == 0)
                        {
                            s = "Sayı Asal Sayı Değil";
                            break;
                        }
                    }
                }

                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girmediniz.");
            }

            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}