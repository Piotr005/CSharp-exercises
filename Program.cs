using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzienniczek
{
    class Program
    {
        static void Main(string[] args)
        {
            Dziennik dziennik1 = new Dziennik();
           
            for(; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1- 6");
                float ocena;
                bool result = float.TryParse(Console.ReadLine(), out ocena);

                if (ocena == 7) break;
                if (result) dziennik1.dodajOcene(ocena);
            }
            Console.WriteLine("Średnia ocen to: "+dziennik1.sredniaOcen());
            Console.WriteLine("Najniższa ocena to: "+dziennik1.minRating());
            Console.WriteLine("Najwyższa ocena to: "+dziennik1.maxRating());


        }
    }
}
