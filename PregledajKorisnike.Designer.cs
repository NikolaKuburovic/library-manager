namespace Biblioteka
{
    partial class PregledajKorisnike
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
            this.dataGridViewKorisnici = new System.Windows.Forms.DataGridView();
            this.textBoxTrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEmailK = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeK = new System.Windows.Forms.TextBox();
            this.textBoxImeK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKorisnici
            // 
            this.dataGridViewKorisnici.AllowUserToAddRows = false;
            this.dataGridViewKorisnici.AllowUserToDeleteRows = false;
            this.dataGridViewKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnici.Location = new System.Drawing.Point(15, 71);
            this.dataGridViewKorisnici.Name = "dataGridViewKorisnici";
            this.dataGridViewKorisnici.ReadOnly = true;
            this.dataGridViewKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKorisnici.Size = new System.Drawing.Size(601, 367);
            this.dataGridViewKorisnici.TabIndex = 1;
            this.dataGridViewKorisnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewKorisnici_CellClick);
            // 
            // textBoxTrazi
            // 
            this.textBoxTrazi.Location = new System.Drawing.Point(15, 45);
            this.textBoxTrazi.Name = "textBoxTrazi";
            this.textBoxTrazi.Size = new System.Drawing.Size(220, 20);
            this.textBoxTrazi.TabIndex = 5;
            this.textBoxTrazi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxTrazi_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pretraga po imenu i prezimenu korisnika";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxEmailK);
            this.panel1.Controls.Add(this.textBoxPrezimeK);
            this.panel1.Controls.Add(this.textBoxImeK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(642, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 194);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxEmailK
            // 
            this.textBoxEmailK.Location = new System.Drawing.Point(113, 90);
            this.textBoxEmailK.Name = "textBoxEmailK";
            this.textBoxEmailK.Size = new System.Drawing.Size(183, 20);
            this.textBoxEmailK.TabIndex = 10;
            // 
            // textBoxPrezimeK
            // 
            this.textBoxPrezimeK.Location = new System.Drawing.Point(113, 49);
            this.textBoxPrezimeK.Name = "textBoxPrezimeK";
            this.textBoxPrezimeK.Size = new System.Drawing.Size(183, 20);
            this.textBoxPrezimeK.TabIndex = 9;
            // 
            // textBoxImeK
            // 
            this.textBoxImeK.Location = new System.Drawing.Point(113, 8);
            this.textBoxImeK.Name = "textBoxImeK";
            this.textBoxImeK.Size = new System.Drawing.Size(183, 20);
            this.textBoxImeK.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prezime korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ime korisnika";
            // 
            // PregledajKorisnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKorisnici);
            this.Name = "PregledajKorisnike";
            this.Text = "Pregledaj Korisnike";
            this.Load += new System.EventHandler(this.PregledajKorisnike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKorisnici;
        private System.Windows.Forms.TextBox textBoxTrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEmailK;
        private System.Windows.Forms.TextBox textBoxPrezimeK;
        private System.Windows.Forms.TextBox textBoxImeK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}