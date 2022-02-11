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
    public partial class Form1 : Form
    {
        List<Camionneur> liste_camionneurs = new List<Camionneur>();
        List<Camion> liste_camions = new List<Camion>();
        List<Livraison> liste_livraisons = new List<Livraison>();
        List<Voyage> liste_voyages = new List<Voyage>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void camionneur_top_menu_Click(object sender, EventArgs e)
        {
            Form_ajouter_camionneur form_ajouter_camionneur = new Form_ajouter_camionneur();
            form_ajouter_camionneur.ShowDialog();
        }
    }
}
