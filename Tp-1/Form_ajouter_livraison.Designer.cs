
namespace Tp_1
{
    partial class Form_ajouter_livraison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_poids = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.txt_Poids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Volume = new System.Windows.Forms.TextBox();
            this.btn_ajouter_livraison = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_poids
            // 
            this.lbl_poids.AutoSize = true;
            this.lbl_poids.Location = new System.Drawing.Point(22, 26);
            this.lbl_poids.Name = "lbl_poids";
            this.lbl_poids.Size = new System.Drawing.Size(39, 13);
            this.lbl_poids.TabIndex = 0;
            this.lbl_poids.Text = "Poids :";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(22, 67);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(48, 13);
            this.lbl_volume.TabIndex = 1;
            this.lbl_volume.Text = "Volume :";
            // 
            // txt_Poids
            // 
            this.txt_Poids.Location = new System.Drawing.Point(76, 23);
            this.txt_Poids.Name = "txt_Poids";
            this.txt_Poids.Size = new System.Drawing.Size(100, 20);
            this.txt_Poids.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // txt_Volume
            // 
            this.txt_Volume.Location = new System.Drawing.Point(76, 64);
            this.txt_Volume.Name = "txt_Volume";
            this.txt_Volume.Size = new System.Drawing.Size(100, 20);
            this.txt_Volume.TabIndex = 4;
            // 
            // btn_ajouter_livraison
            // 
            this.btn_ajouter_livraison.Location = new System.Drawing.Point(76, 90);
            this.btn_ajouter_livraison.Name = "btn_ajouter_livraison";
            this.btn_ajouter_livraison.Size = new System.Drawing.Size(100, 23);
            this.btn_ajouter_livraison.TabIndex = 5;
            this.btn_ajouter_livraison.Text = "Ajouter ";
            this.btn_ajouter_livraison.UseVisualStyleBackColor = true;
            this.btn_ajouter_livraison.Click += new System.EventHandler(this.btn_ajouter_livraison_Click);
            // 
            // Form_ajouter_livraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 152);
            this.Controls.Add(this.btn_ajouter_livraison);
            this.Controls.Add(this.txt_Volume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Poids);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.lbl_poids);
            this.Name = "Form_ajouter_livraison";
            this.Text = "Form_ajouter_livraison";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_poids;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.TextBox txt_Poids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Volume;
        private System.Windows.Forms.Button btn_ajouter_livraison;
    }
}