using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace or096
{
    class Program
    {
        public static void Main(string[] args)
        {
            double[] a = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

            int b = 0;
            foreach (double burs in a)
            {
                if (burs < 500)
                {
                    double yeniBurs = (burs * 0.1) + burs + 50;
                    Console.WriteLine(yeniBurs);
                }
                else
                {
                    Console.WriteLine(burs);
                }
                b++;
            }

            Console.Write("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ. . . ");
            Console.ReadKey(true);
        }
    }
}
