using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    class Camion
    {
        private int volume_max;
        private int poids_max;

        public int Volume_max { get => volume_max; }
        public int Poids_max { get => poids_max; }

        public Camion(int volume_max_, int poids_max_)
        {
            volume_max = volume_max_;
            poids_max = poids_max_;
        }

        public override string ToString()
        {
            return "Camion: poids: " + poids_max.ToString() + ", volume de " + volume_max.ToString();
        }
    }
}
