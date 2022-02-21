
namespace Tp_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.voyages_gbox = new System.Windows.Forms.GroupBox();
            this.lst_voyages = new System.Windows.Forms.ListBox();
            this.livraisons_non_assignees_gBox = new System.Windows.Forms.GroupBox();
            this.lst_livraisons_non_assignees = new System.Windows.Forms.ListBox();
            this.voyage_selectionne_gBox = new System.Windows.Forms.GroupBox();
            this.lbl_livraisons_incluses = new System.Windows.Forms.Label();
            this.lst_livraisons_incluses = new System.Windows.Forms.ListBox();
            this.txtbox_distance = new System.Windows.Forms.TextBox();
            this.comBoxCamion = new System.Windows.Forms.ComboBox();
            this.comBoxCamionneur = new System.Windows.Forms.ComboBox();
            this.dTP_selection = new System.Windows.Forms.DateTimePicker();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.lbl_Camion = new System.Windows.Forms.Label();
            this.lbl_Camionneur = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_retirer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouter_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.camionneur_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.camion_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.livraison_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.voyage_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.voyages_gbox.SuspendLayout();
            this.livraisons_non_assignees_gBox.SuspendLayout();
            this.voyage_selectionne_gBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voyages_gbox
            // 
            this.voyages_gbox.Controls.Add(this.lst_voyages);
            this.voyages_gbox.Location = new System.Drawing.Point(13, 25);
            this.voyages_gbox.Name = "voyages_gbox";
            this.voyages_gbox.Size = new System.Drawing.Size(403, 229);
            this.voyages_gbox.TabIndex = 1;
            this.voyages_gbox.TabStop = false;
            this.voyages_gbox.Text = "Voyages";
            // 
            // lst_voyages
            // 
            this.lst_voyages.FormattingEnabled = true;
            this.lst_voyages.Location = new System.Drawing.Point(0, 17);
            this.lst_voyages.Name = "lst_voyages";
            this.lst_voyages.Size = new System.Drawing.Size(403, 212);
            this.lst_voyages.TabIndex = 1;
            this.lst_voyages.SelectedIndexChanged += new System.EventHandler(this.lst_voyages_SelectedIndexChanged);
            // 
            // livraisons_non_assignees_gBox
            // 
            this.livraisons_non_assignees_gBox.Controls.Add(this.lst_livraisons_non_assignees);
            this.livraisons_non_assignees_gBox.Location = new System.Drawing.Point(13, 289);
            this.livraisons_non_assignees_gBox.Name = "livraisons_non_assignees_gBox";
            this.livraisons_non_assignees_gBox.Size = new System.Drawing.Size(403, 234);
            this.livraisons_non_assignees_gBox.TabIndex = 2;
            this.livraisons_non_assignees_gBox.TabStop = false;
            this.livraisons_non_assignees_gBox.Text = "Livraisons non-assignées";
            // 
            // lst_livraisons_non_assignees
            // 
            this.lst_livraisons_non_assignees.FormattingEnabled = true;
            this.lst_livraisons_non_assignees.Location = new System.Drawing.Point(0, 20);
            this.lst_livraisons_non_assignees.Name = "lst_livraisons_non_assignees";
            this.lst_livraisons_non_assignees.Size = new System.Drawing.Size(403, 212);
            this.lst_livraisons_non_assignees.TabIndex = 0;
            // 
            // voyage_selectionne_gBox
            // 
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_livraisons_incluses);
            this.voyage_selectionne_gBox.Controls.Add(this.lst_livraisons_incluses);
            this.voyage_selectionne_gBox.Controls.Add(this.txtbox_distance);
            this.voyage_selectionne_gBox.Controls.Add(this.comBoxCamion);
            this.voyage_selectionne_gBox.Controls.Add(this.comBoxCamionneur);
            this.voyage_selectionne_gBox.Controls.Add(this.dTP_selection);
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_Distance);
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_Camion);
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_Camionneur);
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_date);
            this.voyage_selectionne_gBox.Location = new System.Drawing.Point(492, 37);
            this.voyage_selectionne_gBox.Name = "voyage_selectionne_gBox";
            this.voyage_selectionne_gBox.Size = new System.Drawing.Size(413, 484);
            this.voyage_selectionne_gBox.TabIndex = 2;
            this.voyage_selectionne_gBox.TabStop = false;
            this.voyage_selectionne_gBox.Text = "Voyage sélectionné";
            // 
            // lbl_livraisons_incluses
            // 
            this.lbl_livraisons_incluses.AutoSize = true;
            this.lbl_livraisons_incluses.Location = new System.Drawing.Point(23, 252);
            this.lbl_livraisons_incluses.Name = "lbl_livraisons_incluses";
            this.lbl_livraisons_incluses.Size = new System.Drawing.Size(95, 13);
            this.lbl_livraisons_incluses.TabIndex = 8;
            this.lbl_livraisons_incluses.Text = "Livraisons incluses";
            // 
            // lst_livraisons_incluses
            // 
            this.lst_livraisons_incluses.FormattingEnabled = true;
            this.lst_livraisons_incluses.Location = new System.Drawing.Point(17, 272);
            this.lst_livraisons_incluses.Name = "lst_livraisons_incluses";
            this.lst_livraisons_incluses.Size = new System.Drawing.Size(380, 212);
            this.lst_livraisons_incluses.TabIndex = 1;
            // 
            // txtbox_distance
            // 
            this.txtbox_distance.Location = new System.Drawing.Point(249, 145);
            this.txtbox_distance.Name = "txtbox_distance";
            this.txtbox_distance.Size = new System.Drawing.Size(116, 20);
            this.txtbox_distance.TabIndex = 7;
            // 
            // comBoxCamion
            // 
            this.comBoxCamion.FormattingEnabled = true;
            this.comBoxCamion.Location = new System.Drawing.Point(165, 104);
            this.comBoxCamion.Name = "comBoxCamion";
            this.comBoxCamion.Size = new System.Drawing.Size(200, 21);
            this.comBoxCamion.TabIndex = 6;
            // 
            // comBoxCamionneur
            // 
            this.comBoxCamionneur.FormattingEnabled = true;
            this.comBoxCamionneur.Location = new System.Drawing.Point(165, 63);
            this.comBoxCamionneur.Name = "comBoxCamionneur";
            this.comBoxCamionneur.Size = new System.Drawing.Size(200, 21);
            this.comBoxCamionneur.TabIndex = 5;
            // 
            // dTP_selection
            // 
            this.dTP_selection.Location = new System.Drawing.Point(165, 25);
            this.dTP_selection.Name = "dTP_selection";
            this.dTP_selection.Size = new System.Drawing.Size(200, 20);
            this.dTP_selection.TabIndex = 4;
            // 
            // lbl_Distance
            // 
            this.lbl_Distance.AutoSize = true;
            this.lbl_Distance.Location = new System.Drawing.Point(23, 145);
            this.lbl_Distance.Name = "lbl_Distance";
            this.lbl_Distance.Size = new System.Drawing.Size(49, 13);
            this.lbl_Distance.TabIndex = 3;
            this.lbl_Distance.Text = "Distance";
            // 
            // lbl_Camion
            // 
            this.lbl_Camion.AutoSize = true;
            this.lbl_Camion.Location = new System.Drawing.Point(23, 104);
            this.lbl_Camion.Name = "lbl_Camion";
            this.lbl_Camion.Size = new System.Drawing.Size(42, 13);
            this.lbl_Camion.TabIndex = 2;
            this.lbl_Camion.Text = "Camion";
            // 
            // lbl_Camionneur
            // 
            this.lbl_Camionneur.AutoSize = true;
            this.lbl_Camionneur.Location = new System.Drawing.Point(23, 63);
            this.lbl_Camionneur.Name = "lbl_Camionneur";
            this.lbl_Camionneur.Size = new System.Drawing.Size(63, 13);
            this.lbl_Camionneur.TabIndex = 1;
            this.lbl_Camionneur.Text = "Camionneur";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(23, 31);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(440, 340);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(35, 60);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = ">";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_retirer
            // 
            this.btn_retirer.Location = new System.Drawing.Point(440, 421);
            this.btn_retirer.Name = "btn_retirer";
            this.btn_retirer.Size = new System.Drawing.Size(35, 60);
            this.btn_retirer.TabIndex = 4;
            this.btn_retirer.Text = "<";
            this.btn_retirer.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouter_top_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouter_top_menu
            // 
            this.ajouter_top_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camionneur_top_menu,
            this.camion_top_menu,
            this.livraison_top_menu,
            this.voyage_top_menu});
            this.ajouter_top_menu.Name = "ajouter_top_menu";
            this.ajouter_top_menu.Size = new System.Drawing.Size(58, 20);
            this.ajouter_top_menu.Text = "Ajouter";
            // 
            // camionneur_top_menu
            // 
            this.camionneur_top_menu.Name = "camionneur_top_menu";
            this.camionneur_top_menu.Size = new System.Drawing.Size(180, 22);
            this.camionneur_top_menu.Text = "Camionneur";
            this.camionneur_top_menu.Click += new System.EventHandler(this.camionneur_top_menu_Click);
            // 
            // camion_top_menu
            // 
            this.camion_top_menu.Name = "camion_top_menu";
            this.camion_top_menu.Size = new System.Drawing.Size(180, 22);
            this.camion_top_menu.Text = "Camion";
            this.camion_top_menu.Click += new System.EventHandler(this.camion_top_menu_Click);
            // 
            // livraison_top_menu
            // 
            this.livraison_top_menu.Name = "livraison_top_menu";
            this.livraison_top_menu.Size = new System.Drawing.Size(180, 22);
            this.livraison_top_menu.Text = "Livraison";
            this.livraison_top_menu.Click += new System.EventHandler(this.livraison_top_menu_Click);
            // 
            // voyage_top_menu
            // 
            this.voyage_top_menu.Name = "voyage_top_menu";
            this.voyage_top_menu.Size = new System.Drawing.Size(180, 22);
            this.voyage_top_menu.Text = "Voyage";
            this.voyage_top_menu.Click += new System.EventHandler(this.voyage_top_menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 535);
            this.Controls.Add(this.btn_retirer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.voyage_selectionne_gBox);
            this.Controls.Add(this.livraisons_non_assignees_gBox);
            this.Controls.Add(this.voyages_gbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.voyages_gbox.ResumeLayout(false);
            this.livraisons_non_assignees_gBox.ResumeLayout(false);
            this.voyage_selectionne_gBox.ResumeLayout(false);
            this.voyage_selectionne_gBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox voyages_gbox;
        private System.Windows.Forms.ListBox lst_voyages;
        private System.Windows.Forms.GroupBox livraisons_non_assignees_gBox;
        private System.Windows.Forms.ListBox lst_livraisons_non_assignees;
        private System.Windows.Forms.GroupBox voyage_selectionne_gBox;
        private System.Windows.Forms.Label lbl_Distance;
        private System.Windows.Forms.Label lbl_Camion;
        private System.Windows.Forms.Label lbl_Camionneur;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_retirer;
        private System.Windows.Forms.TextBox txtbox_distance;
        private System.Windows.Forms.ComboBox comBoxCamion;
        private System.Windows.Forms.ComboBox comBoxCamionneur;
        private System.Windows.Forms.DateTimePicker dTP_selection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouter_top_menu;
        private System.Windows.Forms.ToolStripMenuItem camionneur_top_menu;
        private System.Windows.Forms.ToolStripMenuItem camion_top_menu;
        private System.Windows.Forms.ToolStripMenuItem livraison_top_menu;
        private System.Windows.Forms.ToolStripMenuItem voyage_top_menu;
        private System.Windows.Forms.Label lbl_livraisons_incluses;
        private System.Windows.Forms.ListBox lst_livraisons_incluses;
    }
}

