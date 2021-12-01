namespace Biblioteka
{
    partial class BibliotekaMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKnjiguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.korisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajKorisnikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izdavanjeKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vracanjeKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stanjeKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.korisnikToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKnjiguToolStripMenuItem,
            this.pregledajKnjigeToolStripMenuItem,
            this.izdavanjeKnjigaToolStripMenuItem,
            this.vracanjeKnjigeToolStripMenuItem,
            this.stanjeKnjigaToolStripMenuItem});
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            // 
            // dodajKnjiguToolStripMenuItem
            // 
            this.dodajKnjiguToolStripMenuItem.Name = "dodajKnjiguToolStripMenuItem";
            this.dodajKnjiguToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajKnjiguToolStripMenuItem.Text = "Dodaj knjigu";
            this.dodajKnjiguToolStripMenuItem.Click += new System.EventHandler(this.DodajKnjiguToolStripMenuItem_Click);
            // 
            // pregledajKnjigeToolStripMenuItem
            // 
            this.pregledajKnjigeToolStripMenuItem.Name = "pregledajKnjigeToolStripMenuItem";
            this.pregledajKnjigeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledajKnjigeToolStripMenuItem.Text = "Pregledaj knjige";
            this.pregledajKnjigeToolStripMenuItem.Click += new System.EventHandler(this.PregledajKnjigeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // korisnikToolStripMenuItem
            // 
            this.korisnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem,
            this.pregledajKorisnikeToolStripMenuItem});
            this.korisnikToolStripMenuItem.Name = "korisnikToolStripMenuItem";
            this.korisnikToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.korisnikToolStripMenuItem.Text = "Korisnik";
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.DodajKorisnikaToolStripMenuItem_Click);
            // 
            // pregledajKorisnikeToolStripMenuItem
            // 
            this.pregledajKorisnikeToolStripMenuItem.Name = "pregledajKorisnikeToolStripMenuItem";
            this.pregledajKorisnikeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pregledajKorisnikeToolStripMenuItem.Text = "Pregledaj korisnike";
            this.pregledajKorisnikeToolStripMenuItem.Click += new System.EventHandler(this.PregledajKorisnikeToolStripMenuItem_Click);
            // 
            // izdavanjeKnjigaToolStripMenuItem
            // 
            this.izdavanjeKnjigaToolStripMenuItem.Name = "izdavanjeKnjigaToolStripMenuItem";
            this.izdavanjeKnjigaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izdavanjeKnjigaToolStripMenuItem.Text = "Izdavanje knjiga";
            this.izdavanjeKnjigaToolStripMenuItem.Click += new System.EventHandler(this.IzdavanjeKnjigaToolStripMenuItem_Click);
            // 
            // vracanjeKnjigeToolStripMenuItem
            // 
            this.vracanjeKnjigeToolStripMenuItem.Name = "vracanjeKnjigeToolStripMenuItem";
            this.vracanjeKnjigeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vracanjeKnjigeToolStripMenuItem.Text = "Vracanje knjige";
            this.vracanjeKnjigeToolStripMenuItem.Click += new System.EventHandler(this.VracanjeKnjigeToolStripMenuItem_Click);
            // 
            // stanjeKnjigaToolStripMenuItem
            // 
            this.stanjeKnjigaToolStripMenuItem.Name = "stanjeKnjigaToolStripMenuItem";
            this.stanjeKnjigaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stanjeKnjigaToolStripMenuItem.Text = "Stanje knjiga";
            this.stanjeKnjigaToolStripMenuItem.Click += new System.EventHandler(this.StanjeKnjigaToolStripMenuItem_Click);
            // 
            // BibliotekaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "BibliotekaMain";
            this.Text = "Biblioteka";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKnjiguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajKorisnikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izdavanjeKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vracanjeKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stanjeKnjigaToolStripMenuItem;
    }
}



