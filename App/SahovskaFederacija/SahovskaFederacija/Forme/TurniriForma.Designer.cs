
namespace SahovskaFederacija.Forme
{
    partial class TurniriForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurniriForma));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.Primalac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Suma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Znacaj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumKraj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumPoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Godina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zemlja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.listViewTurniri = new System.Windows.Forms.ListView();
            this.btnOrganizatori = new System.Windows.Forms.Button();
            this.btnPartije = new System.Windows.Forms.Button();
            this.btnSponzori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(605, 385);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(183, 42);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obrisi turnir";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(12, 385);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(183, 42);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj turnir";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Primalac
            // 
            this.Primalac.Text = "Primalac";
            this.Primalac.Width = 137;
            // 
            // Suma
            // 
            this.Suma.Text = "Suma";
            this.Suma.Width = 119;
            // 
            // Znacaj
            // 
            this.Znacaj.Text = "Znacaj";
            this.Znacaj.Width = 74;
            // 
            // Vreme
            // 
            this.Vreme.Text = "Vreme";
            this.Vreme.Width = 76;
            // 
            // Tip
            // 
            this.Tip.Text = "Tip";
            this.Tip.Width = 56;
            // 
            // DatumKraj
            // 
            this.DatumKraj.Text = "Datum zavrsetka";
            this.DatumKraj.Width = 115;
            // 
            // DatumPoc
            // 
            this.DatumPoc.Text = "Datum pocetka";
            this.DatumPoc.Width = 107;
            // 
            // Godina
            // 
            this.Godina.Text = "Godina";
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            // 
            // Zemlja
            // 
            this.Zemlja.Text = "Zemlja";
            this.Zemlja.Width = 73;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeni.Location = new System.Drawing.Point(307, 385);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(183, 42);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni Turnir";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // listViewTurniri
            // 
            this.listViewTurniri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Naziv,
            this.Zemlja,
            this.Grad,
            this.Godina,
            this.DatumPoc,
            this.DatumKraj,
            this.Tip,
            this.Vreme,
            this.Znacaj,
            this.Suma,
            this.Primalac});
            this.listViewTurniri.HideSelection = false;
            this.listViewTurniri.Location = new System.Drawing.Point(12, 12);
            this.listViewTurniri.Name = "listViewTurniri";
            this.listViewTurniri.Size = new System.Drawing.Size(776, 289);
            this.listViewTurniri.TabIndex = 4;
            this.listViewTurniri.UseCompatibleStateImageBehavior = false;
            this.listViewTurniri.View = System.Windows.Forms.View.Details;
            this.listViewTurniri.SelectedIndexChanged += new System.EventHandler(this.listViewSahisti_SelectedIndexChanged);
            // 
            // btnOrganizatori
            // 
            this.btnOrganizatori.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrganizatori.Location = new System.Drawing.Point(118, 325);
            this.btnOrganizatori.Name = "btnOrganizatori";
            this.btnOrganizatori.Size = new System.Drawing.Size(183, 42);
            this.btnOrganizatori.TabIndex = 8;
            this.btnOrganizatori.Text = "Organizatori";
            this.btnOrganizatori.UseVisualStyleBackColor = true;
            this.btnOrganizatori.Click += new System.EventHandler(this.btnOrganizatori_Click);
            // 
            // btnPartije
            // 
            this.btnPartije.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartije.Location = new System.Drawing.Point(307, 325);
            this.btnPartije.Name = "btnPartije";
            this.btnPartije.Size = new System.Drawing.Size(183, 42);
            this.btnPartije.TabIndex = 10;
            this.btnPartije.Text = "Partije";
            this.btnPartije.UseVisualStyleBackColor = true;
            this.btnPartije.Click += new System.EventHandler(this.btnPartije_Click);
            // 
            // btnSponzori
            // 
            this.btnSponzori.Font = new System.Drawing.Font("Felix Titling", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSponzori.Location = new System.Drawing.Point(496, 325);
            this.btnSponzori.Name = "btnSponzori";
            this.btnSponzori.Size = new System.Drawing.Size(183, 42);
            this.btnSponzori.TabIndex = 11;
            this.btnSponzori.Text = "Sponzori";
            this.btnSponzori.UseVisualStyleBackColor = true;
            this.btnSponzori.Click += new System.EventHandler(this.btnSponzori_Click);
            // 
            // TurniriForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SahovskaFederacija.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSponzori);
            this.Controls.Add(this.btnPartije);
            this.Controls.Add(this.btnOrganizatori);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.listViewTurniri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TurniriForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turniri";
            this.Activated += new System.EventHandler(this.TurniriForma_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TurniriForma_FormClosed);
            this.Load += new System.EventHandler(this.TurniriForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ColumnHeader Primalac;
        private System.Windows.Forms.ColumnHeader Suma;
        private System.Windows.Forms.ColumnHeader Znacaj;
        private System.Windows.Forms.ColumnHeader Vreme;
        private System.Windows.Forms.ColumnHeader Tip;
        private System.Windows.Forms.ColumnHeader DatumKraj;
        private System.Windows.Forms.ColumnHeader DatumPoc;
        private System.Windows.Forms.ColumnHeader Godina;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.ColumnHeader Zemlja;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ListView listViewTurniri;
        private System.Windows.Forms.Button btnOrganizatori;
        private System.Windows.Forms.Button btnPartije;
        private System.Windows.Forms.Button btnSponzori;
    }
}