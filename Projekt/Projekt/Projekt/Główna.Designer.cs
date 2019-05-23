namespace Projekt
{
    partial class Main_Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxZwolnienia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxKsiegowi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxPracownicy = new System.Windows.Forms.TextBox();
            this.red_yellow_green = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Rozlacz = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Polacz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.database_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.server_name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DELETE = new System.Windows.Forms.Button();
            this.Usun_temp = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chImie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNazwisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPesel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPlec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStanowisko = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCzy_Student = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRodzajZatrudnienia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPensja_Brutto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADD = new System.Windows.Forms.Button();
            this.USUN_2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Usuntemp_2 = new System.Windows.Forms.Button();
            this.Del1_K = new System.Windows.Forms.Button();
            this.Refresh_K = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Add_K = new System.Windows.Forms.Button();
            this.Del2_K = new System.Windows.Forms.Button();
            this.Log_Off = new System.Windows.Forms.Button();
            this.Account_Type_Lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textboxNIP_pracodawcy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataMember = "pracownicy";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1032, 0);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1319, 576);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textboxNIP_pracodawcy);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtboxZwolnienia);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtboxKsiegowi);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtboxPracownicy);
            this.tabPage1.Controls.Add(this.red_yellow_green);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Rozlacz);
            this.tabPage1.Controls.Add(this.Reset);
            this.tabPage1.Controls.Add(this.Polacz);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.database_name);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.user_id);
            this.tabPage1.Controls.Add(this.server_name);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1311, 544);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Połączenie z bazą danych";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(897, 271);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nazwa bazy ze zwolnieniami";
            // 
            // txtboxZwolnienia
            // 
            this.txtboxZwolnienia.Location = new System.Drawing.Point(1093, 267);
            this.txtboxZwolnienia.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxZwolnienia.Name = "txtboxZwolnienia";
            this.txtboxZwolnienia.Size = new System.Drawing.Size(123, 22);
            this.txtboxZwolnienia.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(912, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nazwa bazy z księgowymi";
            // 
            // txtboxKsiegowi
            // 
            this.txtboxKsiegowi.Location = new System.Drawing.Point(1093, 224);
            this.txtboxKsiegowi.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxKsiegowi.Name = "txtboxKsiegowi";
            this.txtboxKsiegowi.Size = new System.Drawing.Size(123, 22);
            this.txtboxKsiegowi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(896, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nazwa bazy z pracownikami";
            // 
            // txtboxPracownicy
            // 
            this.txtboxPracownicy.Location = new System.Drawing.Point(1093, 178);
            this.txtboxPracownicy.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxPracownicy.Name = "txtboxPracownicy";
            this.txtboxPracownicy.Size = new System.Drawing.Size(123, 22);
            this.txtboxPracownicy.TabIndex = 13;
            // 
            // red_yellow_green
            // 
            this.red_yellow_green.BackColor = System.Drawing.Color.Red;
            this.red_yellow_green.Location = new System.Drawing.Point(973, 124);
            this.red_yellow_green.Margin = new System.Windows.Forms.Padding(4);
            this.red_yellow_green.Name = "red_yellow_green";
            this.red_yellow_green.Size = new System.Drawing.Size(33, 31);
            this.red_yellow_green.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(916, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // Rozlacz
            // 
            this.Rozlacz.Location = new System.Drawing.Point(759, 345);
            this.Rozlacz.Margin = new System.Windows.Forms.Padding(4);
            this.Rozlacz.Name = "Rozlacz";
            this.Rozlacz.Size = new System.Drawing.Size(128, 28);
            this.Rozlacz.TabIndex = 10;
            this.Rozlacz.Text = "Rozłącz";
            this.Rozlacz.UseVisualStyleBackColor = true;
            this.Rozlacz.Click += new System.EventHandler(this.button4_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(576, 345);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(128, 28);
            this.Reset.TabIndex = 9;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button3_Click);
            // 
            // Polacz
            // 
            this.Polacz.Location = new System.Drawing.Point(395, 345);
            this.Polacz.Margin = new System.Windows.Forms.Padding(4);
            this.Polacz.Name = "Polacz";
            this.Polacz.Size = new System.Drawing.Size(128, 28);
            this.Polacz.TabIndex = 8;
            this.Polacz.Text = "Połącz";
            this.Polacz.UseVisualStyleBackColor = true;
            this.Polacz.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazwa bazy danych";
            // 
            // database_name
            // 
            this.database_name.Location = new System.Drawing.Point(535, 267);
            this.database_name.Margin = new System.Windows.Forms.Padding(4);
            this.database_name.Name = "database_name";
            this.database_name.Size = new System.Drawing.Size(285, 22);
            this.database_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasło";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(535, 224);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(285, 22);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa użytkownika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa serwera";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(535, 178);
            this.user_id.Margin = new System.Windows.Forms.Padding(4);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(285, 22);
            this.user_id.TabIndex = 1;
            // 
            // server_name
            // 
            this.server_name.Location = new System.Drawing.Point(535, 130);
            this.server_name.Margin = new System.Windows.Forms.Padding(4);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(285, 22);
            this.server_name.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1311, 544);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Widok bazodanowy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(37, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1232, 512);
            this.dataGridView1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DELETE);
            this.tabPage3.Controls.Add(this.Usun_temp);
            this.tabPage3.Controls.Add(this.UPDATE);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Controls.Add(this.ADD);
            this.tabPage3.Controls.Add(this.USUN_2);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1311, 544);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Dane";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(1111, 161);
            this.DELETE.Margin = new System.Windows.Forms.Padding(4);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(177, 39);
            this.DELETE.TabIndex = 8;
            this.DELETE.Text = "Tryb usuwania";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // Usun_temp
            // 
            this.Usun_temp.Location = new System.Drawing.Point(1111, 156);
            this.Usun_temp.Margin = new System.Windows.Forms.Padding(4);
            this.Usun_temp.Name = "Usun_temp";
            this.Usun_temp.Size = new System.Drawing.Size(176, 53);
            this.Usun_temp.TabIndex = 11;
            this.Usun_temp.Text = "Wyjście z trybu usuwania";
            this.Usun_temp.UseVisualStyleBackColor = true;
            this.Usun_temp.Visible = false;
            this.Usun_temp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(1109, 47);
            this.UPDATE.Margin = new System.Windows.Forms.Padding(4);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(177, 37);
            this.UPDATE.TabIndex = 7;
            this.UPDATE.Text = "Odśwież";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chImie,
            this.chNazwisko,
            this.chPesel,
            this.chPlec,
            this.chStanowisko,
            this.chCzy_Student,
            this.chRodzajZatrudnienia,
            this.chPensja_Brutto});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1100, 454);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 35;
            // 
            // chImie
            // 
            this.chImie.Text = "Imię";
            this.chImie.Width = 90;
            // 
            // chNazwisko
            // 
            this.chNazwisko.Text = "Nazwisko";
            this.chNazwisko.Width = 90;
            // 
            // chPesel
            // 
            this.chPesel.Text = "Numer PESEL";
            this.chPesel.Width = 100;
            // 
            // chPlec
            // 
            this.chPlec.Text = "Płeć";
            this.chPlec.Width = 80;
            // 
            // chStanowisko
            // 
            this.chStanowisko.Text = "Stanowisko";
            this.chStanowisko.Width = 102;
            // 
            // chCzy_Student
            // 
            this.chCzy_Student.Text = "Czy Student";
            this.chCzy_Student.Width = 93;
            // 
            // chRodzajZatrudnienia
            // 
            this.chRodzajZatrudnienia.Text = "Rodzaj Zatrudnienia";
            this.chRodzajZatrudnienia.Width = 135;
            // 
            // chPensja_Brutto
            // 
            this.chPensja_Brutto.Text = "Pensja Brutto [zł]";
            this.chPensja_Brutto.Width = 95;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(1109, 105);
            this.ADD.Margin = new System.Windows.Forms.Padding(4);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(177, 37);
            this.ADD.TabIndex = 6;
            this.ADD.Text = "Dodaj";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // USUN_2
            // 
            this.USUN_2.Location = new System.Drawing.Point(1109, 222);
            this.USUN_2.Margin = new System.Windows.Forms.Padding(4);
            this.USUN_2.Name = "USUN_2";
            this.USUN_2.Size = new System.Drawing.Size(177, 60);
            this.USUN_2.TabIndex = 10;
            this.USUN_2.Text = "USUŃ";
            this.USUN_2.UseVisualStyleBackColor = true;
            this.USUN_2.Visible = false;
            this.USUN_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Usuntemp_2);
            this.tabPage4.Controls.Add(this.Del1_K);
            this.tabPage4.Controls.Add(this.Refresh_K);
            this.tabPage4.Controls.Add(this.listView2);
            this.tabPage4.Controls.Add(this.Add_K);
            this.tabPage4.Controls.Add(this.Del2_K);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1311, 544);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Konta księgowych";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Usuntemp_2
            // 
            this.Usuntemp_2.Location = new System.Drawing.Point(1057, 162);
            this.Usuntemp_2.Margin = new System.Windows.Forms.Padding(4);
            this.Usuntemp_2.Name = "Usuntemp_2";
            this.Usuntemp_2.Size = new System.Drawing.Size(229, 39);
            this.Usuntemp_2.TabIndex = 16;
            this.Usuntemp_2.Text = "Wyjście z trybu usuwania";
            this.Usuntemp_2.UseVisualStyleBackColor = true;
            this.Usuntemp_2.Visible = false;
            this.Usuntemp_2.Click += new System.EventHandler(this.Usuntemp_2_Click_1);
            // 
            // Del1_K
            // 
            this.Del1_K.Location = new System.Drawing.Point(1057, 162);
            this.Del1_K.Margin = new System.Windows.Forms.Padding(4);
            this.Del1_K.Name = "Del1_K";
            this.Del1_K.Size = new System.Drawing.Size(229, 39);
            this.Del1_K.TabIndex = 14;
            this.Del1_K.Text = "Tryb usuwania";
            this.Del1_K.UseVisualStyleBackColor = true;
            this.Del1_K.Click += new System.EventHandler(this.Del1_K_Click);
            // 
            // Refresh_K
            // 
            this.Refresh_K.Location = new System.Drawing.Point(1057, 47);
            this.Refresh_K.Margin = new System.Windows.Forms.Padding(4);
            this.Refresh_K.Name = "Refresh_K";
            this.Refresh_K.Size = new System.Drawing.Size(229, 37);
            this.Refresh_K.TabIndex = 13;
            this.Refresh_K.Text = "Odśwież";
            this.Refresh_K.UseVisualStyleBackColor = true;
            this.Refresh_K.Click += new System.EventHandler(this.Refresh_K_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(995, 454);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Identyfikator firmowy";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Imię";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nazwisko";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Login";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hasło";
            this.columnHeader6.Width = 150;
            // 
            // Add_K
            // 
            this.Add_K.Location = new System.Drawing.Point(1057, 105);
            this.Add_K.Margin = new System.Windows.Forms.Padding(4);
            this.Add_K.Name = "Add_K";
            this.Add_K.Size = new System.Drawing.Size(229, 37);
            this.Add_K.TabIndex = 12;
            this.Add_K.Text = "Dodaj";
            this.Add_K.UseVisualStyleBackColor = true;
            this.Add_K.Click += new System.EventHandler(this.Add_K_Click);
            // 
            // Del2_K
            // 
            this.Del2_K.Location = new System.Drawing.Point(1057, 222);
            this.Del2_K.Margin = new System.Windows.Forms.Padding(4);
            this.Del2_K.Name = "Del2_K";
            this.Del2_K.Size = new System.Drawing.Size(229, 60);
            this.Del2_K.TabIndex = 15;
            this.Del2_K.Text = "USUŃ";
            this.Del2_K.UseVisualStyleBackColor = true;
            this.Del2_K.Visible = false;
            this.Del2_K.Click += new System.EventHandler(this.Del2_K_Click);
            // 
            // Log_Off
            // 
            this.Log_Off.Location = new System.Drawing.Point(1200, 608);
            this.Log_Off.Margin = new System.Windows.Forms.Padding(4);
            this.Log_Off.Name = "Log_Off";
            this.Log_Off.Size = new System.Drawing.Size(100, 28);
            this.Log_Off.TabIndex = 13;
            this.Log_Off.Text = "Wyloguj";
            this.Log_Off.UseVisualStyleBackColor = true;
            this.Log_Off.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Account_Type_Lbl
            // 
            this.Account_Type_Lbl.AutoSize = true;
            this.Account_Type_Lbl.Location = new System.Drawing.Point(16, 608);
            this.Account_Type_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Account_Type_Lbl.Name = "Account_Type_Lbl";
            this.Account_Type_Lbl.Size = new System.Drawing.Size(0, 17);
            this.Account_Type_Lbl.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(899, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "NIP Pracodawcy";
            // 
            // textboxNIP_pracodawcy
            // 
            this.textboxNIP_pracodawcy.Location = new System.Drawing.Point(1093, 301);
            this.textboxNIP_pracodawcy.Name = "textboxNIP_pracodawcy";
            this.textboxNIP_pracodawcy.Size = new System.Drawing.Size(100, 22);
            this.textboxNIP_pracodawcy.TabIndex = 20;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 705);
            this.Controls.Add(this.Account_Type_Lbl);
            this.Controls.Add(this.Log_Off);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Polacz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox database_name;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Rozlacz;
        private System.Windows.Forms.Panel red_yellow_green;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chImie;
        private System.Windows.Forms.ColumnHeader chNazwisko;
        private System.Windows.Forms.ColumnHeader chPlec;
        private System.Windows.Forms.ColumnHeader chStanowisko;
        public System.Windows.Forms.TextBox server_name;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Button ADD;
        public System.Windows.Forms.Button UPDATE;
        public System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button USUN_2;
        private System.Windows.Forms.ColumnHeader chPesel;
        private System.Windows.Forms.Button Usun_temp;
        public System.Windows.Forms.Button Del1_K;
        public System.Windows.Forms.Button Refresh_K;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.Button Add_K;
        private System.Windows.Forms.Button Del2_K;
        private System.Windows.Forms.Button Log_Off;
        public System.Windows.Forms.Label Account_Type_Lbl;
        private System.Windows.Forms.ColumnHeader chCzy_Student;
        private System.Windows.Forms.ColumnHeader chRodzajZatrudnienia;
        private System.Windows.Forms.ColumnHeader chPensja_Brutto;
        public System.Windows.Forms.Button Usuntemp_2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtboxZwolnienia;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtboxKsiegowi;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtboxPracownicy;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textboxNIP_pracodawcy;
        private System.Windows.Forms.Label label9;
    }
}

