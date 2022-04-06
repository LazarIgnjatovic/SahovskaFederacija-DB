
namespace SahovskaFederacija.Forme
{
    partial class DodajPotezForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajPotezForma));
            this.lblBrojPoteza = new System.Windows.Forms.Label();
            this.lblPotez = new System.Windows.Forms.Label();
            this.lblVreme = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.numBroj = new System.Windows.Forms.NumericUpDown();
            this.tbPotez = new System.Windows.Forms.TextBox();
            this.dtpVreme = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrojPoteza
            // 
            this.lblBrojPoteza.AutoSize = true;
            this.lblBrojPoteza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrojPoteza.Location = new System.Drawing.Point(46, 61);
            this.lblBrojPoteza.Name = "lblBrojPoteza";
            this.lblBrojPoteza.Size = new System.Drawing.Size(84, 17);
            this.lblBrojPoteza.TabIndex = 0;
            this.lblBrojPoteza.Text = "Broj poteza:";
            // 
            // lblPotez
            // 
            this.lblPotez.AutoSize = true;
            this.lblPotez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPotez.Location = new System.Drawing.Point(46, 89);
            this.lblPotez.Name = "lblPotez";
            this.lblPotez.Size = new System.Drawing.Size(48, 17);
            this.lblPotez.TabIndex = 1;
            this.lblPotez.Text = "Potez:";
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVreme.Location = new System.Drawing.Point(46, 118);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(194, 17);
            this.lblVreme.TabIndex = 2;
            this.lblVreme.Text = "Vreme kada je potez odigran:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(49, 165);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(183, 42);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj potez";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // numBroj
            // 
            this.numBroj.Location = new System.Drawing.Point(237, 59);
            this.numBroj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBroj.Name = "numBroj";
            this.numBroj.Size = new System.Drawing.Size(120, 22);
            this.numBroj.TabIndex = 15;
            this.numBroj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbPotez
            // 
            this.tbPotez.Location = new System.Drawing.Point(237, 86);
            this.tbPotez.Name = "tbPotez";
            this.tbPotez.Size = new System.Drawing.Size(100, 22);
            this.tbPotez.TabIndex = 16;
            // 
            // dtpVreme
            // 
            this.dtpVreme.Location = new System.Drawing.Point(237, 114);
            this.dtpVreme.Name = "dtpVreme";
            this.dtpVreme.Size = new System.Drawing.Size(213, 22);
            this.dtpVreme.TabIndex = 17;
            // 
            // DodajPotezForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 288);
            this.Controls.Add(this.dtpVreme);
            this.Controls.Add(this.tbPotez);
            this.Controls.Add(this.numBroj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.lblPotez);
            this.Controls.Add(this.lblBrojPoteza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajPotezForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj potez";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DodajPotezForma_FormClosed);
            this.Load += new System.EventHandler(this.DodajPotezForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojPoteza;
        private System.Windows.Forms.Label lblPotez;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.NumericUpDown numBroj;
        private System.Windows.Forms.TextBox tbPotez;
        private System.Windows.Forms.DateTimePicker dtpVreme;
    }
}