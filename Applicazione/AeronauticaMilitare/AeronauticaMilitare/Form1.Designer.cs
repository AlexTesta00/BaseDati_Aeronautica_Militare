
namespace AeronauticaMilitare
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tab = new System.Windows.Forms.TabControl();
            this.tabMilitare = new System.Windows.Forms.TabPage();
            this.GVMilitare = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAvanzata = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbTutto = new System.Windows.Forms.RadioButton();
            this.rbPiloti = new System.Windows.Forms.RadioButton();
            this.rbSpecialisti = new System.Windows.Forms.RadioButton();
            this.bMilitariSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserisciMilitare = new System.Windows.Forms.Button();
            this.cbRuolo = new System.Windows.Forms.ComboBox();
            this.tbGruppoDiVolo = new System.Windows.Forms.TextBox();
            this.tbStormo = new System.Windows.Forms.TextBox();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.cbStatoFamiliare = new System.Windows.Forms.ComboBox();
            this.tbCodiceFiscale = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbMatricola = new System.Windows.Forms.TextBox();
            this.tabPatente = new System.Windows.Forms.TabPage();
            this.PatenteView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePatente = new System.Windows.Forms.DateTimePicker();
            this.btnInserisciPatente = new System.Windows.Forms.Button();
            this.cbPatMil = new System.Windows.Forms.ComboBox();
            this.cbPatAero = new System.Windows.Forms.ComboBox();
            this.tabVelivoli = new System.Windows.Forms.TabPage();
            this.tabArmemento = new System.Windows.Forms.TabPage();
            this.tabManutenzione = new System.Windows.Forms.TabPage();
            this.tabMedica = new System.Windows.Forms.TabPage();
            this.tabMissione = new System.Windows.Forms.TabPage();
            this.tabAeroporto = new System.Windows.Forms.TabPage();
            this.tabVolo = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AereoView = new System.Windows.Forms.DataGridView();
            this.tbCodiceAeromobile = new System.Windows.Forms.TextBox();
            this.tbNomerAeromobile = new System.Windows.Forms.TextBox();
            this.tbAutonomia = new System.Windows.Forms.TextBox();
            this.tbCapienzaSer = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.tbCostruttore = new System.Windows.Forms.TextBox();
            this.tbQuotaOperativa = new System.Windows.Forms.TextBox();
            this.tbVelocitàMax = new System.Windows.Forms.TextBox();
            this.tbSpintaMax = new System.Windows.Forms.TextBox();
            this.tbMotore = new System.Windows.Forms.TextBox();
            this.tbPistaAtt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFunzionePrimaria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDimesioni = new System.Windows.Forms.RichTextBox();
            this.btnInserisciAereo = new System.Windows.Forms.Button();
            this.cbNumeroMembri = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnVisualizzaAereo = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabMilitare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVMilitare)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPatente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatenteView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabVelivoli.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AereoView)).BeginInit();
            this.groupBox6.SuspendLayout();
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
            // GVMilitare
            // 
            this.GVMilitare.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GVMilitare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVMilitare.Location = new System.Drawing.Point(438, 6);
            this.GVMilitare.Name = "GVMilitare";
            this.GVMilitare.Size = new System.Drawing.Size(936, 596);
            this.GVMilitare.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAvanzata);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.bMilitariSelect);
            this.groupBox2.Location = new System.Drawing.Point(7, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 289);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visualizza";
            // 
            // btnAvanzata
            // 
            this.btnAvanzata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAvanzata.Location = new System.Drawing.Point(213, 260);
            this.btnAvanzata.Name = "btnAvanzata";
            this.btnAvanzata.Size = new System.Drawing.Size(206, 23);
            this.btnAvanzata.TabIndex = 5;
            this.btnAvanzata.Text = "Ricerca Avanzata...";
            this.btnAvanzata.UseVisualStyleBackColor = true;
            this.btnAvanzata.Click += new System.EventHandler(this.btnAvanzata_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbTutto);
            this.groupBox3.Controls.Add(this.rbPiloti);
            this.groupBox3.Controls.Add(this.rbSpecialisti);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 235);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Limita";
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
            this.bMilitariSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bMilitariSelect.Location = new System.Drawing.Point(6, 260);
            this.bMilitariSelect.Name = "bMilitariSelect";
            this.bMilitariSelect.Size = new System.Drawing.Size(206, 23);
            this.bMilitariSelect.TabIndex = 3;
            this.bMilitariSelect.Text = "Cerca";
            this.bMilitariSelect.UseVisualStyleBackColor = true;
            this.bMilitariSelect.Click += new System.EventHandler(this.bMilitariSelect_Click);
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
            // btnInserisciMilitare
            // 
            this.btnInserisciMilitare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnInserisciMilitare.Location = new System.Drawing.Point(12, 272);
            this.btnInserisciMilitare.Name = "btnInserisciMilitare";
            this.btnInserisciMilitare.Size = new System.Drawing.Size(407, 23);
            this.btnInserisciMilitare.TabIndex = 11;
            this.btnInserisciMilitare.Text = "Inserisci";
            this.btnInserisciMilitare.UseVisualStyleBackColor = true;
            this.btnInserisciMilitare.Click += new System.EventHandler(this.btnInserisciMilitare_Click);
            // 
            // cbRuolo
            // 
            this.cbRuolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRuolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            // tbGruppoDiVolo
            // 
            this.tbGruppoDiVolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbGruppoDiVolo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbGruppoDiVolo.Location = new System.Drawing.Point(106, 175);
            this.tbGruppoDiVolo.MaxLength = 3;
            this.tbGruppoDiVolo.Name = "tbGruppoDiVolo";
            this.tbGruppoDiVolo.Size = new System.Drawing.Size(86, 20);
            this.tbGruppoDiVolo.TabIndex = 9;
            this.tbGruppoDiVolo.Text = "Gruppo";
            this.tbGruppoDiVolo.Click += new System.EventHandler(this.ClearTextGV);
            // 
            // tbStormo
            // 
            this.tbStormo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbStormo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbStormo.Location = new System.Drawing.Point(12, 175);
            this.tbStormo.MaxLength = 3;
            this.tbStormo.Name = "tbStormo";
            this.tbStormo.Size = new System.Drawing.Size(86, 20);
            this.tbStormo.TabIndex = 8;
            this.tbStormo.Text = "Stormo";
            this.tbStormo.Click += new System.EventHandler(this.ClearTextST);
            // 
            // cbGrado
            // 
            this.cbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            // cbStatoFamiliare
            // 
            this.cbStatoFamiliare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatoFamiliare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            // tbCodiceFiscale
            // 
            this.tbCodiceFiscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbCodiceFiscale.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCodiceFiscale.Location = new System.Drawing.Point(12, 149);
            this.tbCodiceFiscale.MaxLength = 16;
            this.tbCodiceFiscale.Name = "tbCodiceFiscale";
            this.tbCodiceFiscale.Size = new System.Drawing.Size(180, 20);
            this.tbCodiceFiscale.TabIndex = 5;
            this.tbCodiceFiscale.Text = "CodiceFiscale";
            this.tbCodiceFiscale.Click += new System.EventHandler(this.ClearTextCF);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbTelefono.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbTelefono.Location = new System.Drawing.Point(12, 123);
            this.tbTelefono.MaxLength = 13;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(180, 20);
            this.tbTelefono.TabIndex = 4;
            this.tbTelefono.Text = "Telefono";
            this.tbTelefono.Click += new System.EventHandler(this.ClearTextT);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbEmail.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEmail.Location = new System.Drawing.Point(12, 97);
            this.tbEmail.MaxLength = 30;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Text = "Email";
            this.tbEmail.Click += new System.EventHandler(this.ClearTextE);
            // 
            // tbCognome
            // 
            this.tbCognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbCognome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCognome.Location = new System.Drawing.Point(12, 71);
            this.tbCognome.MaxLength = 10;
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(180, 20);
            this.tbCognome.TabIndex = 2;
            this.tbCognome.Text = "Cognome";
            this.tbCognome.Click += new System.EventHandler(this.ClearTextC);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbNome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNome.Location = new System.Drawing.Point(12, 45);
            this.tbNome.MaxLength = 10;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(180, 20);
            this.tbNome.TabIndex = 1;
            this.tbNome.Text = "Nome";
            this.tbNome.Click += new System.EventHandler(this.ClearTextN);
            // 
            // tbMatricola
            // 
            this.tbMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbMatricola.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbMatricola.Location = new System.Drawing.Point(12, 19);
            this.tbMatricola.MaxLength = 20;
            this.tbMatricola.Name = "tbMatricola";
            this.tbMatricola.Size = new System.Drawing.Size(180, 20);
            this.tbMatricola.TabIndex = 0;
            this.tbMatricola.Text = "Matricola";
            this.tbMatricola.Click += new System.EventHandler(this.ClearText);
            // 
            // tabPatente
            // 
            this.tabPatente.Controls.Add(this.PatenteView);
            this.tabPatente.Controls.Add(this.groupBox4);
            this.tabPatente.Location = new System.Drawing.Point(4, 22);
            this.tabPatente.Name = "tabPatente";
            this.tabPatente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatente.Size = new System.Drawing.Size(1386, 609);
            this.tabPatente.TabIndex = 1;
            this.tabPatente.Text = "Patente";
            this.tabPatente.UseVisualStyleBackColor = true;
            // 
            // PatenteView
            // 
            this.PatenteView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PatenteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatenteView.Location = new System.Drawing.Point(213, 6);
            this.PatenteView.Name = "PatenteView";
            this.PatenteView.Size = new System.Drawing.Size(1161, 594);
            this.PatenteView.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePatente);
            this.groupBox4.Controls.Add(this.btnInserisciPatente);
            this.groupBox4.Controls.Add(this.cbPatMil);
            this.groupBox4.Controls.Add(this.cbPatAero);
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 594);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inserimento";
            // 
            // dateTimePatente
            // 
            this.dateTimePatente.Location = new System.Drawing.Point(6, 73);
            this.dateTimePatente.Name = "dateTimePatente";
            this.dateTimePatente.Size = new System.Drawing.Size(188, 20);
            this.dateTimePatente.TabIndex = 3;
            // 
            // btnInserisciPatente
            // 
            this.btnInserisciPatente.Location = new System.Drawing.Point(6, 565);
            this.btnInserisciPatente.Name = "btnInserisciPatente";
            this.btnInserisciPatente.Size = new System.Drawing.Size(188, 23);
            this.btnInserisciPatente.TabIndex = 2;
            this.btnInserisciPatente.Text = "Inserisci";
            this.btnInserisciPatente.UseVisualStyleBackColor = true;
            this.btnInserisciPatente.Click += new System.EventHandler(this.btnInserisciPatente_Click);
            // 
            // cbPatMil
            // 
            this.cbPatMil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPatMil.FormattingEnabled = true;
            this.cbPatMil.Location = new System.Drawing.Point(6, 46);
            this.cbPatMil.Name = "cbPatMil";
            this.cbPatMil.Size = new System.Drawing.Size(188, 21);
            this.cbPatMil.TabIndex = 1;
            // 
            // cbPatAero
            // 
            this.cbPatAero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPatAero.FormattingEnabled = true;
            this.cbPatAero.Location = new System.Drawing.Point(6, 19);
            this.cbPatAero.Name = "cbPatAero";
            this.cbPatAero.Size = new System.Drawing.Size(188, 21);
            this.cbPatAero.TabIndex = 0;
            // 
            // tabVelivoli
            // 
            this.tabVelivoli.Controls.Add(this.AereoView);
            this.tabVelivoli.Controls.Add(this.groupBox5);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.cbNumeroMembri);
            this.groupBox5.Controls.Add(this.btnInserisciAereo);
            this.groupBox5.Controls.Add(this.tbDimesioni);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cbFunzionePrimaria);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.tbPistaAtt);
            this.groupBox5.Controls.Add(this.tbMotore);
            this.groupBox5.Controls.Add(this.tbSpintaMax);
            this.groupBox5.Controls.Add(this.tbVelocitàMax);
            this.groupBox5.Controls.Add(this.tbQuotaOperativa);
            this.groupBox5.Controls.Add(this.tbCostruttore);
            this.groupBox5.Controls.Add(this.tbPeso);
            this.groupBox5.Controls.Add(this.tbCapienzaSer);
            this.groupBox5.Controls.Add(this.tbAutonomia);
            this.groupBox5.Controls.Add(this.tbNomerAeromobile);
            this.groupBox5.Controls.Add(this.tbCodiceAeromobile);
            this.groupBox5.Location = new System.Drawing.Point(7, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(389, 594);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Specifiche";
            // 
            // AereoView
            // 
            this.AereoView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AereoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AereoView.Location = new System.Drawing.Point(402, 9);
            this.AereoView.Name = "AereoView";
            this.AereoView.Size = new System.Drawing.Size(972, 594);
            this.AereoView.TabIndex = 1;
            // 
            // tbCodiceAeromobile
            // 
            this.tbCodiceAeromobile.Location = new System.Drawing.Point(6, 49);
            this.tbCodiceAeromobile.MaxLength = 10;
            this.tbCodiceAeromobile.Name = "tbCodiceAeromobile";
            this.tbCodiceAeromobile.Size = new System.Drawing.Size(178, 20);
            this.tbCodiceAeromobile.TabIndex = 0;
            this.tbCodiceAeromobile.Click += new System.EventHandler(this.AutoComplete);
            // 
            // tbNomerAeromobile
            // 
            this.tbNomerAeromobile.Location = new System.Drawing.Point(6, 91);
            this.tbNomerAeromobile.MaxLength = 10;
            this.tbNomerAeromobile.Name = "tbNomerAeromobile";
            this.tbNomerAeromobile.Size = new System.Drawing.Size(178, 20);
            this.tbNomerAeromobile.TabIndex = 1;
            // 
            // tbAutonomia
            // 
            this.tbAutonomia.Location = new System.Drawing.Point(6, 302);
            this.tbAutonomia.MaxLength = 10;
            this.tbAutonomia.Name = "tbAutonomia";
            this.tbAutonomia.Size = new System.Drawing.Size(178, 20);
            this.tbAutonomia.TabIndex = 3;
            // 
            // tbCapienzaSer
            // 
            this.tbCapienzaSer.Location = new System.Drawing.Point(193, 49);
            this.tbCapienzaSer.MaxLength = 10;
            this.tbCapienzaSer.Name = "tbCapienzaSer";
            this.tbCapienzaSer.Size = new System.Drawing.Size(178, 20);
            this.tbCapienzaSer.TabIndex = 4;
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(193, 133);
            this.tbPeso.MaxLength = 10;
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(178, 20);
            this.tbPeso.TabIndex = 5;
            // 
            // tbCostruttore
            // 
            this.tbCostruttore.Location = new System.Drawing.Point(6, 133);
            this.tbCostruttore.Name = "tbCostruttore";
            this.tbCostruttore.Size = new System.Drawing.Size(178, 20);
            this.tbCostruttore.TabIndex = 6;
            // 
            // tbQuotaOperativa
            // 
            this.tbQuotaOperativa.Location = new System.Drawing.Point(6, 218);
            this.tbQuotaOperativa.MaxLength = 10;
            this.tbQuotaOperativa.Name = "tbQuotaOperativa";
            this.tbQuotaOperativa.Size = new System.Drawing.Size(178, 20);
            this.tbQuotaOperativa.TabIndex = 7;
            // 
            // tbVelocitàMax
            // 
            this.tbVelocitàMax.Location = new System.Drawing.Point(6, 260);
            this.tbVelocitàMax.MaxLength = 10;
            this.tbVelocitàMax.Name = "tbVelocitàMax";
            this.tbVelocitàMax.Size = new System.Drawing.Size(178, 20);
            this.tbVelocitàMax.TabIndex = 8;
            // 
            // tbSpintaMax
            // 
            this.tbSpintaMax.Location = new System.Drawing.Point(6, 349);
            this.tbSpintaMax.MaxLength = 8;
            this.tbSpintaMax.Name = "tbSpintaMax";
            this.tbSpintaMax.Size = new System.Drawing.Size(178, 20);
            this.tbSpintaMax.TabIndex = 10;
            // 
            // tbMotore
            // 
            this.tbMotore.Location = new System.Drawing.Point(193, 91);
            this.tbMotore.MaxLength = 10;
            this.tbMotore.Name = "tbMotore";
            this.tbMotore.Size = new System.Drawing.Size(178, 20);
            this.tbMotore.TabIndex = 11;
            // 
            // tbPistaAtt
            // 
            this.tbPistaAtt.Location = new System.Drawing.Point(193, 175);
            this.tbPistaAtt.Name = "tbPistaAtt";
            this.tbPistaAtt.Size = new System.Drawing.Size(178, 20);
            this.tbPistaAtt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Costruttore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Funzione Primaria";
            // 
            // cbFunzionePrimaria
            // 
            this.cbFunzionePrimaria.FormattingEnabled = true;
            this.cbFunzionePrimaria.Items.AddRange(new object[] {
            "Multiruolo",
            "Bombardiere",
            "Intercettatore",
            "Assalitore"});
            this.cbFunzionePrimaria.Location = new System.Drawing.Point(6, 175);
            this.cbFunzionePrimaria.Name = "cbFunzionePrimaria";
            this.cbFunzionePrimaria.Size = new System.Drawing.Size(178, 21);
            this.cbFunzionePrimaria.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quota Operativa (m)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Velocità Massima (mach)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Autonomia (km)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Spinta Massima (kg/s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(190, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Capienza Serbatoio (kg)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(190, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Motore";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(190, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Peso a vuoto (kg)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Lunghezza Pista  (km)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(190, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Numero Membri";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(190, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Dimensioni";
            // 
            // tbDimesioni
            // 
            this.tbDimesioni.Location = new System.Drawing.Point(193, 260);
            this.tbDimesioni.MaxLength = 50;
            this.tbDimesioni.Name = "tbDimesioni";
            this.tbDimesioni.Size = new System.Drawing.Size(178, 109);
            this.tbDimesioni.TabIndex = 29;
            this.tbDimesioni.Text = "";
            // 
            // btnInserisciAereo
            // 
            this.btnInserisciAereo.Location = new System.Drawing.Point(6, 565);
            this.btnInserisciAereo.Name = "btnInserisciAereo";
            this.btnInserisciAereo.Size = new System.Drawing.Size(377, 23);
            this.btnInserisciAereo.TabIndex = 30;
            this.btnInserisciAereo.Text = "Inserisci";
            this.btnInserisciAereo.UseVisualStyleBackColor = true;
            this.btnInserisciAereo.Click += new System.EventHandler(this.btnInserisciAereo_Click);
            // 
            // cbNumeroMembri
            // 
            this.cbNumeroMembri.FormattingEnabled = true;
            this.cbNumeroMembri.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbNumeroMembri.Location = new System.Drawing.Point(193, 217);
            this.cbNumeroMembri.Name = "cbNumeroMembri";
            this.cbNumeroMembri.Size = new System.Drawing.Size(178, 21);
            this.cbNumeroMembri.TabIndex = 31;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnVisualizzaAereo);
            this.groupBox6.Location = new System.Drawing.Point(6, 375);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(365, 184);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Visualizza";
            // 
            // btnVisualizzaAereo
            // 
            this.btnVisualizzaAereo.Location = new System.Drawing.Point(6, 19);
            this.btnVisualizzaAereo.Name = "btnVisualizzaAereo";
            this.btnVisualizzaAereo.Size = new System.Drawing.Size(353, 159);
            this.btnVisualizzaAereo.TabIndex = 0;
            this.btnVisualizzaAereo.Text = "Visualizza Tutto";
            this.btnVisualizzaAereo.UseVisualStyleBackColor = true;
            this.btnVisualizzaAereo.Click += new System.EventHandler(this.btnVisualizzaAereo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1391, 634);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Militare";
            this.tab.ResumeLayout(false);
            this.tabMilitare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVMilitare)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPatente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PatenteView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabVelivoli.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AereoView)).EndInit();
            this.groupBox6.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAvanzata;
        private System.Windows.Forms.DataGridView PatenteView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePatente;
        private System.Windows.Forms.Button btnInserisciPatente;
        private System.Windows.Forms.ComboBox cbPatMil;
        private System.Windows.Forms.ComboBox cbPatAero;
        private System.Windows.Forms.DataGridView AereoView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbFunzionePrimaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPistaAtt;
        private System.Windows.Forms.TextBox tbMotore;
        private System.Windows.Forms.TextBox tbSpintaMax;
        private System.Windows.Forms.TextBox tbVelocitàMax;
        private System.Windows.Forms.TextBox tbQuotaOperativa;
        private System.Windows.Forms.TextBox tbCostruttore;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.TextBox tbCapienzaSer;
        private System.Windows.Forms.TextBox tbAutonomia;
        private System.Windows.Forms.TextBox tbNomerAeromobile;
        private System.Windows.Forms.TextBox tbCodiceAeromobile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbNumeroMembri;
        private System.Windows.Forms.Button btnInserisciAereo;
        private System.Windows.Forms.RichTextBox tbDimesioni;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnVisualizzaAereo;
    }
}

