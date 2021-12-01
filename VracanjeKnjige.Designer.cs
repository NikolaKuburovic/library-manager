namespace Biblioteka
{
    partial class VracanjeKnjige
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
            this.buttonVrati = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIzdavanje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNaslovV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTrazi = new System.Windows.Forms.Button();
            this.textBoxIdBrojV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVrati
            // 
            this.buttonVrati.Location = new System.Drawing.Point(340, 104);
            this.buttonVrati.Name = "buttonVrati";
            this.buttonVrati.Size = new System.Drawing.Size(110, 23);
            this.buttonVrati.TabIndex = 23;
            this.buttonVrati.Text = "Vrati knjigu";
            this.buttonVrati.UseVisualStyleBackColor = true;
            this.buttonVrati.Click += new System.EventHandler(this.ButtonVrati_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Datum vracanja";
            // 
            // textBoxIzdavanje
            // 
            this.textBoxIzdavanje.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxIzdavanje.Location = new System.Drawing.Point(122, 67);
            this.textBoxIzdavanje.Name = "textBoxIzdavanje";
            this.textBoxIzdavanje.Size = new System.Drawing.Size(197, 20);
            this.textBoxIzdavanje.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Datum izdavanja";
            // 
            // textBoxNaslovV
            // 
            this.textBoxNaslovV.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxNaslovV.Location = new System.Drawing.Point(122, 27);
            this.textBoxNaslovV.Name = "textBoxNaslovV";
            this.textBoxNaslovV.Size = new System.Drawing.Size(197, 20);
            this.textBoxNaslovV.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Naslov knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // buttonTrazi
            // 
            this.buttonTrazi.Location = new System.Drawing.Point(54, 105);
            this.buttonTrazi.Name = "buttonTrazi";
            this.buttonTrazi.Size = new System.Drawing.Size(110, 23);
            this.buttonTrazi.TabIndex = 15;
            this.buttonTrazi.Text = "Pronadji korisnika";
            this.buttonTrazi.UseVisualStyleBackColor = true;
            this.buttonTrazi.Click += new System.EventHandler(this.ButtonTrazi_Click);
            // 
            // textBoxIdBrojV
            // 
            this.textBoxIdBrojV.Location = new System.Drawing.Point(54, 79);
            this.textBoxIdBrojV.Name = "textBoxIdBrojV";
            this.textBoxIdBrojV.Size = new System.Drawing.Size(110, 20);
            this.textBoxIdBrojV.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Unesi ID broj korisnika";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.buttonVrati);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNaslovV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIzdavanje);
            this.panel1.Location = new System.Drawing.Point(293, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 147);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(714, 216);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(32, 197);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 241);
            this.panel2.TabIndex = 26;
            this.panel2.Visible = false;
            // 
            // VracanjeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonTrazi);
            this.Controls.Add(this.textBoxIdBrojV);
            this.Controls.Add(this.label1);
            this.Name = "VracanjeKnjige";
            this.Text = "Vracanje Knjige";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVrati;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIzdavanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNaslovV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTrazi;
        private System.Windows.Forms.TextBox textBoxIdBrojV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
    }
}