namespace Projekt
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Naz = new System.Windows.Forms.TextBox();
            this.Pesel = new System.Windows.Forms.TextBox();
            this.Stanow = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Czy_Student = new System.Windows.Forms.Label();
            this.RodzajZatrudnienia = new System.Windows.Forms.Label();
            this.Pensja = new System.Windows.Forms.Label();
            this.pensja_netto = new System.Windows.Forms.TextBox();
            this.StudentTak = new System.Windows.Forms.RadioButton();
            this.StudentNie = new System.Windows.Forms.RadioButton();
            this.RodzajZat = new System.Windows.Forms.ComboBox();
            this.PlecM = new System.Windows.Forms.RadioButton();
            this.PlecK = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Płeć";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stanowisko";
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(276, 23);
            this.Imie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(132, 22);
            this.Imie.TabIndex = 5;
            // 
            // Naz
            // 
            this.Naz.Location = new System.Drawing.Point(276, 69);
            this.Naz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Naz.Name = "Naz";
            this.Naz.Size = new System.Drawing.Size(132, 22);
            this.Naz.TabIndex = 6;
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(276, 105);
            this.Pesel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(132, 22);
            this.Pesel.TabIndex = 7;
            // 
            // Stanow
            // 
            this.Stanow.Location = new System.Drawing.Point(276, 183);
            this.Stanow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stanow.Name = "Stanow";
            this.Stanow.Size = new System.Drawing.Size(132, 22);
            this.Stanow.TabIndex = 9;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(165, 338);
            this.Enter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(296, 28);
            this.Enter.TabIndex = 10;
            this.Enter.Text = "Dodaj osobę";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click_1);
            // 
            // Czy_Student
            // 
            this.Czy_Student.AutoSize = true;
            this.Czy_Student.Location = new System.Drawing.Point(132, 225);
            this.Czy_Student.Name = "Czy_Student";
            this.Czy_Student.Size = new System.Drawing.Size(92, 17);
            this.Czy_Student.TabIndex = 12;
            this.Czy_Student.Text = "Czy Student?";
            // 
            // RodzajZatrudnienia
            // 
            this.RodzajZatrudnienia.AutoSize = true;
            this.RodzajZatrudnienia.Location = new System.Drawing.Point(131, 262);
            this.RodzajZatrudnienia.Name = "RodzajZatrudnienia";
            this.RodzajZatrudnienia.Size = new System.Drawing.Size(136, 17);
            this.RodzajZatrudnienia.TabIndex = 16;
            this.RodzajZatrudnienia.Text = "Rodzaj Zatrudnienia";
            // 
            // Pensja
            // 
            this.Pensja.AutoSize = true;
            this.Pensja.Location = new System.Drawing.Point(133, 295);
            this.Pensja.Name = "Pensja";
            this.Pensja.Size = new System.Drawing.Size(93, 17);
            this.Pensja.TabIndex = 17;
            this.Pensja.Text = "Pensja Brutto";
            // 
            // pensja_netto
            // 
            this.pensja_netto.Location = new System.Drawing.Point(276, 290);
            this.pensja_netto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pensja_netto.Name = "pensja_netto";
            this.pensja_netto.Size = new System.Drawing.Size(132, 22);
            this.pensja_netto.TabIndex = 18;
            this.pensja_netto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pensja_netto_KeyPress);
            // 
            // StudentTak
            // 
            this.StudentTak.AutoSize = true;
            this.StudentTak.Location = new System.Drawing.Point(0, 7);
            this.StudentTak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentTak.Name = "StudentTak";
            this.StudentTak.Size = new System.Drawing.Size(53, 21);
            this.StudentTak.TabIndex = 19;
            this.StudentTak.TabStop = true;
            this.StudentTak.Text = "Tak";
            this.StudentTak.UseVisualStyleBackColor = true;
            // 
            // StudentNie
            // 
            this.StudentNie.AutoSize = true;
            this.StudentNie.Location = new System.Drawing.Point(55, 7);
            this.StudentNie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentNie.Name = "StudentNie";
            this.StudentNie.Size = new System.Drawing.Size(50, 21);
            this.StudentNie.TabIndex = 20;
            this.StudentNie.TabStop = true;
            this.StudentNie.Text = "Nie";
            this.StudentNie.UseVisualStyleBackColor = true;
            // 
            // RodzajZat
            // 
            this.RodzajZat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RodzajZat.FormattingEnabled = true;
            this.RodzajZat.Items.AddRange(new object[] {
            "Umowa o pracę",
            "Umowa o dzieło",
            "Umowa zlecenie"});
            this.RodzajZat.Location = new System.Drawing.Point(276, 255);
            this.RodzajZat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RodzajZat.Name = "RodzajZat";
            this.RodzajZat.Size = new System.Drawing.Size(132, 24);
            this.RodzajZat.TabIndex = 21;
            // 
            // PlecM
            // 
            this.PlecM.AutoSize = true;
            this.PlecM.Location = new System.Drawing.Point(0, 0);
            this.PlecM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlecM.Name = "PlecM";
            this.PlecM.Size = new System.Drawing.Size(103, 21);
            this.PlecM.TabIndex = 22;
            this.PlecM.TabStop = true;
            this.PlecM.Text = "Mężczyzna ";
            this.PlecM.UseVisualStyleBackColor = true;
            // 
            // PlecK
            // 
            this.PlecK.AutoSize = true;
            this.PlecK.Location = new System.Drawing.Point(117, 0);
            this.PlecK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlecK.Name = "PlecK";
            this.PlecK.Size = new System.Drawing.Size(77, 21);
            this.PlecK.TabIndex = 23;
            this.PlecK.TabStop = true;
            this.PlecK.Text = "Kobieta";
            this.PlecK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PlecK);
            this.groupBox1.Controls.Add(this.PlecM);
            this.groupBox1.Location = new System.Drawing.Point(276, 145);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 27);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StudentNie);
            this.groupBox2.Controls.Add(this.StudentTak);
            this.groupBox2.Location = new System.Drawing.Point(276, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(111, 30);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "zł";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RodzajZat);
            this.Controls.Add(this.pensja_netto);
            this.Controls.Add(this.Pensja);
            this.Controls.Add(this.RodzajZatrudnienia);
            this.Controls.Add(this.Czy_Student);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Stanow);
            this.Controls.Add(this.Pesel);
            this.Controls.Add(this.Naz);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Imie;
        public System.Windows.Forms.TextBox Naz;
        public System.Windows.Forms.TextBox Pesel;
        public System.Windows.Forms.TextBox Stanow;
        public System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label Czy_Student;
        private System.Windows.Forms.Label RodzajZatrudnienia;
        private System.Windows.Forms.Label Pensja;
        private System.Windows.Forms.TextBox pensja_netto;
        private System.Windows.Forms.RadioButton StudentTak;
        private System.Windows.Forms.RadioButton StudentNie;
        private System.Windows.Forms.ComboBox RodzajZat;
        private System.Windows.Forms.RadioButton PlecM;
        private System.Windows.Forms.RadioButton PlecK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}