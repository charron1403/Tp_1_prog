using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    class Voyage
    {
        private DateTime date_selectionne;
        private Camion camion_selectionne;
        private Camionneur camionneur_selectionne;
        private List<Livraison> list_livraisons_selectionne = new List<Livraison>();
        private int distance;
        private int position_voyage_liste;

        public Voyage(int position_voyage_liste_)
        {
            Date_selectionne = DateTime.Now;
            position_voyage_liste = position_voyage_liste_;
        }

        public DateTime Date_selectionne { get => date_selectionne; set => date_selectionne = value; }
        public int Distance { get => distance; set => distance = value; }
        internal Camion Camion_selectionne { get => camion_selectionne; set => camion_selectionne = value; }
        internal Camionneur Camionneur_selectionne { get => camionneur_selectionne; set => camionneur_selectionne = value; }
        internal List<Livraison> List_livraisons_selectionne { get => list_livraisons_selectionne; set => list_livraisons_selectionne = value; }

        public override string ToString()
        {
            return "Voyage #" + position_voyage_liste.ToString();
        }

        public string Verifier_avant_ajout_livraison(Livraison livraison_selection)
        {
            int poids_ = 0;
            int volume_ = 0;
            foreach (Livraison livraison_ in list_livraisons_selectionne)
            {
                poids_ += livraison_.Poids;
                volume_ += livraison_.Volume;

            }

            poids_ += livraison_selection.Poids;
            volume_ += livraison_selection.Volume;

            if (poids_ <= camion_selectionne.Poids_max && volume_ <= camion_selectionne.Volume_max)
            {
                return "ok";
            }
            else
            {
                if(poids_ <= camion_selectionne.Poids_max && volume_ > camion_selectionne.Volume_max)
                {
                    return "volume";
                }
                else
                {
                    return "poids";
                }
            }
        }

    }
}
