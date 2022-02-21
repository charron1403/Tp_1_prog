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
        BindingSource binding_listbox_livraisons = new BindingSource();
        BindingSource binding_listbox_voyages = new BindingSource();

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

            binding_listbox_livraisons.DataSource = liste_livraisons;
            lst_livraisons_non_assignees.DataSource = binding_listbox_livraisons;

            binding_listbox_voyages.DataSource = liste_voyages;
            lst_voyages.DataSource = binding_listbox_voyages;



            actualiser_visibilite_voyage_parametres();

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

        // ---   A J O U T   C A M I O N   ---

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

       
        //  ---  L I V R A I S O N   A J O U T ---  
        private void livraison_top_menu_Click(object sender, EventArgs e)
        {
            Form_ajouter_livraison form_ajouter_livraison = new Form_ajouter_livraison();
            form_ajouter_livraison.Transfert_livraison_event += transfert_livraison_event;
            form_ajouter_livraison.ShowDialog();

        }

        void transfert_livraison_event(int volume, int poids)
        {
            liste_livraisons.Add(new Livraison(volume, poids));
            binding_listbox_livraisons.ResetBindings(false);
        }
        // --- V O Y A G E   A J O U T ---
        private void voyage_top_menu_Click(object sender, EventArgs e)
        {
            liste_voyages.Add(new Voyage(liste_voyages.Count + 1));
            binding_listbox_voyages.ResetBindings(false);
            actualiser_visibilite_voyage_parametres();
        }










        // --- E D I T   V O Y A G E S ---

        private void lst_voyages_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualiser_visibilite_voyage_parametres();
        }


        private void actualiser_visibilite_voyage_parametres()
        {
            if (lst_voyages.SelectedItem == null)
            {
                voyage_selectionne_gBox.Visible = false;
                voyage_selectionne_gBox.Enabled = false;
                btn_ajouter.Enabled = false;
                btn_retirer.Enabled = false;
            }
            else
            {
                voyage_selectionne_gBox.Visible = true;
                voyage_selectionne_gBox.Enabled = true;
                btn_ajouter.Enabled = true;
                btn_retirer.Enabled = true;
            }
        }

    }
}

