namespace Projekt
{
    partial class Logowanie
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
            this.Login_TxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Haslo_TxtBox = new System.Windows.Forms.TextBox();
            this.Check_Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_TxtBox
            // 
            this.Login_TxtBox.Location = new System.Drawing.Point(183, 136);
            this.Login_TxtBox.Name = "Login_TxtBox";
            this.Login_TxtBox.Size = new System.Drawing.Size(100, 20);
            this.Login_TxtBox.TabIndex = 0;
            this.Login_TxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_TxtBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło";
            // 
            // Haslo_TxtBox
            // 
            this.Haslo_TxtBox.Location = new System.Drawing.Point(183, 167);
            this.Haslo_TxtBox.Name = "Haslo_TxtBox";
            this.Haslo_TxtBox.Size = new System.Drawing.Size(100, 20);
            this.Haslo_TxtBox.TabIndex = 3;
            this.Haslo_TxtBox.UseSystemPasswordChar = true;
            this.Haslo_TxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Haslo_TxtBox_KeyDown);
            // 
            // Check_Butt
            // 
            this.Check_Butt.Location = new System.Drawing.Point(183, 228);
            this.Check_Butt.Name = "Check_Butt";
            this.Check_Butt.Size = new System.Drawing.Size(75, 23);
            this.Check_Butt.TabIndex = 4;
            this.Check_Butt.Text = "Zaloguj";
            this.Check_Butt.UseVisualStyleBackColor = true;
            this.Check_Butt.Click += new System.EventHandler(this.Check_Butt_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 384);
            this.Controls.Add(this.Check_Butt);
            this.Controls.Add(this.Haslo_TxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_TxtBox);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_TxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Haslo_TxtBox;
        private System.Windows.Forms.Button Check_Butt;
    }
}