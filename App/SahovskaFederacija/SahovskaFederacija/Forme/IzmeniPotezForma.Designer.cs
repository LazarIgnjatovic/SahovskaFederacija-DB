
namespace SahovskaFederacija.Forme
{
    partial class IzmeniPotezForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniPotezForma));
            this.dtpVreme = new System.Windows.Forms.DateTimePicker();
            this.tbPotez = new System.Windows.Forms.TextBox();
            this.numBroj = new System.Windows.Forms.NumericUpDown();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.lblVreme = new System.Windows.Forms.Label();
            this.lblPotez = new System.Windows.Forms.Label();
            this.lblBrojPoteza = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpVreme
            // 
            this.dtpVreme.Location = new System.Drawing.Point(249, 101);
            this.dtpVreme.Name = "dtpVreme";
            this.dtpVreme.Size = new System.Drawing.Size(213, 22);
            this.dtpVreme.TabIndex = 24;
            // 
            // tbPotez
            // 
            this.tbPotez.Location = new System.Drawing.Point(249, 73);
            this.tbPotez.Name = "tbPotez";
            this.tbPotez.Size = new System.Drawing.Size(100, 22);
            this.tbPotez.TabIndex = 23;
            // 
            // numBroj
            // 
            this.numBroj.Location = new System.Drawing.Point(249, 46);
            this.numBroj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBroj.Name = "numBroj";
            this.numBroj.Size = new System.Drawing.Size(120, 22);
            this.numBroj.TabIndex = 22;
            this.numBroj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(61, 152);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(183, 42);
            this.btnIzmeni.TabIndex = 21;
            this.btnIzmeni.Text = "IZMENI POTEZ";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVreme.Location = new System.Drawing.Point(58, 105);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(194, 17);
            this.lblVreme.TabIndex = 20;
            this.lblVreme.Text = "Vreme kada je potez odigran:";
            // 
            // lblPotez
            // 
            this.lblPotez.AutoSize = true;
            this.lblPotez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPotez.Location = new System.Drawing.Point(58, 76);
            this.lblPotez.Name = "lblPotez";
            this.lblPotez.Size = new System.Drawing.Size(48, 17);
            this.lblPotez.TabIndex = 19;
            this.lblPotez.Text = "Potez:";
            // 
            // lblBrojPoteza
            // 
            this.lblBrojPoteza.AutoSize = true;
            this.lblBrojPoteza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBrojPoteza.Location = new System.Drawing.Point(58, 48);
            this.lblBrojPoteza.Name = "lblBrojPoteza";
            this.lblBrojPoteza.Size = new System.Drawing.Size(84, 17);
            this.lblBrojPoteza.TabIndex = 18;
            this.lblBrojPoteza.Text = "Broj poteza:";
            // 
            // IzmeniPotezForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 296);
            this.Controls.Add(this.dtpVreme);
            this.Controls.Add(this.tbPotez);
            this.Controls.Add(this.numBroj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.lblPotez);
            this.Controls.Add(this.lblBrojPoteza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IzmeniPotezForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmeni potez";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IzmeniPotezForma_FormClosed);
            this.Load += new System.EventHandler(this.IzmeniPotezForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpVreme;
        private System.Windows.Forms.TextBox tbPotez;
        private System.Windows.Forms.NumericUpDown numBroj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label lblPotez;
        private System.Windows.Forms.Label lblBrojPoteza;
    }
}