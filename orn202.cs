using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace or202
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] B = new int[5];
            int a = 0, say = 0, toplam = 0;
            double ortalama = 0;

            foreach (int al in B)
            {
                Console.Write(a + ". Elemanı Gir: ");
                B[a] = Int32.Parse(Console.ReadLine());

                if (B[a] % 10 == 0)
                {
                    say++;
                    toplam += B[a];
                }

                a++;
            }

            if (say > 0)
            {
                ortalama = (double)toplam / say;
                Console.WriteLine("Son Rakamı Sıfır Olan Sayı Adedi: " + say);
                Console.WriteLine("Toplamı: " + toplam);
                Console.WriteLine("Ortalaması: " + ortalama);
            }
            else
            {
                Console.WriteLine("Son rakamı sıfır olan bir sayı girilmedi.");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
