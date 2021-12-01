namespace Biblioteka
{
    partial class IzdavanjeKnjige
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdBroj = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImeKor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrezimeKor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNaslovK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxKnjige = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi ID broj korisnika";
            // 
            // textBoxIdBroj
            // 
            this.textBoxIdBroj.Location = new System.Drawing.Point(306, 66);
            this.textBoxIdBroj.Name = "textBoxIdBroj";
            this.textBoxIdBroj.Size = new System.Drawing.Size(110, 20);
            this.textBoxIdBroj.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pronadji korisnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ";
            // 
            // textBoxImeKor
            // 
            this.textBoxImeKor.Location = new System.Drawing.Point(326, 162);
            this.textBoxImeKor.Name = "textBoxImeKor";
            this.textBoxImeKor.Size = new System.Drawing.Size(197, 20);
            this.textBoxImeKor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime korisnika";
            // 
            // textBoxPrezimeKor
            // 
            this.textBoxPrezimeKor.Location = new System.Drawing.Point(326, 202);
            this.textBoxPrezimeKor.Name = "textBoxPrezimeKor";
            this.textBoxPrezimeKor.Size = new System.Drawing.Size(197, 20);
            this.textBoxPrezimeKor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prezime korisnika";
            // 
            // textBoxNaslovK
            // 
            this.textBoxNaslovK.Location = new System.Drawing.Point(326, 282);
            this.textBoxNaslovK.Name = "textBoxNaslovK";
            this.textBoxNaslovK.Size = new System.Drawing.Size(197, 20);
            this.textBoxNaslovK.TabIndex = 9;
            this.textBoxNaslovK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxNaslovK_KeyDown);
            this.textBoxNaslovK.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxNaslovK_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Naslov knjige";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datum izdavanja";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Izdaj knjigu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // listBoxKnjige
            // 
            this.listBoxKnjige.FormattingEnabled = true;
            this.listBoxKnjige.Location = new System.Drawing.Point(326, 304);
            this.listBoxKnjige.Name = "listBoxKnjige";
            this.listBoxKnjige.Size = new System.Drawing.Size(197, 95);
            this.listBoxKnjige.TabIndex = 13;
            this.listBoxKnjige.Visible = false;
            this.listBoxKnjige.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxKnjige_MouseClick);
            this.listBoxKnjige.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxKnjige_KeyDown);
            // 
            // IzdavanjeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxKnjige);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNaslovK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrezimeKor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxImeKor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxIdBroj);
            this.Controls.Add(this.label1);
            this.Name = "IzdavanjeKnjige";
            this.Text = "Izdavanje Knjige";
            this.Load += new System.EventHandler(this.IzdavanjeKnjige_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdBroj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImeKor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrezimeKor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNaslovK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxKnjige;
    }
}