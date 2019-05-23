using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form4 : Form
    {
        Main_Form main_form;
        public Form4(Main_Form form)
        {

            InitializeComponent();
            main_form = form;
        }

        public Form4()
        { }

        private void Clean()
        {
            this.Imie.Text = "";
            this.Nazwisko.Text = "";
            this.Login.Text = "";
            this.Haslo.Text = "";
            this.Identyfikator.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (((Imie.Text != "" && Nazwisko.Text != "") && (Login.Text != "" && Haslo.Text != "")) && Identyfikator.Text != "")
            {
                main_form.DB.Add_Person2(main_form.Pracownicy_ksiegowi.Count+1,Identyfikator.Text,Imie.Text,Nazwisko.Text,Login.Text,Haslo.Text);
                main_form.Refresh_Data2();
                Clean();
                Enter.Text = "";
                Enter.Text = "Dodaj kolejną księgową";
                MessageBox.Show("Pomyślnie dodano!");
            }
            else
                MessageBox.Show("Wypełnij wszystkie pola!");
        }
    }
}
