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
    public partial class Form_ajouter_camion : Form
    {

        // transfert du volume_max et du poids_max du camion vers le main_form
        public delegate void Transfert_camion(int volume_max_, int poids_max_);
        public event Transfert_camion Transfert_camion_event;

        public Form_ajouter_camion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtbox_volume_maximal_camion.Text == "" || txtbox_poids_maximal_camion.Text == "")
            {
                if (txtbox_volume_maximal_camion.Text == "")
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
                if (int.TryParse(txtbox_volume_maximal_camion.Text, out int volume_max))
                {
                    if (int.TryParse(txtbox_poids_maximal_camion.Text, out int poids_max))
                    {
                        Transfert_camion_event(volume_max, poids_max);
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
