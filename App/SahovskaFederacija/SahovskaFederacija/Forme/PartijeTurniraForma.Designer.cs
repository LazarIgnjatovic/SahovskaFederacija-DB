
namespace SahovskaFederacija.Forme
{
    partial class PartijeTurniraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartijeTurniraForm));
            this.listViewPartije = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trajanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ishod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Beli = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Crni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPotezi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPartije
            // 
            this.listViewPartije.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Datum,
            this.Vreme,
            this.Trajanje,
            this.Ishod,
            this.Beli,
            this.Crni});
            this.listViewPartije.HideSelection = false;
            this.listViewPartije.Location = new System.Drawing.Point(12, 12);
            this.listViewPartije.Name = "listViewPartije";
            this.listViewPartije.Size = new System.Drawing.Size(776, 278);
            this.listViewPartije.TabIndex = 0;
            this.listViewPartije.UseCompatibleStateImageBehavior = false;
            this.listViewPartije.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            // 
            // Vreme
            // 
            this.Vreme.Text = "Vreme";
            // 
            // Trajanje
            // 
            this.Trajanje.Text = "Trajanje";
            this.Trajanje.Width = 74;
            // 
            // Ishod
            // 
            this.Ishod.Text = "Ishod";
            // 
            // Beli
            // 
            this.Beli.Text = "Beli Sahista";
            this.Beli.Width = 101;
            // 
            // Crni
            // 
            this.Crni.Text = "Crni Sahista";
            this.Crni.Width = 94;
            // 
            // btnPotezi
            // 
            this.btnPotezi.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotezi.Location = new System.Drawing.Point(305, 325);
            this.btnPotezi.Name = "btnPotezi";
            this.btnPotezi.Size = new System.Drawing.Size(183, 42);
            this.btnPotezi.TabIndex = 16;
            this.btnPotezi.Text = "Potezi";
            this.btnPotezi.UseVisualStyleBackColor = true;
            this.btnPotezi.Click += new System.EventHandler(this.btnPotezi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(603, 396);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(183, 42);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Obrisi partiju";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(10, 396);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(183, 42);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj partiju";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(305, 396);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(183, 42);
            this.btnIzmeni.TabIndex = 13;
            this.btnIzmeni.Text = "Izmeni partiju";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // PartijeTurniraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPotezi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.listViewPartije);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartijeTurniraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partije";
            this.Activated += new System.EventHandler(this.PartijeTurniraForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PartijeTurniraForm_FormClosing);
            this.Load += new System.EventHandler(this.PartijeTurniraForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPartije;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Vreme;
        private System.Windows.Forms.ColumnHeader Trajanje;
        private System.Windows.Forms.ColumnHeader Ishod;
        private System.Windows.Forms.ColumnHeader Beli;
        private System.Windows.Forms.ColumnHeader Crni;
        private System.Windows.Forms.Button btnPotezi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmeni;
    }
}