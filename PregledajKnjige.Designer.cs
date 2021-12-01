namespace Biblioteka
{
    partial class PregledajKnjige
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
            this.dataGridViewKnjige = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTrazi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNaslov = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIzdavac = new System.Windows.Forms.TextBox();
            this.textBoxGodina = new System.Windows.Forms.TextBox();
            this.textBoxStrana = new System.Windows.Forms.TextBox();
            this.textBoxPrimerci = new System.Windows.Forms.TextBox();
            this.textBoxDostupno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKnjige)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKnjige
            // 
            this.dataGridViewKnjige.AllowUserToAddRows = false;
            this.dataGridViewKnjige.AllowUserToDeleteRows = false;
            this.dataGridViewKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKnjige.Location = new System.Drawing.Point(12, 70);
            this.dataGridViewKnjige.Name = "dataGridViewKnjige";
            this.dataGridViewKnjige.ReadOnly = true;
            this.dataGridViewKnjige.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKnjige.Size = new System.Drawing.Size(973, 194);
            this.dataGridViewKnjige.TabIndex = 0;
            this.dataGridViewKnjige.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewKnjige_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretraga po naslovu knjige ili po piscu";
            // 
            // textBoxTrazi
            // 
            this.textBoxTrazi.Location = new System.Drawing.Point(15, 42);
            this.textBoxTrazi.Name = "textBoxTrazi";
            this.textBoxTrazi.Size = new System.Drawing.Size(220, 20);
            this.textBoxTrazi.TabIndex = 3;
            this.textBoxTrazi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxTrazi_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxDostupno);
            this.panel1.Controls.Add(this.textBoxPrimerci);
            this.panel1.Controls.Add(this.textBoxStrana);
            this.panel1.Controls.Add(this.textBoxGodina);
            this.panel1.Controls.Add(this.textBoxIzdavac);
            this.panel1.Controls.Add(this.textBoxPrezime);
            this.panel1.Controls.Add(this.textBoxIme);
            this.panel1.Controls.Add(this.textBoxNaslov);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 158);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naslov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ime pisca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prezime pisca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Izdavac";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Godina izdavanja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 52);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Broj strana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Broj primeraka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Dostupno primeraka";
            // 
            // textBoxNaslov
            // 
            this.textBoxNaslov.Location = new System.Drawing.Point(101, 8);
            this.textBoxNaslov.Name = "textBoxNaslov";
            this.textBoxNaslov.Size = new System.Drawing.Size(195, 20);
            this.textBoxNaslov.TabIndex = 8;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(101, 49);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(195, 20);
            this.textBoxIme.TabIndex = 9;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(101, 90);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(195, 20);
            this.textBoxPrezime.TabIndex = 10;
            // 
            // textBoxIzdavac
            // 
            this.textBoxIzdavac.Location = new System.Drawing.Point(101, 132);
            this.textBoxIzdavac.Name = "textBoxIzdavac";
            this.textBoxIzdavac.Size = new System.Drawing.Size(195, 20);
            this.textBoxIzdavac.TabIndex = 11;
            // 
            // textBoxGodina
            // 
            this.textBoxGodina.Location = new System.Drawing.Point(452, 8);
            this.textBoxGodina.Name = "textBoxGodina";
            this.textBoxGodina.Size = new System.Drawing.Size(84, 20);
            this.textBoxGodina.TabIndex = 12;
            // 
            // textBoxStrana
            // 
            this.textBoxStrana.Location = new System.Drawing.Point(452, 49);
            this.textBoxStrana.Name = "textBoxStrana";
            this.textBoxStrana.Size = new System.Drawing.Size(84, 20);
            this.textBoxStrana.TabIndex = 13;
            // 
            // textBoxPrimerci
            // 
            this.textBoxPrimerci.Location = new System.Drawing.Point(452, 90);
            this.textBoxPrimerci.Name = "textBoxPrimerci";
            this.textBoxPrimerci.Size = new System.Drawing.Size(84, 20);
            this.textBoxPrimerci.TabIndex = 14;
            // 
            // textBoxDostupno
            // 
            this.textBoxDostupno.Location = new System.Drawing.Point(452, 131);
            this.textBoxDostupno.Name = "textBoxDostupno";
            this.textBoxDostupno.Size = new System.Drawing.Size(84, 20);
            this.textBoxDostupno.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PregledajKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKnjige);
            this.Name = "PregledajKnjige";
            this.Text = "Pregledaj Knjige";
            this.Load += new System.EventHandler(this.PregledajKnjige_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKnjige)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKnjige;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTrazi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDostupno;
        private System.Windows.Forms.TextBox textBoxPrimerci;
        private System.Windows.Forms.TextBox textBoxStrana;
        private System.Windows.Forms.TextBox textBoxGodina;
        private System.Windows.Forms.TextBox textBoxIzdavac;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxNaslov;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}