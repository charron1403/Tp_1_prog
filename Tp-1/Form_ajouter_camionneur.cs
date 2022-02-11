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
    public partial class Form_ajouter_camionneur : Form
    {
        // transfert du nom et du prénom du camionneur vers le main_form
        public delegate void Transfert_camionneur(String nom, String prenom);
        public event Transfert_camionneur Transfert_camionneur_event;

        public Form_ajouter_camionneur()
        {
            InitializeComponent();
        }

        private void btn_ajouter_camioneur_Click(object sender, EventArgs e)
        {
            if (txtbox_nom_camionneur.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nom");
            }
            else if (txtbox_prenom_camionneur.Text == "")
            {
                MessageBox.Show("Veuillez entrer un prenom");
            }
            else
            {
                Transfert_camionneur_event(txtbox_nom_camionneur.Text, txtbox_prenom_camionneur.Text);
                Close();
            }
        }
    }
}
