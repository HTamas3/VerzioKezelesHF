using System;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            Console.WriteLine("Adj meg 10 számot");
            for(int i=0; i<10; i++)
            {
                Console.Write("{0} szám: ",i+1);
                szamok[i] = Convert.ToInt32(Console.ReadLine());
            }
            int osszeg = 0;
            for(int i=0; i<10; i++)
            {
                osszeg = osszeg + szamok[i];
            }
            Console.WriteLine("Átlag: {0}", osszeg/10);
            Console.ReadLine();
        }
    }
}
