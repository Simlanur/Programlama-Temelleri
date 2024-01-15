using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace or211
{
    class Program
    {
        public static void Main(string[] args)
        {
            int c;
            int EnBuyuk = int.MinValue;
            int EnDusuk = int.MaxValue;
            string[] A = { "Emin", "Emir", "İclal", "Bekir", "Cem", "Arda", "Kaan", "Metin", "Can", "Ramiz" };
            int[] B = { 56, 78, 95, 23, 95, 87, 61, 77, 45, 33 };

            for (c = 0; c <= B.Length - 1; c++)
            {
                if (B[c] >= EnBuyuk)
                {
                    if (B[c] > EnBuyuk)
                    {
                        EnBuyuk = B[c];
                    }
                    else
                    {
                        // Aynı en yüksek notu alan başka bir kişi varsa
                        Console.WriteLine("En Yüksek Notu Alan Kişi: " + A[c]);
                    }
                }

                if (B[c] <= EnDusuk)
                {
                    if (B[c] < EnDusuk)
                    {
                        EnDusuk = B[c];
                    }
                    else
                    {
                        // Aynı en düşük notu alan başka bir kişi varsa
                        Console.WriteLine("En Düşük Notu Alan Kişi: " + A[c]);
                    }
                }
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}