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
    public partial class Form3 : Form
    {
        //DataBaseConnection DB = new DataBaseConnection();
        Main_Form main_form;
        public Form3(Main_Form form)
        {

            InitializeComponent();
            main_form = form;
        }

        public Form3()
        { }

        private void Clean()
        {
            this.Imie.Text = "";
            this.Naz.Text = "";
            this.Pesel.Text = "";
            this.Stanow.Text = "";
            this.pensja_netto.Text = "";
        }

        private void Enter_Click_1(object sender, EventArgs e)      //Dodawanie Pracownika
        {
            if ((Imie.Text !="" && Naz.Text != "") && Pesel.Text != "" && ((PlecM.Checked != false &&PlecK.Checked == false) || (PlecM.Checked == false && PlecK.Checked != false)) && Stanow.Text != "" && ((StudentTak.Checked!=false && StudentNie.Checked==false)||(StudentTak.Checked==false&&StudentNie.Checked!=false))&& RodzajZat.SelectedItem.ToString()!="" && pensja_netto.Text!="" )
            {
                string czystu, plec;
                if (StudentTak.Checked == true) czystu = "TAK";
                else czystu="NIE";
                if (PlecM.Checked == true) plec = "Mężczyzna";
                else plec = "Kobieta";
                main_form.DB.Add_Person(main_form.people.Count+1, Imie.Text, Naz.Text, Pesel.Text,plec, Stanow.Text, czystu, RodzajZat.SelectedItem.ToString(), pensja_netto.Text);
                main_form.Refresh_Data();
                Clean();
                Enter.Text = "";
                Enter.Text = "Dodaj kolejną osobę";
                MessageBox.Show("Pomyślnie dodano!");
            }
            else
                MessageBox.Show("Wypełnij wszystkie pola!");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pensja_netto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                
                e.Handled = true;
            }
            else if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') == -1))
            {
                pensja_netto.MaxLength = pensja_netto.Text.Length + 3;
            }
        }
    }
}
