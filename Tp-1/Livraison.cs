using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    class Livraison
    {
        private int poids;
        private int volume;

        public Livraison(int volume_, int poids_)
        {
            volume = volume_;
            poids = poids_;
        }

        public Livraison(Livraison livraison_a_copier)
        {
            volume = livraison_a_copier.Volume;
            poids = livraison_a_copier.Poids;
        }

        public int Volume { get => volume; set => volume = value; }
        public int Poids { get => poids; set => poids = value; }

        public override string ToString()
        {
            return "Livraison de " + poids.ToString() + " LB avec un volume de " + Volume.ToString();
        }
    }
}
