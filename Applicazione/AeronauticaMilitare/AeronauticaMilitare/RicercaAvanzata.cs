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
        private DataClassesAMDataContext db;
        public RicercaAvanzata()
        {
            InitializeComponent();
            this.db = new DataClassesAMDataContext();
            this.initBox();
        }

        private void rbOredivolo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOredivolo.Checked)
            {
                cbAeromobili.Enabled = false;
                lblVelivolo.Visible = false;
                cbAeromobili.Text = "";
            }
            else 
            {
                cbAeromobili.Enabled = true;
                lblVelivolo.Visible = true;
            }
        }

        private void initBox() 
        {
            var data = from m in db.MILITARE
                       where m.Tipo == "Pilota"
                       select m.MatricolaMilitare;
            var item = data.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < item.Length; i++)
            {
                cbMilitari.Items.Add(item[i]);
            }

            var velivolo = from a in db.AEROMOBILE
                       select a.CodiceAeromobile;
            var allItem = velivolo.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < allItem.Length; i++)
            {
                cbAeromobili.Items.Add(allItem[i]);
            }
        }

        private void contaOreVolo_Click(object sender, EventArgs e)
        {
            if (rbOredivolo.Checked)
            {
                if (cbMilitari.Text == "")
                {
                    MessageBox.Show("Matricola vuota", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    string matricolaPilota = cbMilitari.SelectedItem.ToString();
                    var minutiVolo = from M in db.MILITARE
                                     join V in db.VOLO on M.MatricolaMilitare equals V.MatricolaMilitare
                                     where M.MatricolaMilitare == matricolaPilota
                                     select V.DurataComplessiva;
                    lblRisultatoOreVolo.Text = (minutiVolo.Sum() / 60).ToString() + "h";
                }
            }
            else 
            {
                if (cbMilitari.Text == "" || cbAeromobili.Text == "") 
                {
                    MessageBox.Show("Matricola vuota", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    string matricolaPilota = cbMilitari.SelectedItem.ToString();
                    string matricolaAeromobile = cbAeromobili.SelectedItem.ToString();
                    var minutiVolo = from M in db.MILITARE
                                     join V in db.VOLO on M.MatricolaMilitare equals V.MatricolaMilitare
                                     where M.MatricolaMilitare == matricolaPilota && V.CodiceAeromobile == matricolaAeromobile
                                     select V.DurataComplessiva;
                    if (minutiVolo.ToArray().Length == 0)
                    {
                        lblRisultatoOreVolo.Text = "Null";
                    }
                    else
                    {
                        lblRisultatoOreVolo.Text = (minutiVolo.Sum() / 60).ToString() + "h";
                    }
                }
            }
        }

        private void cbMilitari_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matricolaPilota = cbMilitari.SelectedItem.ToString();
            var nome = from m in db.MILITARE
                       where m.MatricolaMilitare == matricolaPilota
                       select new { nome = m.Nome, cognome = m.Cognome };
            lblNome.Text = nome.ToArray()[0].nome;
            lblCognome.Text = nome.ToArray()[0].cognome;
        }

        private void cbAeromobili_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matricolaAeromobile = cbAeromobili.SelectedItem.ToString();
            var nome = from A in db.AEROMOBILE
                       where A.CodiceAeromobile == matricolaAeromobile
                       select A.Nome;
            lblVelivolo.Text = nome.ToArray()[0].ToString();
        }
    }
}
