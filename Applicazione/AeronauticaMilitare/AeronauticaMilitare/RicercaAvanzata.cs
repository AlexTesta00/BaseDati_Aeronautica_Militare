using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AeronauticaMilitare
{
    public partial class RicercaAvanzata : Form
    {
        public RicercaAvanzata()
        {
            InitializeComponent();
        }

        private void cbMilitari_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAeromobili_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbOredivolo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOredivolo.Checked)
            {
                cbAeromobili.Enabled = false;
            }
            else 
            {
                cbAeromobili.Enabled = true;
            }
        }
    }
}
