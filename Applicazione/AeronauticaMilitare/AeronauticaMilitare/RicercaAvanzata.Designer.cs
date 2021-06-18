
namespace AeronauticaMilitare
{
    partial class RicercaAvanzata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RicercaAvanzata));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOredivolo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOredivolosuvelivolo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbMilitari = new System.Windows.Forms.ComboBox();
            this.cbAeromobili = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAeromobili);
            this.groupBox1.Controls.Add(this.cbMilitari);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ore di volo";
            // 
            // rbOredivolo
            // 
            this.rbOredivolo.AutoSize = true;
            this.rbOredivolo.Checked = true;
            this.rbOredivolo.Location = new System.Drawing.Point(6, 19);
            this.rbOredivolo.Name = "rbOredivolo";
            this.rbOredivolo.Size = new System.Drawing.Size(76, 17);
            this.rbOredivolo.TabIndex = 0;
            this.rbOredivolo.TabStop = true;
            this.rbOredivolo.Text = "Ore di volo";
            this.rbOredivolo.UseVisualStyleBackColor = true;
            this.rbOredivolo.CheckedChanged += new System.EventHandler(this.rbOredivolo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOredivolosuvelivolo);
            this.groupBox2.Controls.Add(this.rbOredivolo);
            this.groupBox2.Location = new System.Drawing.Point(6, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limita";
            // 
            // rbOredivolosuvelivolo
            // 
            this.rbOredivolosuvelivolo.AutoSize = true;
            this.rbOredivolosuvelivolo.Location = new System.Drawing.Point(6, 42);
            this.rbOredivolosuvelivolo.Name = "rbOredivolosuvelivolo";
            this.rbOredivolosuvelivolo.Size = new System.Drawing.Size(144, 17);
            this.rbOredivolosuvelivolo.TabIndex = 2;
            this.rbOredivolosuvelivolo.Text = "Ore di volo su un velivolo";
            this.rbOredivolosuvelivolo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerca";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbMilitari
            // 
            this.cbMilitari.FormattingEnabled = true;
            this.cbMilitari.Location = new System.Drawing.Point(12, 19);
            this.cbMilitari.Name = "cbMilitari";
            this.cbMilitari.Size = new System.Drawing.Size(317, 21);
            this.cbMilitari.TabIndex = 2;
            this.cbMilitari.SelectedIndexChanged += new System.EventHandler(this.cbMilitari_SelectedIndexChanged);
            // 
            // cbAeromobili
            // 
            this.cbAeromobili.Enabled = false;
            this.cbAeromobili.FormattingEnabled = true;
            this.cbAeromobili.Location = new System.Drawing.Point(12, 46);
            this.cbAeromobili.Name = "cbAeromobili";
            this.cbAeromobili.Size = new System.Drawing.Size(317, 21);
            this.cbAeromobili.TabIndex = 3;
            this.cbAeromobili.SelectedIndexChanged += new System.EventHandler(this.cbAeromobili_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(353, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 182);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Risultato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // RicercaAvanzata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 201);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RicercaAvanzata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RicercaAvanzata";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbAeromobili;
        private System.Windows.Forms.ComboBox cbMilitari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOredivolosuvelivolo;
        private System.Windows.Forms.RadioButton rbOredivolo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}