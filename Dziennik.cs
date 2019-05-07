using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzienniczek
{
    class Dziennik
    {
        List<float> ratings = new List<float>();

        public Dziennik()//konstruktor
        {

        }

        public void dodajOcene(float ocena)
        {
            ratings.Add(ocena);
        }

        public float sredniaOcen()
        {
            float avg = 0, sum = 0;

            foreach (var ocena in ratings)
            {
                sum += ocena;
            }
            avg = sum / ratings.Count;
            return avg;
        }

        public float minRating()
        {
            return ratings.Min();
        }

        public float maxRating()
        {
            return ratings.Max();
        }
    }
}
