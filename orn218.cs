﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace or218
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string[] il = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
            string[] isim = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };
            bool[] D = new bool[7];

            for (a = 0; a <= 6; a++)
                Console.WriteLine("Bool D dizisinin " + a + ". elemanı= " + D[a]);

            Random rastgele = new Random();

            for (a = 0; a <= 6; a++)
            {
                int sayi;
                do
                {
                    sayi = rastgele.Next(0, 7); // 0 dahil, 7 dahil değil.
                } while (D[sayi] == true);

                D[sayi] = true;
                Console.WriteLine(isim[a] + "\t= " + il[sayi]);
            }

            for (a = 0; a <= 6; a++)
                Console.WriteLine("Bool D dizisinin " + a + ". elemanı= " + D[a]);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}