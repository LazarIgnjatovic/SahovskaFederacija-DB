
namespace SahovskaFederacija.Forme
{
    partial class DodajPartijuTurnira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPartijuTurnira));
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.dtVreme = new System.Windows.Forms.DateTimePicker();
            this.numTrajanje = new System.Windows.Forms.NumericUpDown();
            this.tbIshod = new System.Windows.Forms.TextBox();
            this.cbBeli = new System.Windows.Forms.ComboBox();
            this.cbCrni = new System.Windows.Forms.ComboBox();
            this.cbSudija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanje)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDatum
            // 
            this.dtDatum.Location = new System.Drawing.Point(314, 72);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.Size = new System.Drawing.Size(200, 22);
            this.dtDatum.TabIndex = 0;
            // 
            // dtVreme
            // 
            this.dtVreme.CustomFormat = "\"hh:mm tt\"";
            this.dtVreme.Location = new System.Drawing.Point(314, 100);
            this.dtVreme.Name = "dtVreme";
            this.dtVreme.Size = new System.Drawing.Size(200, 22);
            this.dtVreme.TabIndex = 1;
            // 
            // numTrajanje
            // 
            this.numTrajanje.Location = new System.Drawing.Point(314, 128);
            this.numTrajanje.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numTrajanje.Name = "numTrajanje";
            this.numTrajanje.Size = new System.Drawing.Size(200, 22);
            this.numTrajanje.TabIndex = 2;
            // 
            // tbIshod
            // 
            this.tbIshod.Location = new System.Drawing.Point(314, 156);
            this.tbIshod.MaxLength = 50;
            this.tbIshod.Name = "tbIshod";
            this.tbIshod.Size = new System.Drawing.Size(200, 22);
            this.tbIshod.TabIndex = 3;
            // 
            // cbBeli
            // 
            this.cbBeli.FormattingEnabled = true;
            this.cbBeli.Location = new System.Drawing.Point(314, 184);
            this.cbBeli.Name = "cbBeli";
            this.cbBeli.Size = new System.Drawing.Size(200, 24);
            this.cbBeli.TabIndex = 4;
            // 
            // cbCrni
            // 
            this.cbCrni.FormattingEnabled = true;
            this.cbCrni.Location = new System.Drawing.Point(314, 214);
            this.cbCrni.Name = "cbCrni";
            this.cbCrni.Size = new System.Drawing.Size(200, 24);
            this.cbCrni.TabIndex = 5;
            // 
            // cbSudija
            // 
            this.cbSudija.FormattingEnabled = true;
            this.cbSudija.Location = new System.Drawing.Point(314, 244);
            this.cbSudija.Name = "cbSudija";
            this.cbSudija.Size = new System.Drawing.Size(200, 24);
            this.cbSudija.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(248, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(248, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vreme:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(248, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trajanje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(248, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ishod";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(248, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Beli:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(248, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Crni";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(248, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sudija";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Felix Titling", 18F);
            this.btnDodaj.Location = new System.Drawing.Point(305, 309);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(183, 60);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajPartijuTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSudija);
            this.Controls.Add(this.cbCrni);
            this.Controls.Add(this.cbBeli);
            this.Controls.Add(this.tbIshod);
            this.Controls.Add(this.numTrajanje);
            this.Controls.Add(this.dtVreme);
            this.Controls.Add(this.dtDatum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajPartijuTurnira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj partiju";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodajPartijuTurnira_FormClosing);
            this.Load += new System.EventHandler(this.DodajPartijuTurnira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDatum;
        private System.Windows.Forms.DateTimePicker dtVreme;
        private System.Windows.Forms.NumericUpDown numTrajanje;
        private System.Windows.Forms.TextBox tbIshod;
        private System.Windows.Forms.ComboBox cbBeli;
        private System.Windows.Forms.ComboBox cbCrni;
        private System.Windows.Forms.ComboBox cbSudija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDodaj;
    }
}