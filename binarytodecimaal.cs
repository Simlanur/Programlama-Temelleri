using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İkili (Binary) Sayı Girin: ");
            string ikiliSayiStr = Console.ReadLine();

            if (IsBinary(ikiliSayiStr))
            {
                int ikiliSayi = Convert.ToInt32(ikiliSayiStr);
                int onluDeger = 0;
                int tabanDeger = 1;

                while (ikiliSayi > 0)
                {
                    int basamakDeger = ikiliSayi % 10;
                    onluDeger += basamakDeger * tabanDeger;
                    ikiliSayi = ikiliSayi / 10;
                    tabanDeger = tabanDeger * 2;
                }

                Console.WriteLine($"Onlu (Decimal) Sayı: {onluDeger}");
            }
            else
            {
                Console.WriteLine("Geçerli bir ikili sayı girmediniz.");
            }

            Console.ReadLine();
        }

        static bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
