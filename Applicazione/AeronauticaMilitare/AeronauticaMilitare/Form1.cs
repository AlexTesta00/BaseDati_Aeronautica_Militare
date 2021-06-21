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
    public partial class Main : Form
    {
        private DataClassesAMDataContext db;
        private IdGenerator idGenerator;
        public Main()
        {
            InitializeComponent();
            this.db = new DataClassesAMDataContext();
            this.initComboBox();
            this.idGenerator = new IdGenerator();
        }

        private void initComboBox() 
        {
            cbGrado.SelectedIndex = 5;
            cbRuolo.SelectedIndex = 0;
            cbStatoFamiliare.SelectedIndex = 0;
            cbFunzionePrimaria.SelectedIndex = 0;
            cbNumeroMembri.SelectedIndex = 0;
            cbStato.SelectedIndex = 0;
            cbStatoMentale.SelectedIndex = 0;
            cbCondizioniGenerali.SelectedIndex = 0;

            var velivolo = from a in db.AEROMOBILE
                           select a.CodiceAeromobile;
            var allItem = velivolo.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < allItem.Length; i++)
            {
                cbPatAero.Items.Add(allItem[i]);
                cbCodAereoArm.Items.Add(allItem[i]);
                cbCodAereoMan.Items.Add(allItem[i]);
                cbAeromobileVolo.Items.Add(allItem[i]);
            }

            var data = from m in db.MILITARE
                       select m.MatricolaMilitare;
            var item = data.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < item.Length; i++)
            {
                cbPatMil.Items.Add(item[i]);
            }

            var specialista = from m in db.MILITARE
                              where m.Tipo == "Specialista"
                              select m.MatricolaMilitare;
            var itemSpecialista = specialista.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < itemSpecialista.Length; i++)
            {
                cbCodSpecMan.Items.Add(itemSpecialista[i]);
            }

            var pilota = from m in db.MILITARE
                              where m.Tipo == "Pilota"
                              select m.MatricolaMilitare;
            var itemPilota = pilota.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < itemPilota.Length; i++)
            {
                cbCodPilotaIdon.Items.Add(itemPilota[i]);
                cbMatricolaVolo.Items.Add(itemPilota[i]);
            }

            var missione = from m in db.MISSIONE
                           select m.Nome;
            var missioneItem = missione.Select(x => x.ToString()).ToArray();
            for (int i = 0; i < itemSpecialista.Length; i++)
            {
                cbNomeVolo.Items.Add(missioneItem[i]);
            }


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
                tbMatricola.Text = this.idGenerator.generateIdCode(20);
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
                    MILITARE newMilitare = new MILITARE()
                    {
                        Nome = tbNome.Text,
                        Cognome = tbCognome.Text,
                        MatricolaMilitare = tbMatricola.Text,
                        Grado = cbGrado.Text,
                        Email = tbEmail.Text,
                        Telefono = tbTelefono.Text,
                        CodiceFiscale = tbCodiceFiscale.Text,
                        StatoFamiliare = cbStatoFamiliare.Text,
                        Tipo = cbRuolo.Text,
                        Stormo = null,
                        GruppoDiVolo = null
                    };

                    this.db.MILITARE.InsertOnSubmit(newMilitare);

                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Benvenuto, " + cbGrado.Text + "." + tbNome.Text + " " + tbCognome.Text);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore nel database: " + ex);
                    }
                }
                else 
                {
                    MILITARE newMilitare = new MILITARE()
                    {
                        Nome = tbNome.Text,
                        Cognome = tbCognome.Text,
                        MatricolaMilitare = tbMatricola.Text,
                        Grado = cbGrado.Text,
                        Email = tbEmail.Text,
                        Telefono = tbTelefono.Text,
                        CodiceFiscale = tbCodiceFiscale.Text,
                        StatoFamiliare = cbStatoFamiliare.Text,
                        Tipo = cbRuolo.Text,
                        Stormo = Int32.Parse(tbStormo.Text),
                        GruppoDiVolo = Int32.Parse(tbGruppoDiVolo.Text)
                    };

                    this.db.MILITARE.InsertOnSubmit(newMilitare);

                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Benvenuto, " + cbGrado.Text + "." + tbNome.Text + " " + tbCognome.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore nel database: " + ex);
                    }
                }
            }
        }

        private void btnAvanzata_Click(object sender, EventArgs e)
        {
            RicercaAvanzata rc = new RicercaAvanzata();
            rc.Show();
        }

        private void btnInserisciPatente_Click(object sender, EventArgs e)
        {
            if (cbPatMil.Text == "" || cbPatAero.Text == "")
            {
                MessageBox.Show("Campi Vuoti", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePatente.Value > DateTime.Now)
            {
                MessageBox.Show("Non puoi viaggiare nel futuro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                PATENTE newPat = new PATENTE()
                {
                    CodiceAeromobile = cbPatAero.Text,
                    MatricolaMilitare = cbPatMil.Text,
                    DataDiRilascio = dateTimePatente.Value
                };

                this.db.PATENTE.InsertOnSubmit(newPat);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Patente inserita");
                    var data = from P in db.PATENTE
                               select P;
                    PatenteView.DataSource = data;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel database: " + ex);
                }
            }
        }

        private void AutoComplete(object sender, EventArgs e)
        {
            tbCodiceAeromobile.Text = this.idGenerator.generateIdCode(10);
        }

        private void btnInserisciAereo_Click(object sender, EventArgs e)
        {
            if (tbCodiceAeromobile.Text == "" || tbNomerAeromobile.Text == "" || tbCostruttore.Text == "" ||
                tbQuotaOperativa.Text == "" || tbVelocitàMax.Text == "" || tbAutonomia.Text == "" || tbSpintaMax.Text == "" ||
                tbCapienzaSer.Text == "" || tbMotore.Text == "" || tbPeso.Text == "" || tbPistaAtt.Text == "" || tbDimesioni.Text == "")
            {
                MessageBox.Show("Campi vuoti", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                AEROMOBILE aereo = new AEROMOBILE()
                {
                    CodiceAeromobile = tbCodiceAeromobile.Text,
                    Nome = tbNomerAeromobile.Text,
                    Costruttore = tbCostruttore.Text,
                    FunzionePrimaria = cbFunzionePrimaria.Text,
                    QuotaOperativa = float.Parse(tbQuotaOperativa.Text),
                    VelocitàMassima = float.Parse(tbVelocitàMax.Text),
                    Autonomia = float.Parse(tbAutonomia.Text),
                    SpintaMassima = float.Parse(tbSpintaMax.Text),
                    CapienzaSerbatoio = float.Parse(tbCapienzaSer.Text),
                    Motore = tbMotore.Text,
                    Peso = float.Parse(tbPeso.Text),
                    LunghezzaPistaDiAtterraggio = float.Parse(tbPistaAtt.Text),
                    Dimensioni = tbDimesioni.Text,
                    NumeroMembri = int.Parse(cbNumeroMembri.Text)
                };

                this.db.AEROMOBILE.InsertOnSubmit(aereo);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Velivolo inserito");
                    var data = from A in db.AEROMOBILE
                               select A;
                    AereoView.DataSource = data;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel database: " + ex);
                }
            }
        }

        private void btnVisualizzaAereo_Click(object sender, EventArgs e)
        {
            var data = from A in db.AEROMOBILE
                       select A;
            AereoView.DataSource = data;
        }

        private void RiempiCodice(object sender, EventArgs e)
        {
            tbCodArmamento.Text = this.idGenerator.generateIdCode(10);
        }

        private void btnInserisciArmamento_Click(object sender, EventArgs e)
        {
            if (cbCodAereoArm.Text == "" || tbCodArmamento.Text == "" || tbNumeroMissili.Text == "" || tbNumeroMunizioni.Text == "")
            {
                MessageBox.Show("Campi vuoti", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                ARMAMENTO arm = new ARMAMENTO()
                {
                    CodiceArmamento = tbCodArmamento.Text,
                    CodiceAeromobile = cbCodAereoArm.Text,
                    NumeroMissili = int.Parse(tbNumeroMissili.Text),
                    NumeroMunizioni = int.Parse(tbNumeroMunizioni.Text)
                };

                this.db.ARMAMENTO.InsertOnSubmit(arm);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Armamento inserito");
                    var data = from A in db.ARMAMENTO
                               select A;
                    ArmamentoView.DataSource = data;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel database: " + ex);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = from A in db.ARMAMENTO
                       select A;
            ArmamentoView.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbCodAereoMan.Text == "" || cbCodSpecMan.Text == "")
            {
                MessageBox.Show("Campi vuoti", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MANUTENZIONE man = new MANUTENZIONE()
                {
                    CodiceAeromobile = cbCodAereoMan.Text,
                    MatricolaMilitare = cbCodSpecMan.Text,
                    Data = dtMan.Value,
                    StatoDelVelivolo = this.stato_velivolo()
                };

                this.db.MANUTENZIONE.InsertOnSubmit(man);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Manutenzione inserita");
                    var data = from M in db.MANUTENZIONE
                               select M;
                    ManView.DataSource = data;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel database: " + ex);
                }
            }
        }

        private bool stato_velivolo() 
        {
            return (cbStato.Text == "Funzionante") ? true : false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var data = from M in db.MANUTENZIONE
                       select M;
            ManView.DataSource = data;
        }

        private void Riempimento(object sender, EventArgs e)
        {
            tbCodIdoneità.Text = this.idGenerator.generateIdCode(10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbCodIdoneità.Text == "" || cbCodPilotaIdon.Text == "")
            {
                MessageBox.Show("Campi vuoti", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                IDONEITA_MEDICA iDONEITA = new IDONEITA_MEDICA()
                {
                    CodiceIdoneità = tbCodIdoneità.Text,
                    MatricolaMilitare = cbCodPilotaIdon.Text,
                    StatoMentale = this.statoMentale(),
                    CondizioniGenerali = this.condizioniGenerali(),
                    DataDiScadenza = dtId.Value
                };

                this.db.IDONEITA_MEDICA.InsertOnSubmit(iDONEITA);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Idoneità inserita");
                    var data = from I in db.IDONEITA_MEDICA
                               select I;
                    IdonView.DataSource = data;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel database: " + ex);
                }
            }
        }

        private bool statoMentale() 
        {
            return (cbStatoMentale.Text == "Ottimo") ? true : false;
        }

        private bool condizioniGenerali() 
        {
            return (cbCondizioniGenerali.Text == "Ottimo") ? true : false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var data = from I in db.IDONEITA_MEDICA
                       select I;
            IdonView.DataSource = data;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tbCodiceVolo.Text == "" || tbArrivo.Text == "" || tbPartenza.Text == "" || tbDurata.Text == "" || cbAeromobileVolo.Text == "" || cbNomeVolo.Text == "" || cbMatricolaVolo.Text == "")
            {
                MessageBox.Show("Campi vuoti", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                VOLO volo = new VOLO()
                {
                    CodiceVolo = tbCodiceVolo.Text,
                    Arrivo = float.Parse(tbArrivo.Text),
                    Partenza = float.Parse(tbPartenza.Text),
                    DurataComplessiva = int.Parse(tbDurata.Text),
                    CodiceAeromobile = cbAeromobileVolo.Text,
                    Nome = cbNomeVolo.Text,
                    MatricolaMilitare = cbMatricolaVolo.Text,
                    Data = dtVolo.Value

                };

                this.db.VOLO.InsertOnSubmit(volo);

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Volo Inserito");
                    var data = from V in db.VOLO
                               select V;
                    voloView.DataSource = data;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore nel database: " + ex);
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var data = from V in db.VOLO
                       select V;
            voloView.DataSource = data;
        }

        private void riempi(object sender, EventArgs e)
        {
            tbCodiceVolo.Text = this.idGenerator.generateIdCode(10);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var aereomobile_difettoso = (from v in db.VOLO
                                         where
                                           v.MISSIONE.Emergenza == true
                                         group v.AEROMOBILE by new
                                         {
                                             v.AEROMOBILE.CodiceAeromobile
                                         } into g
                                         orderby
                                           g.Count() descending
                                         select new
                                         {
                                             g.Key.CodiceAeromobile,
                                             NumeroAtterraggiEmergenza = g.Count()
                                         }).Take(1);
            dtStatistiche.DataSource = aereomobile_difettoso;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var manutentore_peggiore = (from m in db.MANUTENZIONE
                                        where
                                          m.MILITARE.Tipo == "Specialista" &&
                                          m.CodiceAeromobile ==
                                            ((from v in db.VOLO
                                              where v.MISSIONE.Emergenza == true
                                              group v.AEROMOBILE by new
                                              {
                                                  v.AEROMOBILE.CodiceAeromobile
                                              } into g
                                              orderby g.Count() descending
                                              select new
                                              {
                                                  g.Key.CodiceAeromobile
                                              }).Take(1).First().CodiceAeromobile)
                                        select new
                                        {
                                            MatricolaMilitare = m.MILITARE.MatricolaMilitare,
                                            Nome = m.MILITARE.Nome,
                                            Cognome = m.MILITARE.Cognome,
                                            Grado = m.MILITARE.Grado,
                                            Email = m.MILITARE.Email,
                                            Telefono = m.MILITARE.Telefono,
                                            CodiceFiscale = m.MILITARE.CodiceFiscale,
                                            StatoFamiliare = m.MILITARE.StatoFamiliare,
                                            Tipo = m.MILITARE.Tipo,
                                            Stormo = m.MILITARE.Stormo,
                                            GruppoDiVolo = m.MILITARE.GruppoDiVolo
                                        }).Distinct();
            dtStatistiche.DataSource = manutentore_peggiore;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float maxValue = db.AEROMOBILE.Max(x => x.SpintaMassima);
            var decollo_rapido = from a in db.AEROMOBILE
                                 where a.SpintaMassima == maxValue
                                 select new
                                 {
                                     a.CodiceAeromobile,
                                     a.Nome,
                                     a.SpintaMassima
                                 };
            dtStatistiche.DataSource = decollo_rapido;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var più_usato = (from v in db.VOLO
                             group new { v.AEROMOBILE, v } by new
                             {
                                 v.AEROMOBILE.CodiceAeromobile,
                             } into g
                             orderby (int?)g.Sum(p => p.v.DurataComplessiva) descending
                             select new
                             {
                                 g.Key.CodiceAeromobile,
                                 OreTotali = (int?)g.Sum(p => p.v.DurataComplessiva)
                             }).Take(1);
            dtStatistiche.DataSource = più_usato;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var combinazione_migliore = from v in db.VOLO
                                        where
                                          v.AEROMOBILE.CodiceAeromobile ==
                                            ((from a0 in db.AEROMOBILE
                                              orderby a0.SpintaMassima descending
                                              select new
                                              {
                                                  a0.CodiceAeromobile
                                              }).Take(1).First().CodiceAeromobile) &&
                                          v.MILITARE.MatricolaMilitare ==
                                            ((from v1 in db.VOLO
                                              where v1.MILITARE.Tipo == "Pilota" &&
                                              v1.AEROMOBILE.CodiceAeromobile == ((from a0 in db.AEROMOBILE
                                                                                  orderby a0.SpintaMassima descending
                                                                                  select new
                                                                                  {
                                                                                      a0.CodiceAeromobile
                                                                                  }).Take(1).First().CodiceAeromobile)
                                              group new { v.MILITARE, v.AEROMOBILE } by new
                                              {
                                                  v.MILITARE.MatricolaMilitare,
                                                  v.AEROMOBILE.CodiceAeromobile
                                              } into g
                                              where g.Sum(p => v.DurataComplessiva) > 0
                                              select new
                                              {
                                                  g.Key.MatricolaMilitare
                                              }).First().MatricolaMilitare)
                                        select new
                                        {
                                            v.MILITARE.MatricolaMilitare,
                                            v.AEROMOBILE.CodiceAeromobile
                                        };
        }
    }
}
