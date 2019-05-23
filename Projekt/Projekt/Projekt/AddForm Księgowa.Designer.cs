namespace Projekt
{
    partial class Form4
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
            this.Enter = new System.Windows.Forms.Button();
            this.Haslo = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Identyfikator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(127, 265);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(222, 23);
            this.Enter.TabIndex = 21;
            this.Enter.Text = "Dodaj osobę";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Haslo
            // 
            this.Haslo.Location = new System.Drawing.Point(210, 199);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(100, 20);
            this.Haslo.TabIndex = 20;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(210, 174);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 19;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(210, 149);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(100, 20);
            this.Nazwisko.TabIndex = 18;
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(210, 110);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(100, 20);
            this.Imie.TabIndex = 17;
            // 
            // Identyfikator
            // 
            this.Identyfikator.Location = new System.Drawing.Point(210, 79);
            this.Identyfikator.Name = "Identyfikator";
            this.Identyfikator.Size = new System.Drawing.Size(100, 20);
            this.Identyfikator.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Imię";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Identyfikator firmowy";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 387);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.Identyfikator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Enter;
        public System.Windows.Forms.TextBox Haslo;
        public System.Windows.Forms.TextBox Login;
        public System.Windows.Forms.TextBox Nazwisko;
        public System.Windows.Forms.TextBox Imie;
        public System.Windows.Forms.TextBox Identyfikator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}