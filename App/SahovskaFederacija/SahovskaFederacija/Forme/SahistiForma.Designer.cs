
namespace SahovskaFederacija.Forme
{
    partial class SahistiForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SahistiForma));
            this.listViewSahisti = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZemljaPorekla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumRodjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrojPasosa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumUclanjenja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrNeodostalihPartija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zvanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumSticanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSahisti
            // 
            this.listViewSahisti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Ime,
            this.Prezime,
            this.Grad,
            this.Ulica,
            this.Broj,
            this.RegBroj,
            this.ZemljaPorekla,
            this.DatumRodjenja,
            this.BrojPasosa,
            this.DatumUclanjenja,
            this.BrNeodostalihPartija,
            this.Zvanje,
            this.DatumSticanja});
            this.listViewSahisti.HideSelection = false;
            this.listViewSahisti.Location = new System.Drawing.Point(12, 12);
            this.listViewSahisti.Name = "listViewSahisti";
            this.listViewSahisti.Size = new System.Drawing.Size(776, 289);
            this.listViewSahisti.TabIndex = 0;
            this.listViewSahisti.UseCompatibleStateImageBehavior = false;
            this.listViewSahisti.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 73;
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            // 
            // Broj
            // 
            this.Broj.Text = "Broj";
            // 
            // RegBroj
            // 
            this.RegBroj.Text = "RegBroj";
            this.RegBroj.Width = 71;
            // 
            // ZemljaPorekla
            // 
            this.ZemljaPorekla.Text = "ZemljaPorekla";
            this.ZemljaPorekla.Width = 116;
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.Text = "DatumRodjenja";
            this.DatumRodjenja.Width = 113;
            // 
            // BrojPasosa
            // 
            this.BrojPasosa.Text = "BrojPasosa";
            this.BrojPasosa.Width = 90;
            // 
            // DatumUclanjenja
            // 
            this.DatumUclanjenja.Text = "DatumUclanjenja";
            this.DatumUclanjenja.Width = 119;
            // 
            // BrNeodostalihPartija
            // 
            this.BrNeodostalihPartija.Text = "BrNeodostalihPartija";
            this.BrNeodostalihPartija.Width = 137;
            // 
            // Zvanje
            // 
            this.Zvanje.Text = "Zvanje";
            // 
            // DatumSticanja
            // 
            this.DatumSticanja.Text = "DatumSticanja";
            this.DatumSticanja.Width = 109;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 373);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(183, 42);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj sahistu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(307, 373);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(183, 42);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni sahistu";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(605, 373);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(183, 42);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi sahistu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // SahistiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listViewSahisti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "SahistiForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sahisti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SahistiForma_FormClosed);
            this.Load += new System.EventHandler(this.SahistiForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSahisti;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Broj;
        private System.Windows.Forms.ColumnHeader RegBroj;
        private System.Windows.Forms.ColumnHeader ZemljaPorekla;
        private System.Windows.Forms.ColumnHeader DatumRodjenja;
        private System.Windows.Forms.ColumnHeader BrojPasosa;
        private System.Windows.Forms.ColumnHeader DatumUclanjenja;
        private System.Windows.Forms.ColumnHeader BrNeodostalihPartija;
        private System.Windows.Forms.ColumnHeader DatumSticanja;
        private System.Windows.Forms.ColumnHeader Zvanje;
    }
}