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

        BindingSource binding_combox_camionneurs = new BindingSource();
        BindingSource binding_combox_camions = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            binding_combox_camionneurs.DataSource = liste_camionneurs;
            comBoxCamionneur.DataSource = binding_combox_camionneurs;

            binding_combox_camions.DataSource = liste_camions;
            comBoxCamion.DataSource = binding_combox_camions;
        }




        // ---   A J O U T   C A M I O N N E U R   ---

        private void camionneur_top_menu_Click(object sender, EventArgs e)
        {
            Form_ajouter_camionneur form_ajouter_camionneur = new Form_ajouter_camionneur();
            form_ajouter_camionneur.Transfert_camionneur_event += transfert_camionneur_event;
            form_ajouter_camionneur.Show();
        }

        void transfert_camionneur_event(string nom, string prenom)
        {
            liste_camionneurs.Add(new Camionneur(nom, prenom));
            binding_combox_camionneurs.ResetBindings(false);
        }

        private void camion_top_menu_Click(object sender, EventArgs e)
        {
            Form_ajouter_camion form_ajouter_camion = new Form_ajouter_camion();
            form_ajouter_camion.Transfert_camion_event += transfert_camion_event;
            form_ajouter_camion.Show();
        }

        void transfert_camion_event(int volume_max_, int poids_max_)
        {
            liste_camions.Add(new Camion(volume_max_, poids_max_));
            binding_combox_camions.ResetBindings(false);
        }
    }
}
