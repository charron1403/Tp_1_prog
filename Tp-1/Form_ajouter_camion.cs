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
    public partial class Form_ajouter_camion : Form
    {
        public Form_ajouter_camion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtbox_volume_maximal_camion.Text == "")
            {
                MessageBox.Show("Veuillez entrer un nombre");
            }
        }
    }
}
