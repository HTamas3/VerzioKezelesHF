using System;
using System.Linq;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg mennyi szám legyen!");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] szamok = new int[szam];
            Console.WriteLine("Adj meg {0} számot", szam);
            for(int i=0; i<szam; i++)
            {
                Console.Write("{0} szám: ",i+1);
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }
            int osszeg = 0;
            for(int i=0; i<szam; i++)
            {
                osszeg = osszeg + szamok[i];
            }
            Console.WriteLine("Átlag: {0}", osszeg / szam);
            int max = szamok.Max();
            int min = szamok.Min();
            Console.WriteLine("Maximum:" + max);
            Console.WriteLine("Minimum:" + min);
            
            Console.ReadLine();
        }
    }
}
