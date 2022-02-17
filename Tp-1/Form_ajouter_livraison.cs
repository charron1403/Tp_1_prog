using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_1
{
    public partial class Form_ajouter_livraison : Form
    {
        // transfert du volume_max et du poids_max du camion vers le main_form
        public delegate void Transfert_livraison(int volume_, int poids_);
        public event Transfert_livraison Transfert_livraison_event;
        public Form_ajouter_livraison()
        {
            InitializeComponent();
        }

        private void btn_ajouter_livraison_Click(object sender, EventArgs e)
        {
            if (txt_Poids.Text == "" || txt_Volume.Text == "")
            {
                if (txt_Volume.Text == "")
                {
                    MessageBox.Show("Veuillez entrer un volume", "AVERTISSEMENT");
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un poids", "AVERTISSEMENT");

                }
            }
            else
            {
                if (int.TryParse(txt_Volume.Text, out int volume))
                {
                    if (int.TryParse(txt_Poids.Text, out int poids))
                    {
                        Transfert_livraison_event(volume, poids);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer un poids [ nombre entier ] valide", "ERREUR");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un volume [ nombre entier ] valide", "ERREUR");
                }
            }
        }
    }
}
