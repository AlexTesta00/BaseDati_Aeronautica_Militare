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
    public partial class Form1 : Form
    {
        private DataClassesAMDataContext db;
        public Form1()
        {
            InitializeComponent();
            this.db = new DataClassesAMDataContext();
            this.initComboBox();
            /*
             *             DataClassesAMDataContext db = new DataClassesAMDataContext();
            var data = from m in db.MILITARE
                       select m;

            dataGridView1.DataSource = data;
             */
        }

        private void initComboBox() 
        {
            cbGrado.SelectedIndex = 5;
            cbRuolo.SelectedIndex = 0;
            cbStatoFamiliare.SelectedIndex = 0;
        }

        private void bMilitariSelect_Click(object sender, EventArgs e)
        {
            if (rbTutto.Checked)
            {
                var data = from m in db.MILITARE
                           select m;
                GVMilitare.DataSource = data;
            }
            else if (rbPiloti.Checked)
            {
                var data = from m in db.MILITARE
                           where m.Tipo.Equals("Pilota")
                           select m;
                GVMilitare.DataSource = data;
            }
            else 
            {
                var data = from m in db.MILITARE
                           where m.Tipo.Equals("Specialista")
                           select m;
                GVMilitare.DataSource = data;
            }
        }

        private void ClearText(object sender, EventArgs e)
        {
            if (tbMatricola.Text == "Matricola")
            {
                tbMatricola.Text = "";
                tbMatricola.ForeColor = Color.Black;
            }
        }

        private void ClearTextN(object sender, EventArgs e)
        {
            if (tbNome.Text == "Nome")
            {
                tbNome.Text = "";
                tbNome.ForeColor = Color.Black;
            }
        }

        private void ClearTextC(object sender, EventArgs e)
        {
            if (tbCognome.Text == "Cognome")
            {
                tbCognome.Text = "";
                tbCognome.ForeColor = Color.Black;
            }
        }

        private void ClearTextE(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
            {
                tbEmail.Text = "";
                tbEmail.ForeColor = Color.Black;
            }
        }

        private void ClearTextT(object sender, EventArgs e)
        {
            if (tbTelefono.Text == "Telefono")
            {
                tbTelefono.Text = "";
                tbTelefono.ForeColor = Color.Black;
            }
        }

        private void ClearTextCF(object sender, EventArgs e)
        {
            if (tbCodiceFiscale.Text == "CodiceFiscale")
            {
                tbCodiceFiscale.Text = "";
                tbCodiceFiscale.ForeColor = Color.Black;
            }
        }

        private void ClearTextST(object sender, EventArgs e)
        {
            if (tbStormo.Text == "Stormo")
            {
                tbStormo.Text = "";
                tbStormo.ForeColor = Color.Black;
            }
        }

        private void ClearTextGV(object sender, EventArgs e)
        {
            if (tbGruppoDiVolo.Text == "Gruppo")
            {
                tbGruppoDiVolo.Text = "";
                tbGruppoDiVolo.ForeColor = Color.Black;
            }
        }

        private void cbRuolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbRuolo.SelectedItem == "Specialista")
            {
                tbStormo.Enabled = false;
                tbGruppoDiVolo.Enabled = false;
            }
            else 
            {
                tbStormo.Enabled = true;
                tbGruppoDiVolo.Enabled = true;
            }
        }

        private void btnInserisciMilitare_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == "" || tbNome.Text == "Nome")
            {
                MessageBox.Show("Errore nella cella Nome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbCognome.Text == "" || tbCognome.Text == "Cognome")
            {
                MessageBox.Show("Errore nella cella Cognome", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbMatricola.Text == "" || tbMatricola.Text == "Matricola")
            {
                MessageBox.Show("Errore nella cella Matricola", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbEmail.Text == "" || tbEmail.Text == "Email")
            {
                MessageBox.Show("Errore nella cella Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbCodiceFiscale.Text == "" || tbCodiceFiscale.Text == "Codice Fiscale")
            {
                MessageBox.Show("Errore nella cella Codice Fiscale", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbStormo.Enabled && (tbStormo.Text == "" || tbStormo.Text == "Stormo"))
            {
                MessageBox.Show("Errore nella cella Stormo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbGruppoDiVolo.Enabled && (tbGruppoDiVolo.Text == "" || tbGruppoDiVolo.Text == "Gruppo"))
            {
                MessageBox.Show("Errore nella cella Gruppo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbGrado.Text == "" || cbGrado.Text == "Grado")
            {
                MessageBox.Show("Errore nella cella Grado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbRuolo.Text == "" || cbRuolo.Text == "Ruolo")
            {
                MessageBox.Show("Errore nella cella Ruolo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbStatoFamiliare.Text == "" || cbStatoFamiliare.Text == "Stato Familiare")
            {
                MessageBox.Show("Errore nella cella Stato Familiare", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (cbRuolo.Text == "Specialista")
                {

                }
                else 
                {

                }
                MessageBox.Show("Benvenuto, " + cbGrado.Text + "." + tbNome.Text + " " + tbCognome.Text);
            }
        }
    }
}
