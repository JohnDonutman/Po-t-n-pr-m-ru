using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Počítání_průměru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik čísel budeme průměrovat:");
            int vsechnaCisla = int.Parse(Console.ReadLine());
            int[] cislaPole = new int[vsechnaCisla];
            Console.WriteLine("Piš čísla:");
            for (int i = 0; i < cislaPole.Length; i++)
            {
                int cislo = int.Parse(Console.ReadLine());
                cislaPole[i] = cislo;
            }
            int soucet = 0;
            Console.WriteLine("Vaše zadaná čísla jsou: ");
            for (int i = 0; i < cislaPole.Length; i++)
            {
                Console.Write("{0} ", cislaPole[i]);
                soucet += cislaPole[i];
            }
            Console.WriteLine();
            int prumer = soucet / cislaPole.Length;
            Console.WriteLine("Průměr těchto čísel je: {0}", prumer);
        }
    }
}
