
namespace SahovskaFederacija.Forme
{
    partial class SponzoriForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SponzoriForma));
            this.listViewSponzori = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajSponzora = new System.Windows.Forms.Button();
            this.btnIzmeniSponzora = new System.Windows.Forms.Button();
            this.btnObrisiSponzora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSponzori
            // 
            this.listViewSponzori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Naziv});
            this.listViewSponzori.HideSelection = false;
            this.listViewSponzori.Location = new System.Drawing.Point(12, 12);
            this.listViewSponzori.Name = "listViewSponzori";
            this.listViewSponzori.Size = new System.Drawing.Size(277, 138);
            this.listViewSponzori.TabIndex = 0;
            this.listViewSponzori.UseCompatibleStateImageBehavior = false;
            this.listViewSponzori.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 145;
            // 
            // btnDodajSponzora
            // 
            this.btnDodajSponzora.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSponzora.Location = new System.Drawing.Point(295, 12);
            this.btnDodajSponzora.Name = "btnDodajSponzora";
            this.btnDodajSponzora.Size = new System.Drawing.Size(212, 42);
            this.btnDodajSponzora.TabIndex = 12;
            this.btnDodajSponzora.Text = "DODAJ SPONZORA";
            this.btnDodajSponzora.UseVisualStyleBackColor = true;
            this.btnDodajSponzora.Click += new System.EventHandler(this.btnDodajSponzora_Click);
            // 
            // btnIzmeniSponzora
            // 
            this.btnIzmeniSponzora.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniSponzora.Location = new System.Drawing.Point(295, 60);
            this.btnIzmeniSponzora.Name = "btnIzmeniSponzora";
            this.btnIzmeniSponzora.Size = new System.Drawing.Size(212, 42);
            this.btnIzmeniSponzora.TabIndex = 13;
            this.btnIzmeniSponzora.Text = "IZMENI SPONZORA";
            this.btnIzmeniSponzora.UseVisualStyleBackColor = true;
            this.btnIzmeniSponzora.Click += new System.EventHandler(this.btnIzmeniSponzora_Click);
            // 
            // btnObrisiSponzora
            // 
            this.btnObrisiSponzora.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSponzora.Location = new System.Drawing.Point(295, 108);
            this.btnObrisiSponzora.Name = "btnObrisiSponzora";
            this.btnObrisiSponzora.Size = new System.Drawing.Size(212, 42);
            this.btnObrisiSponzora.TabIndex = 14;
            this.btnObrisiSponzora.Text = "OBRISI SPONZORA";
            this.btnObrisiSponzora.UseVisualStyleBackColor = true;
            this.btnObrisiSponzora.Click += new System.EventHandler(this.btnObrisiSponzora_Click);
            // 
            // SponzoriForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 373);
            this.Controls.Add(this.btnObrisiSponzora);
            this.Controls.Add(this.btnIzmeniSponzora);
            this.Controls.Add(this.btnDodajSponzora);
            this.Controls.Add(this.listViewSponzori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(538, 411);
            this.Name = "SponzoriForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sponzori turnira";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SponzoriForma_FormClosed);
            this.Load += new System.EventHandler(this.SponzoriForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSponzori;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.Button btnDodajSponzora;
        private System.Windows.Forms.Button btnIzmeniSponzora;
        private System.Windows.Forms.Button btnObrisiSponzora;
    }
}