
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.livraison_incluses_gBox = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.voyage_selectionne_gBox = new System.Windows.Forms.GroupBox();
            this.txtbox_distance = new System.Windows.Forms.TextBox();
            this.comBoxCamion = new System.Windows.Forms.ComboBox();
            this.comBoxCamionneur = new System.Windows.Forms.ComboBox();
            this.dTP_selection = new System.Windows.Forms.DateTimePicker();
            this.lbl_Distance = new System.Windows.Forms.Label();
            this.lbl_Camion = new System.Windows.Forms.Label();
            this.lbl_Camionneur = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouter_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.camionneur_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.camion_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.livraison_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.voyage_top_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.livraison_incluses_gBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.voyage_selectionne_gBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 212);
            this.listBox1.TabIndex = 1;
            // 
            // livraison_incluses_gBox
            // 
            this.livraison_incluses_gBox.Controls.Add(this.listBox3);
            this.livraison_incluses_gBox.Location = new System.Drawing.Point(500, 289);
            this.livraison_incluses_gBox.Name = "livraison_incluses_gBox";
            this.livraison_incluses_gBox.Size = new System.Drawing.Size(381, 234);
            this.livraison_incluses_gBox.TabIndex = 2;
            this.livraison_incluses_gBox.TabStop = false;
            this.livraison_incluses_gBox.Text = "Livraisons incluses";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(0, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(380, 212);
            this.listBox3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Location = new System.Drawing.Point(36, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 234);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(0, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(380, 212);
            this.listBox2.TabIndex = 0;
            // 
            // voyage_selectionne_gBox
            // 
            this.voyage_selectionne_gBox.Controls.Add(this.txtbox_distance);
            this.voyage_selectionne_gBox.Controls.Add(this.comBoxCamion);
            this.voyage_selectionne_gBox.Controls.Add(this.comBoxCamionneur);
            this.voyage_selectionne_gBox.Controls.Add(this.dTP_selection);
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_Distance);
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_Camion);
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_Camionneur);
            this.voyage_selectionne_gBox.Controls.Add(this.lbl_date);
            this.voyage_selectionne_gBox.Location = new System.Drawing.Point(500, 37);
            this.voyage_selectionne_gBox.Name = "voyage_selectionne_gBox";
            this.voyage_selectionne_gBox.Size = new System.Drawing.Size(381, 189);
            this.voyage_selectionne_gBox.TabIndex = 2;
            this.voyage_selectionne_gBox.TabStop = false;
            this.voyage_selectionne_gBox.Text = "Voyage sélectionné";
            // 
            // txtbox_distance
            // 
            this.txtbox_distance.Location = new System.Drawing.Point(233, 145);
            this.txtbox_distance.Name = "txtbox_distance";
            this.txtbox_distance.Size = new System.Drawing.Size(116, 20);
            this.txtbox_distance.TabIndex = 7;
            // 
            // comBoxCamion
            // 
            this.comBoxCamion.FormattingEnabled = true;
            this.comBoxCamion.Location = new System.Drawing.Point(149, 104);
            this.comBoxCamion.Name = "comBoxCamion";
            this.comBoxCamion.Size = new System.Drawing.Size(200, 21);
            this.comBoxCamion.TabIndex = 6;
            // 
            // comBoxCamionneur
            // 
            this.comBoxCamionneur.FormattingEnabled = true;
            this.comBoxCamionneur.Location = new System.Drawing.Point(149, 63);
            this.comBoxCamionneur.Name = "comBoxCamionneur";
            this.comBoxCamionneur.Size = new System.Drawing.Size(200, 21);
            this.comBoxCamionneur.TabIndex = 5;
            // 
            // dTP_selection
            // 
            this.dTP_selection.Location = new System.Drawing.Point(149, 25);
            this.dTP_selection.Name = "dTP_selection";
            this.dTP_selection.Size = new System.Drawing.Size(200, 20);
            this.dTP_selection.TabIndex = 4;
            // 
            // lbl_Distance
            // 
            this.lbl_Distance.AutoSize = true;
            this.lbl_Distance.Location = new System.Drawing.Point(7, 145);
            this.lbl_Distance.Name = "lbl_Distance";
            this.lbl_Distance.Size = new System.Drawing.Size(49, 13);
            this.lbl_Distance.TabIndex = 3;
            this.lbl_Distance.Text = "Distance";
            // 
            // lbl_Camion
            // 
            this.lbl_Camion.AutoSize = true;
            this.lbl_Camion.Location = new System.Drawing.Point(7, 104);
            this.lbl_Camion.Name = "lbl_Camion";
            this.lbl_Camion.Size = new System.Drawing.Size(42, 13);
            this.lbl_Camion.TabIndex = 2;
            this.lbl_Camion.Text = "Camion";
            this.lbl_Camion.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Camionneur
            // 
            this.lbl_Camionneur.AutoSize = true;
            this.lbl_Camionneur.Location = new System.Drawing.Point(7, 63);
            this.lbl_Camionneur.Name = "lbl_Camionneur";
            this.lbl_Camionneur.Size = new System.Drawing.Size(63, 13);
            this.lbl_Camionneur.TabIndex = 1;
            this.lbl_Camionneur.Text = "Camionneur";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(7, 31);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
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
            // 
            // camion_top_menu
            // 
            this.camion_top_menu.Name = "camion_top_menu";
            this.camion_top_menu.Size = new System.Drawing.Size(180, 22);
            this.camion_top_menu.Text = "Camion";
            // 
            // livraison_top_menu
            // 
            this.livraison_top_menu.Name = "livraison_top_menu";
            this.livraison_top_menu.Size = new System.Drawing.Size(180, 22);
            this.livraison_top_menu.Text = "Livraison";
            // 
            // voyage_top_menu
            // 
            this.voyage_top_menu.Name = "voyage_top_menu";
            this.voyage_top_menu.Size = new System.Drawing.Size(180, 22);
            this.voyage_top_menu.Text = "Voyage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.voyage_selectionne_gBox);
            this.Controls.Add(this.livraison_incluses_gBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.livraison_incluses_gBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.voyage_selectionne_gBox.ResumeLayout(false);
            this.voyage_selectionne_gBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox livraison_incluses_gBox;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox voyage_selectionne_gBox;
        private System.Windows.Forms.Label lbl_Distance;
        private System.Windows.Forms.Label lbl_Camion;
        private System.Windows.Forms.Label lbl_Camionneur;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
    }
}

