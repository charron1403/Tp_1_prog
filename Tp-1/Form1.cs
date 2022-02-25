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
        BindingSource binding_listbox_livraisons_assignees = new BindingSource();

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



            liste_voyages.Add(new Voyage(liste_voyages.Count + 1));
            liste_voyages.Add(new Voyage(liste_voyages.Count + 1));

            liste_livraisons.Add(new Livraison(450, 700));
            liste_livraisons.Add(new Livraison(400, 120));
            liste_livraisons.Add(new Livraison(65, 40));
            liste_livraisons.Add(new Livraison(250, 300));

            liste_camions.Add(new Camion(1200, 950));
            liste_camions.Add(new Camion(500, 160));
            liste_camions.Add(new Camion(315, 350));
            liste_camions.Add(new Camion(70, 50));

            liste_camionneurs.Add(new Camionneur("Paté", "Marina"));
            liste_camionneurs.Add(new Camionneur("Bozo", "Leclown"));
            liste_camionneurs.Add(new Camionneur("Gagnon", "Alex"));

            binding_combox_camionneurs.ResetBindings(false);
            binding_combox_camions.ResetBindings(false);
            binding_listbox_livraisons.ResetBindings(false);
            binding_listbox_voyages.ResetBindings(false);

            comBoxCamionneur.SelectedItem = null;
            comBoxCamion.SelectedItem = null;
            lst_voyages.SelectedItem = null;
            lst_livraisons_non_assignees.SelectedItem = null;




            Actualiser_visibilite_voyage_parametres();



        }




        // ---   A J O U T   C A M I O N N E U R   ---

        private void camionneur_top_menu_Click(object sender, EventArgs e)
        {
            Form_ajouter_camionneur form_ajouter_camionneur = new Form_ajouter_camionneur();
            form_ajouter_camionneur.Transfert_camionneur_event += Transfert_camionneur_event;
            form_ajouter_camionneur.Show();
        }

        void Transfert_camionneur_event(string nom, string prenom)
        {
            liste_camionneurs.Add(new Camionneur(nom, prenom));
            binding_combox_camionneurs.ResetBindings(false);
        }

        // ---   A J O U T   C A M I O N   ---

        private void camion_top_menu_Click(object sender, EventArgs e)
        {
            Form_ajouter_camion form_ajouter_camion = new Form_ajouter_camion();
            form_ajouter_camion.Transfert_camion_event += Transfert_camion_event;
            form_ajouter_camion.Show();
        }

        void Transfert_camion_event(int volume_max_, int poids_max_)
        {
            liste_camions.Add(new Camion(volume_max_, poids_max_));
            binding_combox_camions.ResetBindings(false);
        }

       
        //  ---  L I V R A I S O N   A J O U T ---  
        private void livraison_top_menu_Click(object sender, EventArgs e)
        {
            Form_ajouter_livraison form_ajouter_livraison = new Form_ajouter_livraison();
            form_ajouter_livraison.Transfert_livraison_event += Transfert_livraison_event;
            form_ajouter_livraison.ShowDialog();
        }

        void Transfert_livraison_event(int volume, int poids)
        {
            liste_livraisons.Add(new Livraison(volume, poids));
            binding_listbox_livraisons.ResetBindings(false);
        }

       






        // --- V O Y A G E   A J O U T ---
        private void voyage_top_menu_Click(object sender, EventArgs e)
        {
            liste_voyages.Add(new Voyage(liste_voyages.Count + 1));
            binding_listbox_voyages.ResetBindings(false);
            Actualiser_visibilite_voyage_parametres();
        }










        // --- E D I T   V O Y A G E S ---

        private void lst_voyages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actualiser_visibilite_voyage_parametres();
            binding_listbox_livraisons_assignees.ResetBindings(false);
        }


        private void Actualiser_visibilite_voyage_parametres()
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
                binding_listbox_livraisons_assignees.DataSource = liste_voyages[lst_voyages.SelectedIndex].List_livraisons_selectionne;
                lst_livraisons_incluses.DataSource = binding_listbox_livraisons_assignees;

                dTP_selection.Value = liste_voyages[lst_voyages.SelectedIndex].Date_selectionne;
                comBoxCamion.SelectedItem = liste_voyages[lst_voyages.SelectedIndex].Camion_selectionne;
                comBoxCamionneur.SelectedItem = liste_voyages[lst_voyages.SelectedIndex].Camionneur_selectionne;
                txtbox_distance.Text = liste_voyages[lst_voyages.SelectedIndex].Distance.ToString();
            }
        }



       //  verification distance

        private void txtbox_distance_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(txtbox_distance.Text, out double distance_))
            {
                if (int.TryParse(txtbox_distance.Text, out int distance_int))
                {
                    if (distance_int >= 0)
                    {
                        liste_voyages[lst_voyages.SelectedIndex].Distance = distance_int;
                    }
                    else
                    {
                        MessageBox.Show("Nombres négatifs non-acceptés: Veuillez entrer un nombre positif", "Erreur");
                        txtbox_distance.Text = liste_voyages[lst_voyages.SelectedIndex].Distance.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nombres à virgule non-acceptés : Veuillez entrer un nombre entier", "Erreur");
                    txtbox_distance.Text = liste_voyages[lst_voyages.SelectedIndex].Distance.ToString();
                }
            }
            else
            {
                MessageBox.Show("Caratères non-gérés : veuillez entrer SEULEMENT DES NOMBRES", "Erreur");
                txtbox_distance.Text = liste_voyages[lst_voyages.SelectedIndex].Distance.ToString();
            }
        }


        // changement date
        private void dTP_selection_ValueChanged(object sender, EventArgs e)
        {
            liste_voyages[lst_voyages.SelectedIndex].Date_selectionne = dTP_selection.Value;
        }


        //changement camionneur
        private void comBoxCamionneur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comBoxCamionneur.SelectedItem != null)
            {
                liste_voyages[lst_voyages.SelectedIndex].Camionneur_selectionne = liste_camionneurs[comBoxCamionneur.SelectedIndex];
            }
        }


        // changement camion
        private void comBoxCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comBoxCamion.SelectedItem != null)
            {
                if (liste_voyages[lst_voyages.SelectedIndex].Camionneur_selectionne != null)
                {
                    if(liste_voyages[lst_voyages.SelectedIndex].Verifier_avant_changement_camion(liste_camions[comBoxCamion.SelectedIndex]) == "ok")
                    {
                        liste_voyages[lst_voyages.SelectedIndex].Camion_selectionne = liste_camions[comBoxCamion.SelectedIndex];
                    }
                    else if (liste_voyages[lst_voyages.SelectedIndex].Verifier_avant_changement_camion(liste_camions[comBoxCamion.SelectedIndex]) == "poids")
                    {
                        MessageBox.Show("Changement de camion impossible: poids maximum inférieur au poids total des livraisons sélectionnées", "Erreur");
                        comBoxCamion.SelectedItem = liste_voyages[lst_voyages.SelectedIndex].Camion_selectionne;
                    }
                    else if (liste_voyages[lst_voyages.SelectedIndex].Verifier_avant_changement_camion(liste_camions[comBoxCamion.SelectedIndex]) == "volume")
                    {
                        MessageBox.Show("Changement de camion impossible: volume maximum inférieur au volume total des livraisons sélectionnées", "Erreur");
                        comBoxCamion.SelectedItem = liste_voyages[lst_voyages.SelectedIndex].Camion_selectionne;
                    }
                    else
                    {
                        MessageBox.Show("Changement de camion impossible: Erreur inconnue --> Veuillez réessayer.", "Erreur");
                        comBoxCamion.SelectedItem = liste_voyages[lst_voyages.SelectedIndex].Camion_selectionne;
                    }
                }
                else
                {
                    MessageBox.Show("Un camionneur doit être sélectionné", "Erreur");
                    comBoxCamion.SelectedItem = liste_voyages[lst_voyages.SelectedIndex].Camion_selectionne;
                }
            }
        }




        // --- L I V R A I S O N   N A  -->  I N C L U S E S

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            if (lst_livraisons_non_assignees.SelectedItem != null)
            {
                if (liste_voyages[lst_voyages.SelectedIndex].Camion_selectionne != null)
                {
                    if (liste_voyages[lst_voyages.SelectedIndex].Verifier_avant_ajout_livraison(liste_livraisons[lst_livraisons_non_assignees.SelectedIndex]) == "ok")
                    {
                        liste_voyages[lst_voyages.SelectedIndex].List_livraisons_selectionne.Add(new Livraison(liste_livraisons[lst_livraisons_non_assignees.SelectedIndex]));
                        liste_livraisons.RemoveAt(lst_livraisons_non_assignees.SelectedIndex);
                        binding_listbox_livraisons.ResetBindings(false);
                        binding_listbox_livraisons_assignees.ResetBindings(false);

                    }
                    else if (liste_voyages[lst_voyages.SelectedIndex].Verifier_avant_ajout_livraison(liste_livraisons[lst_livraisons_non_assignees.SelectedIndex]) == "poids")
                    {
                        MessageBox.Show("Ajout impossible: poids total supérieur au poids maximum du camion", "Erreur");
                    }
                    else if (liste_voyages[lst_voyages.SelectedIndex].Verifier_avant_ajout_livraison(liste_livraisons[lst_livraisons_non_assignees.SelectedIndex]) == "volume")
                    {
                        MessageBox.Show("Ajout impossible: volume total supérieur au volume maximum du camion", "Erreur");
                    }
                    else
                    {
                        MessageBox.Show("Ajout impossible: Erreur inconnue --> Veuillez réessayer.", "Erreur");
                    }
                }
                else
                {
                    MessageBox.Show("Ajout impossible : Un camion doit être sélectionné", "Erreur");
                }
            }
            else
            {
                if (liste_livraisons.Count == 0)
                {
                    MessageBox.Show("Ajout impossible : Aucunes livraisons créées","Erreur");
                }
                else
                {
                    MessageBox.Show("Ajout impossible : Une livraison doit être sélectionnée", "Erreur");
                }
            }
        }


        // --- L I V R A I S O N   N A  <--  I N C L U S E S

        private void btn_retirer_Click(object sender, EventArgs e)
        {
            if (lst_livraisons_incluses.SelectedItem != null)
            {
                liste_livraisons.Add(new Livraison(liste_voyages[lst_voyages.SelectedIndex].List_livraisons_selectionne[lst_livraisons_incluses.SelectedIndex]));
                liste_voyages[lst_voyages.SelectedIndex].List_livraisons_selectionne.RemoveAt(lst_livraisons_incluses.SelectedIndex);
                binding_listbox_livraisons.ResetBindings(false);
                binding_listbox_livraisons_assignees.ResetBindings(false);
            }
            else
            {
                if (liste_voyages[lst_voyages.SelectedIndex].List_livraisons_selectionne.Count == 0)
                {
                    MessageBox.Show("Transfert impossible : Aucune livraison n'est assignée au voyage sélectionné","Erreur");
                }
                else
                {
                    MessageBox.Show("Transfert impossible : Une livraison doit être sélectionnée", "Erreur");
                }
            }
        }
    }
}

