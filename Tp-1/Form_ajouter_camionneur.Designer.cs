
namespace Tp_1
{
    partial class Form_ajouter_camionneur
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
            this.txtbox_nom_camionneur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajouter_camioneur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_prenom_camionneur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbox_nom_camionneur
            // 
            this.txtbox_nom_camionneur.Location = new System.Drawing.Point(71, 16);
            this.txtbox_nom_camionneur.Name = "txtbox_nom_camionneur";
            this.txtbox_nom_camionneur.Size = new System.Drawing.Size(183, 20);
            this.txtbox_nom_camionneur.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // btn_ajouter_camioneur
            // 
            this.btn_ajouter_camioneur.Location = new System.Drawing.Point(179, 96);
            this.btn_ajouter_camioneur.Name = "btn_ajouter_camioneur";
            this.btn_ajouter_camioneur.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter_camioneur.TabIndex = 2;
            this.btn_ajouter_camioneur.Text = "Ajouter";
            this.btn_ajouter_camioneur.UseVisualStyleBackColor = true;
            this.btn_ajouter_camioneur.Click += new System.EventHandler(this.btn_ajouter_camioneur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom";
            // 
            // txtbox_prenom_camionneur
            // 
            this.txtbox_prenom_camionneur.Location = new System.Drawing.Point(71, 53);
            this.txtbox_prenom_camionneur.Name = "txtbox_prenom_camionneur";
            this.txtbox_prenom_camionneur.Size = new System.Drawing.Size(183, 20);
            this.txtbox_prenom_camionneur.TabIndex = 4;
            // 
            // Form_ajouter_camionneur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 135);
            this.Controls.Add(this.txtbox_prenom_camionneur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ajouter_camioneur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_nom_camionneur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ajouter_camionneur";
            this.Text = "Ajouter un camionneur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_nom_camionneur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ajouter_camioneur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_prenom_camionneur;
    }
}