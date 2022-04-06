
namespace SahovskaFederacija
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.btnSahisti = new System.Windows.Forms.Button();
            this.btnTurniri = new System.Windows.Forms.Button();
            this.btnOrganizatori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSahisti
            // 
            this.btnSahisti.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSahisti.Location = new System.Drawing.Point(258, 129);
            this.btnSahisti.Name = "btnSahisti";
            this.btnSahisti.Size = new System.Drawing.Size(279, 61);
            this.btnSahisti.TabIndex = 0;
            this.btnSahisti.Text = "SAHISTI";
            this.btnSahisti.UseVisualStyleBackColor = true;
            this.btnSahisti.Click += new System.EventHandler(this.btnSahisti_Click);
            // 
            // btnTurniri
            // 
            this.btnTurniri.Font = new System.Drawing.Font("Felix Titling", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurniri.Location = new System.Drawing.Point(258, 218);
            this.btnTurniri.Name = "btnTurniri";
            this.btnTurniri.Size = new System.Drawing.Size(279, 61);
            this.btnTurniri.TabIndex = 1;
            this.btnTurniri.Text = "TURNIRI";
            this.btnTurniri.UseVisualStyleBackColor = true;
            this.btnTurniri.Click += new System.EventHandler(this.btnTurniri_Click);
            // 
            // btnOrganizatori
            // 
            this.btnOrganizatori.Font = new System.Drawing.Font("Felix Titling", 16F);
            this.btnOrganizatori.Location = new System.Drawing.Point(258, 308);
            this.btnOrganizatori.Name = "btnOrganizatori";
            this.btnOrganizatori.Size = new System.Drawing.Size(279, 61);
            this.btnOrganizatori.TabIndex = 2;
            this.btnOrganizatori.Text = "ORGANIZATORI";
            this.btnOrganizatori.UseVisualStyleBackColor = true;
            this.btnOrganizatori.Click += new System.EventHandler(this.btnOrganizatori_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnOrganizatori);
            this.Controls.Add(this.btnTurniri);
            this.Controls.Add(this.btnSahisti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Pocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sahovska Federacija";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSahisti;
        private System.Windows.Forms.Button btnTurniri;
        private System.Windows.Forms.Button btnOrganizatori;
    }
}

