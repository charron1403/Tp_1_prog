using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    class Camionneur
    {
        private string nom;
        private string prenom;

        public string Nom { get => nom;}
        public string Prenom { get => prenom;}

        public Camionneur(string nom_, string prenom_)
        {
            nom = nom_;
            prenom = prenom_;
        }

        public override string ToString()
        {
            return prenom.ToString() + " " + nom.ToString();
        }
    }
}
