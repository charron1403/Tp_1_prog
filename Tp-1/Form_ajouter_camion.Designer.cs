
namespace Tp_1
{
    partial class Form_ajouter_camion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_volume_maximal_camion = new System.Windows.Forms.TextBox();
            this.btn_ajouter_camion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_poids_maximal_camion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume maximal:";
            // 
            // txtbox_volume_maximal_camion
            // 
            this.txtbox_volume_maximal_camion.Location = new System.Drawing.Point(103, 15);
            this.txtbox_volume_maximal_camion.Name = "txtbox_volume_maximal_camion";
            this.txtbox_volume_maximal_camion.Size = new System.Drawing.Size(133, 20);
            this.txtbox_volume_maximal_camion.TabIndex = 1;
            // 
            // btn_ajouter_camion
            // 
            this.btn_ajouter_camion.Location = new System.Drawing.Point(161, 74);
            this.btn_ajouter_camion.Name = "btn_ajouter_camion";
            this.btn_ajouter_camion.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter_camion.TabIndex = 2;
            this.btn_ajouter_camion.Text = "Ajouter";
            this.btn_ajouter_camion.UseVisualStyleBackColor = true;
            this.btn_ajouter_camion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Poids maximal:";
            // 
            // txtbox_poids_maximal_camion
            // 
            this.txtbox_poids_maximal_camion.Location = new System.Drawing.Point(103, 45);
            this.txtbox_poids_maximal_camion.Name = "txtbox_poids_maximal_camion";
            this.txtbox_poids_maximal_camion.Size = new System.Drawing.Size(133, 20);
            this.txtbox_poids_maximal_camion.TabIndex = 4;
            // 
            // Form_ajouter_camion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 111);
            this.Controls.Add(this.txtbox_poids_maximal_camion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ajouter_camion);
            this.Controls.Add(this.txtbox_volume_maximal_camion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_ajouter_camion";
            this.Text = "Ajouter camion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_volume_maximal_camion;
        private System.Windows.Forms.Button btn_ajouter_camion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_poids_maximal_camion;
    }
}