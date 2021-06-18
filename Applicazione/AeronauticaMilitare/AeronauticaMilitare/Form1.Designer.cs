
namespace AeronauticaMilitare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabMilitare = new System.Windows.Forms.TabPage();
            this.tabPatente = new System.Windows.Forms.TabPage();
            this.tabVelivoli = new System.Windows.Forms.TabPage();
            this.tabArmemento = new System.Windows.Forms.TabPage();
            this.tabManutenzione = new System.Windows.Forms.TabPage();
            this.tabMedica = new System.Windows.Forms.TabPage();
            this.tabMissione = new System.Windows.Forms.TabPage();
            this.tabAeroporto = new System.Windows.Forms.TabPage();
            this.tabVolo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GVMilitare = new System.Windows.Forms.DataGridView();
            this.rbTutto = new System.Windows.Forms.RadioButton();
            this.rbPiloti = new System.Windows.Forms.RadioButton();
            this.rbSpecialisti = new System.Windows.Forms.RadioButton();
            this.bMilitariSelect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTotali = new System.Windows.Forms.RadioButton();
            this.rbVelivolo = new System.Windows.Forms.RadioButton();
            this.tbMatricola = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbCodiceFiscale = new System.Windows.Forms.TextBox();
            this.cbStatoFamiliare = new System.Windows.Forms.ComboBox();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.tbStormo = new System.Windows.Forms.TextBox();
            this.tbGruppoDiVolo = new System.Windows.Forms.TextBox();
            this.cbRuolo = new System.Windows.Forms.ComboBox();
            this.btnInserisciMilitare = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabMilitare.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVMilitare)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabMilitare);
            this.tab.Controls.Add(this.tabPatente);
            this.tab.Controls.Add(this.tabVelivoli);
            this.tab.Controls.Add(this.tabArmemento);
            this.tab.Controls.Add(this.tabManutenzione);
            this.tab.Controls.Add(this.tabMedica);
            this.tab.Controls.Add(this.tabMissione);
            this.tab.Controls.Add(this.tabAeroporto);
            this.tab.Controls.Add(this.tabVolo);
            this.tab.Location = new System.Drawing.Point(1, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1394, 635);
            this.tab.TabIndex = 0;
            // 
            // tabMilitare
            // 
            this.tabMilitare.Controls.Add(this.GVMilitare);
            this.tabMilitare.Controls.Add(this.groupBox2);
            this.tabMilitare.Controls.Add(this.groupBox1);
            this.tabMilitare.Location = new System.Drawing.Point(4, 22);
            this.tabMilitare.Name = "tabMilitare";
            this.tabMilitare.Padding = new System.Windows.Forms.Padding(3);
            this.tabMilitare.Size = new System.Drawing.Size(1386, 609);
            this.tabMilitare.TabIndex = 0;
            this.tabMilitare.Text = "Militare";
            this.tabMilitare.UseVisualStyleBackColor = true;
            // 
            // tabPatente
            // 
            this.tabPatente.Location = new System.Drawing.Point(4, 22);
            this.tabPatente.Name = "tabPatente";
            this.tabPatente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatente.Size = new System.Drawing.Size(1386, 609);
            this.tabPatente.TabIndex = 1;
            this.tabPatente.Text = "Patente";
            this.tabPatente.UseVisualStyleBackColor = true;
            // 
            // tabVelivoli
            // 
            this.tabVelivoli.Location = new System.Drawing.Point(4, 22);
            this.tabVelivoli.Name = "tabVelivoli";
            this.tabVelivoli.Padding = new System.Windows.Forms.Padding(3);
            this.tabVelivoli.Size = new System.Drawing.Size(1386, 609);
            this.tabVelivoli.TabIndex = 2;
            this.tabVelivoli.Text = "Velivoli";
            this.tabVelivoli.UseVisualStyleBackColor = true;
            // 
            // tabArmemento
            // 
            this.tabArmemento.Location = new System.Drawing.Point(4, 22);
            this.tabArmemento.Name = "tabArmemento";
            this.tabArmemento.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmemento.Size = new System.Drawing.Size(1386, 609);
            this.tabArmemento.TabIndex = 3;
            this.tabArmemento.Text = "Armamento";
            this.tabArmemento.UseVisualStyleBackColor = true;
            // 
            // tabManutenzione
            // 
            this.tabManutenzione.Location = new System.Drawing.Point(4, 22);
            this.tabManutenzione.Name = "tabManutenzione";
            this.tabManutenzione.Padding = new System.Windows.Forms.Padding(3);
            this.tabManutenzione.Size = new System.Drawing.Size(1386, 609);
            this.tabManutenzione.TabIndex = 4;
            this.tabManutenzione.Text = "Manutenzione";
            this.tabManutenzione.UseVisualStyleBackColor = true;
            // 
            // tabMedica
            // 
            this.tabMedica.Location = new System.Drawing.Point(4, 22);
            this.tabMedica.Name = "tabMedica";
            this.tabMedica.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedica.Size = new System.Drawing.Size(1386, 609);
            this.tabMedica.TabIndex = 5;
            this.tabMedica.Text = "Idoneità Medica";
            this.tabMedica.UseVisualStyleBackColor = true;
            // 
            // tabMissione
            // 
            this.tabMissione.Location = new System.Drawing.Point(4, 22);
            this.tabMissione.Name = "tabMissione";
            this.tabMissione.Padding = new System.Windows.Forms.Padding(3);
            this.tabMissione.Size = new System.Drawing.Size(1386, 609);
            this.tabMissione.TabIndex = 6;
            this.tabMissione.Text = "Missione";
            this.tabMissione.UseVisualStyleBackColor = true;
            // 
            // tabAeroporto
            // 
            this.tabAeroporto.Location = new System.Drawing.Point(4, 22);
            this.tabAeroporto.Name = "tabAeroporto";
            this.tabAeroporto.Padding = new System.Windows.Forms.Padding(3);
            this.tabAeroporto.Size = new System.Drawing.Size(1386, 609);
            this.tabAeroporto.TabIndex = 7;
            this.tabAeroporto.Text = "Aeroporto";
            this.tabAeroporto.UseVisualStyleBackColor = true;
            // 
            // tabVolo
            // 
            this.tabVolo.Location = new System.Drawing.Point(4, 22);
            this.tabVolo.Name = "tabVolo";
            this.tabVolo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVolo.Size = new System.Drawing.Size(1386, 609);
            this.tabVolo.TabIndex = 8;
            this.tabVolo.Text = "Volo";
            this.tabVolo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInserisciMilitare);
            this.groupBox1.Controls.Add(this.cbRuolo);
            this.groupBox1.Controls.Add(this.tbGruppoDiVolo);
            this.groupBox1.Controls.Add(this.tbStormo);
            this.groupBox1.Controls.Add(this.cbGrado);
            this.groupBox1.Controls.Add(this.cbStatoFamiliare);
            this.groupBox1.Controls.Add(this.tbCodiceFiscale);
            this.groupBox1.Controls.Add(this.tbTelefono);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbCognome);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.tbMatricola);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserimento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.bMilitariSelect);
            this.groupBox2.Location = new System.Drawing.Point(7, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualizza";
            // 
            // GVMilitare
            // 
            this.GVMilitare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVMilitare.Location = new System.Drawing.Point(438, 6);
            this.GVMilitare.Name = "GVMilitare";
            this.GVMilitare.Size = new System.Drawing.Size(936, 596);
            this.GVMilitare.TabIndex = 2;
            // 
            // rbTutto
            // 
            this.rbTutto.AutoSize = true;
            this.rbTutto.Checked = true;
            this.rbTutto.Location = new System.Drawing.Point(6, 19);
            this.rbTutto.Name = "rbTutto";
            this.rbTutto.Size = new System.Drawing.Size(50, 17);
            this.rbTutto.TabIndex = 0;
            this.rbTutto.TabStop = true;
            this.rbTutto.Text = "Tutto";
            this.rbTutto.UseVisualStyleBackColor = true;
            // 
            // rbPiloti
            // 
            this.rbPiloti.AutoSize = true;
            this.rbPiloti.Location = new System.Drawing.Point(6, 42);
            this.rbPiloti.Name = "rbPiloti";
            this.rbPiloti.Size = new System.Drawing.Size(47, 17);
            this.rbPiloti.TabIndex = 1;
            this.rbPiloti.Text = "Piloti";
            this.rbPiloti.UseVisualStyleBackColor = true;
            // 
            // rbSpecialisti
            // 
            this.rbSpecialisti.AutoSize = true;
            this.rbSpecialisti.Location = new System.Drawing.Point(6, 65);
            this.rbSpecialisti.Name = "rbSpecialisti";
            this.rbSpecialisti.Size = new System.Drawing.Size(72, 17);
            this.rbSpecialisti.TabIndex = 2;
            this.rbSpecialisti.Text = "Specialisti";
            this.rbSpecialisti.UseVisualStyleBackColor = true;
            // 
            // bMilitariSelect
            // 
            this.bMilitariSelect.Location = new System.Drawing.Point(6, 260);
            this.bMilitariSelect.Name = "bMilitariSelect";
            this.bMilitariSelect.Size = new System.Drawing.Size(413, 23);
            this.bMilitariSelect.TabIndex = 3;
            this.bMilitariSelect.Text = "Cerca";
            this.bMilitariSelect.UseVisualStyleBackColor = true;
            this.bMilitariSelect.Click += new System.EventHandler(this.bMilitariSelect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbVelivolo);
            this.groupBox3.Controls.Add(this.rbTutto);
            this.groupBox3.Controls.Add(this.rbTotali);
            this.groupBox3.Controls.Add(this.rbPiloti);
            this.groupBox3.Controls.Add(this.rbSpecialisti);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 235);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Limita";
            // 
            // rbTotali
            // 
            this.rbTotali.AutoSize = true;
            this.rbTotali.Location = new System.Drawing.Point(6, 88);
            this.rbTotali.Name = "rbTotali";
            this.rbTotali.Size = new System.Drawing.Size(101, 17);
            this.rbTotali.TabIndex = 3;
            this.rbTotali.Text = "Ore di volo totali";
            this.rbTotali.UseVisualStyleBackColor = true;
            // 
            // rbVelivolo
            // 
            this.rbVelivolo.AutoSize = true;
            this.rbVelivolo.Location = new System.Drawing.Point(6, 111);
            this.rbVelivolo.Name = "rbVelivolo";
            this.rbVelivolo.Size = new System.Drawing.Size(144, 17);
            this.rbVelivolo.TabIndex = 4;
            this.rbVelivolo.Text = "Ore di volo su un velivolo";
            this.rbVelivolo.UseVisualStyleBackColor = true;
            // 
            // tbMatricola
            // 
            this.tbMatricola.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMatricola.Location = new System.Drawing.Point(12, 19);
            this.tbMatricola.MaxLength = 20;
            this.tbMatricola.Name = "tbMatricola";
            this.tbMatricola.Size = new System.Drawing.Size(180, 20);
            this.tbMatricola.TabIndex = 0;
            this.tbMatricola.Text = "Matricola";
            this.tbMatricola.Click += new System.EventHandler(this.ClearText);
            // 
            // tbNome
            // 
            this.tbNome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNome.Location = new System.Drawing.Point(12, 45);
            this.tbNome.MaxLength = 10;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(180, 20);
            this.tbNome.TabIndex = 1;
            this.tbNome.Text = "Nome";
            this.tbNome.Click += new System.EventHandler(this.ClearTextN);
            // 
            // tbCognome
            // 
            this.tbCognome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCognome.Location = new System.Drawing.Point(12, 71);
            this.tbCognome.MaxLength = 10;
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(180, 20);
            this.tbCognome.TabIndex = 2;
            this.tbCognome.Text = "Cognome";
            this.tbCognome.Click += new System.EventHandler(this.ClearTextC);
            // 
            // tbEmail
            // 
            this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEmail.Location = new System.Drawing.Point(12, 97);
            this.tbEmail.MaxLength = 30;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Text = "Email";
            this.tbEmail.Click += new System.EventHandler(this.ClearTextE);
            // 
            // tbTelefono
            // 
            this.tbTelefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTelefono.Location = new System.Drawing.Point(12, 123);
            this.tbTelefono.MaxLength = 16;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(180, 20);
            this.tbTelefono.TabIndex = 4;
            this.tbTelefono.Text = "Telefono";
            this.tbTelefono.Click += new System.EventHandler(this.ClearTextT);
            // 
            // tbCodiceFiscale
            // 
            this.tbCodiceFiscale.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCodiceFiscale.Location = new System.Drawing.Point(12, 149);
            this.tbCodiceFiscale.MaxLength = 16;
            this.tbCodiceFiscale.Name = "tbCodiceFiscale";
            this.tbCodiceFiscale.Size = new System.Drawing.Size(180, 20);
            this.tbCodiceFiscale.TabIndex = 5;
            this.tbCodiceFiscale.Text = "CodiceFiscale";
            this.tbCodiceFiscale.Click += new System.EventHandler(this.ClearTextCF);
            // 
            // cbStatoFamiliare
            // 
            this.cbStatoFamiliare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatoFamiliare.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbStatoFamiliare.FormattingEnabled = true;
            this.cbStatoFamiliare.Items.AddRange(new object[] {
            "Celibe",
            "Nubile",
            "Sposato"});
            this.cbStatoFamiliare.Location = new System.Drawing.Point(212, 45);
            this.cbStatoFamiliare.Name = "cbStatoFamiliare";
            this.cbStatoFamiliare.Size = new System.Drawing.Size(180, 21);
            this.cbStatoFamiliare.Sorted = true;
            this.cbStatoFamiliare.TabIndex = 6;
            // 
            // cbGrado
            // 
            this.cbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Items.AddRange(new object[] {
            "Capitano",
            "Colonnello",
            "Generale",
            "Luogotenente",
            "Maggiore",
            "Maresciallo",
            "Tenente"});
            this.cbGrado.Location = new System.Drawing.Point(212, 19);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(180, 21);
            this.cbGrado.Sorted = true;
            this.cbGrado.TabIndex = 7;
            // 
            // tbStormo
            // 
            this.tbStormo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbStormo.Location = new System.Drawing.Point(12, 175);
            this.tbStormo.MaxLength = 3;
            this.tbStormo.Name = "tbStormo";
            this.tbStormo.Size = new System.Drawing.Size(86, 20);
            this.tbStormo.TabIndex = 8;
            this.tbStormo.Text = "Stormo";
            this.tbStormo.Click += new System.EventHandler(this.ClearTextST);
            // 
            // tbGruppoDiVolo
            // 
            this.tbGruppoDiVolo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbGruppoDiVolo.Location = new System.Drawing.Point(106, 175);
            this.tbGruppoDiVolo.MaxLength = 3;
            this.tbGruppoDiVolo.Name = "tbGruppoDiVolo";
            this.tbGruppoDiVolo.Size = new System.Drawing.Size(86, 20);
            this.tbGruppoDiVolo.TabIndex = 9;
            this.tbGruppoDiVolo.Text = "Gruppo";
            this.tbGruppoDiVolo.Click += new System.EventHandler(this.ClearTextGV);
            // 
            // cbRuolo
            // 
            this.cbRuolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRuolo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbRuolo.FormattingEnabled = true;
            this.cbRuolo.Items.AddRange(new object[] {
            "Pilota",
            "Specialista"});
            this.cbRuolo.Location = new System.Drawing.Point(212, 71);
            this.cbRuolo.Name = "cbRuolo";
            this.cbRuolo.Size = new System.Drawing.Size(180, 21);
            this.cbRuolo.Sorted = true;
            this.cbRuolo.TabIndex = 10;
            this.cbRuolo.SelectedIndexChanged += new System.EventHandler(this.cbRuolo_SelectedIndexChanged);
            // 
            // btnInserisciMilitare
            // 
            this.btnInserisciMilitare.Location = new System.Drawing.Point(12, 272);
            this.btnInserisciMilitare.Name = "btnInserisciMilitare";
            this.btnInserisciMilitare.Size = new System.Drawing.Size(407, 23);
            this.btnInserisciMilitare.TabIndex = 11;
            this.btnInserisciMilitare.Text = "Inserisci";
            this.btnInserisciMilitare.UseVisualStyleBackColor = true;
            this.btnInserisciMilitare.Click += new System.EventHandler(this.btnInserisciMilitare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 636);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Base Militare";
            this.tab.ResumeLayout(false);
            this.tabMilitare.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVMilitare)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabMilitare;
        private System.Windows.Forms.TabPage tabPatente;
        private System.Windows.Forms.TabPage tabVelivoli;
        private System.Windows.Forms.TabPage tabArmemento;
        private System.Windows.Forms.TabPage tabManutenzione;
        private System.Windows.Forms.TabPage tabMedica;
        private System.Windows.Forms.TabPage tabMissione;
        private System.Windows.Forms.TabPage tabAeroporto;
        private System.Windows.Forms.TabPage tabVolo;
        private System.Windows.Forms.DataGridView GVMilitare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbTutto;
        private System.Windows.Forms.RadioButton rbPiloti;
        private System.Windows.Forms.RadioButton rbSpecialisti;
        private System.Windows.Forms.Button bMilitariSelect;
        private System.Windows.Forms.RadioButton rbVelivolo;
        private System.Windows.Forms.RadioButton rbTotali;
        private System.Windows.Forms.ComboBox cbStatoFamiliare;
        private System.Windows.Forms.TextBox tbCodiceFiscale;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbMatricola;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.ComboBox cbRuolo;
        private System.Windows.Forms.TextBox tbGruppoDiVolo;
        private System.Windows.Forms.TextBox tbStormo;
        private System.Windows.Forms.Button btnInserisciMilitare;
    }
}

