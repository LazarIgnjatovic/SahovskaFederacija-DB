
namespace SahovskaFederacija.Forme
{
    partial class OrganizatoriTurniraForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizatoriTurniraForma));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listViewOrganizatori = new System.Windows.Forms.ListView();
            this.Identifikator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ulica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JMBG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(605, 378);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(183, 60);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obrisi Organizatora";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(307, 378);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(183, 60);
            this.btnIzmeni.TabIndex = 10;
            this.btnIzmeni.Text = "Svi organizatori";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Felix Titling", 10F);
            this.btnDodaj.Location = new System.Drawing.Point(12, 378);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(183, 60);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "Dodaj Postojeceg organizatora";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listViewOrganizatori
            // 
            this.listViewOrganizatori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Identifikator,
            this.Ime,
            this.Prezime,
            this.Grad,
            this.Ulica,
            this.Broj,
            this.JMBG});
            this.listViewOrganizatori.HideSelection = false;
            this.listViewOrganizatori.Location = new System.Drawing.Point(12, 12);
            this.listViewOrganizatori.Name = "listViewOrganizatori";
            this.listViewOrganizatori.Size = new System.Drawing.Size(776, 289);
            this.listViewOrganizatori.TabIndex = 8;
            this.listViewOrganizatori.UseCompatibleStateImageBehavior = false;
            this.listViewOrganizatori.View = System.Windows.Forms.View.Details;
            this.listViewOrganizatori.SelectedIndexChanged += new System.EventHandler(this.listViewOrganizatori_SelectedIndexChanged);
            // 
            // Identifikator
            // 
            this.Identifikator.Text = "Id";
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 88;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.Width = 89;
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            this.Grad.Width = 68;
            // 
            // Ulica
            // 
            this.Ulica.Text = "Ulica";
            this.Ulica.Width = 81;
            // 
            // Broj
            // 
            this.Broj.Text = "Broj";
            // 
            // JMBG
            // 
            this.JMBG.Text = "JMBG";
            this.JMBG.Width = 112;
            // 
            // OrganizatoriTurniraForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.listViewOrganizatori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganizatoriTurniraForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizatori Turnira";
            this.Activated += new System.EventHandler(this.OrganizatoriTurniraForma_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrganizatoriTurniraForma_FormClosing);
            this.Load += new System.EventHandler(this.OrganizatoriTurniraForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListView listViewOrganizatori;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Ulica;
        private System.Windows.Forms.ColumnHeader Broj;
        private System.Windows.Forms.ColumnHeader JMBG;
        private System.Windows.Forms.ColumnHeader Identifikator;
    }
}