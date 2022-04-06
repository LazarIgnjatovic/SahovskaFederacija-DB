
namespace SahovskaFederacija.Forme
{
    partial class DodajTurnirForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajTurnirForma));
            this.button1 = new System.Windows.Forms.Button();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.tbZemlja = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lblDKraj = new System.Windows.Forms.Label();
            this.lblDPoc = new System.Windows.Forms.Label();
            this.lblGodina = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblZemlja = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.lblZnacaj = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblPrimalac = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tbZnacaj = new System.Windows.Forms.TextBox();
            this.tbPrimalac = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBrziopotezni = new System.Windows.Forms.CheckBox();
            this.rbTakmicarski = new System.Windows.Forms.RadioButton();
            this.rbPromotivni = new System.Windows.Forms.RadioButton();
            this.rbHumanitarni = new System.Windows.Forms.RadioButton();
            this.tbGodina = new System.Windows.Forms.NumericUpDown();
            this.tbSuma = new System.Windows.Forms.NumericUpDown();
            this.tbVreme = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSuma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVreme)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Felix Titling", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(260, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 51);
            this.button1.TabIndex = 49;
            this.button1.Text = "DODAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(155, 161);
            this.tbGrad.MaxLength = 50;
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(200, 22);
            this.tbGrad.TabIndex = 45;
            // 
            // tbZemlja
            // 
            this.tbZemlja.Location = new System.Drawing.Point(155, 133);
            this.tbZemlja.MaxLength = 50;
            this.tbZemlja.Name = "tbZemlja";
            this.tbZemlja.Size = new System.Drawing.Size(200, 22);
            this.tbZemlja.TabIndex = 44;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(155, 105);
            this.tbNaziv.MaxLength = 50;
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(200, 22);
            this.tbNaziv.TabIndex = 43;
            // 
            // lblDKraj
            // 
            this.lblDKraj.AutoSize = true;
            this.lblDKraj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDKraj.Location = new System.Drawing.Point(32, 248);
            this.lblDKraj.Name = "lblDKraj";
            this.lblDKraj.Size = new System.Drawing.Size(118, 17);
            this.lblDKraj.TabIndex = 42;
            this.lblDKraj.Text = "Datum zavrsetka:";
            // 
            // lblDPoc
            // 
            this.lblDPoc.AutoSize = true;
            this.lblDPoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDPoc.Location = new System.Drawing.Point(32, 220);
            this.lblDPoc.Name = "lblDPoc";
            this.lblDPoc.Size = new System.Drawing.Size(107, 17);
            this.lblDPoc.TabIndex = 41;
            this.lblDPoc.Text = "Datum pocetka:";
            // 
            // lblGodina
            // 
            this.lblGodina.AutoSize = true;
            this.lblGodina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGodina.Location = new System.Drawing.Point(32, 192);
            this.lblGodina.Name = "lblGodina";
            this.lblGodina.Size = new System.Drawing.Size(58, 17);
            this.lblGodina.TabIndex = 40;
            this.lblGodina.Text = "Godina:";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGrad.Location = new System.Drawing.Point(32, 164);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(44, 17);
            this.lblGrad.TabIndex = 39;
            this.lblGrad.Text = "Grad:";
            // 
            // lblZemlja
            // 
            this.lblZemlja.AutoSize = true;
            this.lblZemlja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblZemlja.Location = new System.Drawing.Point(32, 136);
            this.lblZemlja.Name = "lblZemlja";
            this.lblZemlja.Size = new System.Drawing.Size(54, 17);
            this.lblZemlja.TabIndex = 38;
            this.lblZemlja.Text = "Zemlja:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNaziv.Location = new System.Drawing.Point(32, 108);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(47, 17);
            this.lblNaziv.TabIndex = 37;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVreme.Location = new System.Drawing.Point(374, 108);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(53, 17);
            this.lblVreme.TabIndex = 50;
            this.lblVreme.Text = "Vreme:";
            // 
            // lblZnacaj
            // 
            this.lblZnacaj.AutoSize = true;
            this.lblZnacaj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblZnacaj.Location = new System.Drawing.Point(374, 136);
            this.lblZnacaj.Name = "lblZnacaj";
            this.lblZnacaj.Size = new System.Drawing.Size(55, 17);
            this.lblZnacaj.TabIndex = 51;
            this.lblZnacaj.Text = "Znacaj:";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSuma.Location = new System.Drawing.Point(374, 164);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(48, 17);
            this.lblSuma.TabIndex = 52;
            this.lblSuma.Text = "Suma:";
            // 
            // lblPrimalac
            // 
            this.lblPrimalac.AutoSize = true;
            this.lblPrimalac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrimalac.Location = new System.Drawing.Point(374, 192);
            this.lblPrimalac.Name = "lblPrimalac";
            this.lblPrimalac.Size = new System.Drawing.Size(66, 17);
            this.lblPrimalac.TabIndex = 53;
            this.lblPrimalac.Text = "Primalac:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(156, 248);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 55;
            // 
            // tbZnacaj
            // 
            this.tbZnacaj.Enabled = false;
            this.tbZnacaj.Location = new System.Drawing.Point(447, 133);
            this.tbZnacaj.MaxLength = 50;
            this.tbZnacaj.Name = "tbZnacaj";
            this.tbZnacaj.Size = new System.Drawing.Size(200, 22);
            this.tbZnacaj.TabIndex = 57;
            // 
            // tbPrimalac
            // 
            this.tbPrimalac.Enabled = false;
            this.tbPrimalac.Location = new System.Drawing.Point(446, 189);
            this.tbPrimalac.MaxLength = 50;
            this.tbPrimalac.Name = "tbPrimalac";
            this.tbPrimalac.Size = new System.Drawing.Size(200, 22);
            this.tbPrimalac.TabIndex = 59;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbBrziopotezni);
            this.groupBox1.Controls.Add(this.rbTakmicarski);
            this.groupBox1.Controls.Add(this.rbPromotivni);
            this.groupBox1.Controls.Add(this.rbHumanitarni);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(35, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 67);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip";
            // 
            // cbBrziopotezni
            // 
            this.cbBrziopotezni.AutoSize = true;
            this.cbBrziopotezni.Location = new System.Drawing.Point(462, 31);
            this.cbBrziopotezni.Name = "cbBrziopotezni";
            this.cbBrziopotezni.Size = new System.Drawing.Size(105, 21);
            this.cbBrziopotezni.TabIndex = 3;
            this.cbBrziopotezni.Text = "Brzopotezni";
            this.cbBrziopotezni.UseVisualStyleBackColor = true;
            this.cbBrziopotezni.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbTakmicarski
            // 
            this.rbTakmicarski.AutoSize = true;
            this.rbTakmicarski.Location = new System.Drawing.Point(228, 30);
            this.rbTakmicarski.Name = "rbTakmicarski";
            this.rbTakmicarski.Size = new System.Drawing.Size(104, 21);
            this.rbTakmicarski.TabIndex = 2;
            this.rbTakmicarski.Text = "Takmicarski";
            this.rbTakmicarski.UseVisualStyleBackColor = true;
            this.rbTakmicarski.CheckedChanged += new System.EventHandler(this.rbTakmicarski_CheckedChanged);
            // 
            // rbPromotivni
            // 
            this.rbPromotivni.AutoSize = true;
            this.rbPromotivni.Checked = true;
            this.rbPromotivni.Location = new System.Drawing.Point(117, 30);
            this.rbPromotivni.Name = "rbPromotivni";
            this.rbPromotivni.Size = new System.Drawing.Size(95, 21);
            this.rbPromotivni.TabIndex = 1;
            this.rbPromotivni.TabStop = true;
            this.rbPromotivni.Text = "Promotivni";
            this.rbPromotivni.UseVisualStyleBackColor = true;
            this.rbPromotivni.CheckedChanged += new System.EventHandler(this.rbPromotivni_CheckedChanged);
            // 
            // rbHumanitarni
            // 
            this.rbHumanitarni.AutoSize = true;
            this.rbHumanitarni.Location = new System.Drawing.Point(6, 30);
            this.rbHumanitarni.Name = "rbHumanitarni";
            this.rbHumanitarni.Size = new System.Drawing.Size(105, 21);
            this.rbHumanitarni.TabIndex = 0;
            this.rbHumanitarni.Text = "Humanitarni";
            this.rbHumanitarni.UseVisualStyleBackColor = true;
            this.rbHumanitarni.CheckedChanged += new System.EventHandler(this.rbHumanitarni_CheckedChanged);
            // 
            // tbGodina
            // 
            this.tbGodina.Location = new System.Drawing.Point(155, 190);
            this.tbGodina.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.tbGodina.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.tbGodina.Name = "tbGodina";
            this.tbGodina.Size = new System.Drawing.Size(199, 22);
            this.tbGodina.TabIndex = 61;
            this.tbGodina.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // tbSuma
            // 
            this.tbSuma.Enabled = false;
            this.tbSuma.Location = new System.Drawing.Point(447, 161);
            this.tbSuma.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(199, 22);
            this.tbSuma.TabIndex = 62;
            // 
            // tbVreme
            // 
            this.tbVreme.Enabled = false;
            this.tbVreme.Location = new System.Drawing.Point(446, 106);
            this.tbVreme.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.tbVreme.Name = "tbVreme";
            this.tbVreme.Size = new System.Drawing.Size(201, 22);
            this.tbVreme.TabIndex = 63;
            // 
            // DodajTurnirForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.tbVreme);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbGodina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPrimalac);
            this.Controls.Add(this.tbZnacaj);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblPrimalac);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblZnacaj);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbGrad);
            this.Controls.Add(this.tbZemlja);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.lblDKraj);
            this.Controls.Add(this.lblDPoc);
            this.Controls.Add(this.lblGodina);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.lblZemlja);
            this.Controls.Add(this.lblNaziv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajTurnirForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Turnir";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodajTurnirForma_FormClosing);
            this.Load += new System.EventHandler(this.DodajTurnirForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSuma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVreme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.TextBox tbZemlja;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label lblDKraj;
        private System.Windows.Forms.Label lblDPoc;
        private System.Windows.Forms.Label lblGodina;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblZemlja;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label lblZnacaj;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblPrimalac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox tbZnacaj;
        private System.Windows.Forms.TextBox tbPrimalac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBrziopotezni;
        private System.Windows.Forms.RadioButton rbTakmicarski;
        private System.Windows.Forms.RadioButton rbPromotivni;
        private System.Windows.Forms.RadioButton rbHumanitarni;
        private System.Windows.Forms.NumericUpDown tbGodina;
        private System.Windows.Forms.NumericUpDown tbSuma;
        private System.Windows.Forms.NumericUpDown tbVreme;
    }
}