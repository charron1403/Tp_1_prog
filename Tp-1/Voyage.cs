using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    class Voyage
    {
        private string nom_voyage;
        private DateTime date_selectionne;
        private Camion camion_selectionne;
        private Camionneur camionneur_selectionne;
        private List<Livraison> list_livraisons_selectionne = new List<Livraison>();
    }
}
