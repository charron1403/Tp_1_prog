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
    }
}
