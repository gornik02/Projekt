using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Projekt
{
    public partial class Logowanie : Form
    {
        Main_Form main_form;

        public Logowanie(Main_Form form)
        {

            InitializeComponent();
            main_form = form;
        }


        private void Logowanie_Load(object sender, EventArgs e)
        {
            if (main_form.Pracownicy_ksiegowi.Count == 0)
            {
                MessageBox.Show("Pierwsze logowanie. Zaloguj się loginem i hasłem administratora...");
            }
        }

        private void Check_Butt_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("admin-pasy.txt");
            string login = sr.ReadLine(), haslo = sr.ReadLine();
            sr.Close();
            if (Login_TxtBox.Text == login && Haslo_TxtBox.Text == haslo)
            {
                main_form.Account_Type_Lbl.Text = "Typ konta: Administrator";
                main_form.tabControl1.TabPages.Remove(main_form.tabPage1);
                main_form.tabControl1.TabPages.Remove(main_form.tabPage2);
                main_form.tabControl1.TabPages.Remove(main_form.tabPage3);
                main_form.tabControl1.TabPages.Remove(main_form.tabPage4);
                main_form.tabControl1.TabPages.Add(main_form.tabPage1);
                main_form.tabControl1.TabPages.Add(main_form.tabPage2);
                main_form.tabControl1.TabPages.Add(main_form.tabPage3);
                main_form.tabControl1.TabPages.Add(main_form.tabPage4);
                main_form.ADD.Show();
                main_form.DELETE.Show();
                main_form.Usuntemp_2.Show();
                this.Hide();
                main_form.Show();
            }
            else if (main_form.Pracownicy_ksiegowi.Count > 0)
            {
                bool check = false;
                for (int i = 0; i < main_form.Pracownicy_ksiegowi.Count; i++)
                {
                    if (Login_TxtBox.Text == main_form.Pracownicy_ksiegowi[i].LOGIN && Haslo_TxtBox.Text == main_form.Pracownicy_ksiegowi[i].HASLO)
                    {
                        check = true;
                        break;
                    }
                }
                if (check == false)
                    MessageBox.Show("Sprawdź dane i spróbuj ponownie!");
                else
                {
                    main_form.Account_Type_Lbl.Text = "Typ konta: Księgowy";
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage1);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage2);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage3);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage4);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage3);
                    main_form.ADD.Hide();
                    main_form.DELETE.Hide();
                    main_form.Usuntemp_2.Hide();
                    this.Hide();
                    main_form.Show();
                }
            }
            else
                MessageBox.Show("Sprawdź dane i spróbuj ponownie!");
        }

        private void Haslo_TxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StreamReader sr = new StreamReader("admin-pasy.txt");
                string login = sr.ReadLine(), haslo = sr.ReadLine();
                sr.Close();
                if (Login_TxtBox.Text == login && Haslo_TxtBox.Text == haslo)
                {
                    main_form.Account_Type_Lbl.Text = "Typ konta: Administrator";
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage1);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage2);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage3);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage4);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage1);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage2);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage3);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage4);
                    main_form.ADD.Show();
                    main_form.DELETE.Show();
                    main_form.Usuntemp_2.Show();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    this.Hide();
                    main_form.Show();
                }
                else if (main_form.Pracownicy_ksiegowi.Count > 0)
                {
                    bool check = false;
                    for (int i = 0; i < main_form.Pracownicy_ksiegowi.Count; i++)
                    {
                        if (Login_TxtBox.Text == main_form.Pracownicy_ksiegowi[i].LOGIN && Haslo_TxtBox.Text == main_form.Pracownicy_ksiegowi[i].HASLO)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (check == false)
                        MessageBox.Show("Sprawdź dane i spróbuj ponownie!");
                    else
                    {
                        main_form.Account_Type_Lbl.Text = "Typ konta: Księgowy";
                        main_form.tabControl1.TabPages.Remove(main_form.tabPage1);
                        main_form.tabControl1.TabPages.Remove(main_form.tabPage2);
                        main_form.tabControl1.TabPages.Remove(main_form.tabPage3);
                        main_form.tabControl1.TabPages.Remove(main_form.tabPage4);
                        main_form.tabControl1.TabPages.Add(main_form.tabPage3);
                        main_form.ADD.Hide();
                        main_form.DELETE.Hide();
                        main_form.Usuntemp_2.Hide();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        this.Hide();
                        main_form.Show();
                    }
                }
                else
                    MessageBox.Show("Sprawdź dane i spróbuj ponownie!");
            }
        }

        private void Login_TxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StreamReader sr = new StreamReader("admin-pasy.txt");
                string login = sr.ReadLine(), haslo = sr.ReadLine();
                sr.Close();
                if (Login_TxtBox.Text == login && Haslo_TxtBox.Text == haslo)
                {
                    main_form.Account_Type_Lbl.Text = "Typ konta: Administrator";
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage1);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage2);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage3);
                    main_form.tabControl1.TabPages.Remove(main_form.tabPage4);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage1);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage2);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage3);
                    main_form.tabControl1.TabPages.Add(main_form.tabPage4);
                    main_form.ADD.Show();
                    main_form.DELETE.Show();
                    main_form.Usuntemp_2.Show();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                    this.Hide();
                    main_form.Show();
                }
                else if (main_form.Pracownicy_ksiegowi.Count > 0)
                {
                    bool check = false;
                    for (int i = 0; i < main_form.Pracownicy_ksiegowi.Count; i++)
                    {
                        if (Login_TxtBox.Text == main_form.Pracownicy_ksiegowi[i].LOGIN && Haslo_TxtBox.Text == main_form.Pracownicy_ksiegowi[i].HASLO)
                        {
                            check = true;
                            break;
                        }
                    }
                    if (check == false)
                        MessageBox.Show("Sprawdź dane i spróbuj ponownie!");
                    else
                    {
                        main_form.Account_Type_Lbl.Text = "Typ konta: Księgowy";
                        main_form.tabControl1.TabPages.Remove(main_form.tabPage1);
                        main_form.tabControl1.TabPages.Remove(main_form.tabPage2);
                        main_form.tabControl1.TabPages.Remove(main_form.tabPage3);
                        main_form.tabControl1.TabPages.Remove(main_form.tabPage4);
                        main_form.tabControl1.TabPages.Add(main_form.tabPage3);
                        main_form.ADD.Hide();
                        main_form.DELETE.Hide();
                        main_form.Usuntemp_2.Hide();
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        this.Hide();
                        main_form.Show();
                    }
                }
                else
                    MessageBox.Show("Sprawdź dane i spróbuj ponownie!");
            }
        }
    }
}
