using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;
using System.Collections;

namespace Projekt
{
    public partial class Main_Form : Form
    {
        public Form2 PeopleData_Form;
        public Logowanie Log;
        public DataBaseConnection DB;
        public List<Persons> people;
        public List<Ksiegowi> Pracownicy_ksiegowi;
        public List<Zwolnienia> zwolnienia;
        public Wynagrodzenia wyn;
        public List<string> Loginy, Hasla;
        bool temp = false;
        public string Pracownicy_nazwa, Ksiegowi_nazwa, Zwolnienia_nazwa,NIP_pracodawcy;
        public Main_Form()
        {
            InitializeComponent();
            PeopleData_Form = new Form2(this);
            red_yellow_green.BackColor = Color.FromName("Red");
            try    // to można skrócić do funkcji
            {
                StreamReader SR = new StreamReader("ConnectingData.txt");
                int counter = 0;
                string line = "";
                while ((line = SR.ReadLine()) != null)
                {
                    if (counter == 0)
                        server_name.Text = line;
                    else if (counter == 1)
                        user_id.Text = line;
                    else if (counter == 2)
                        password.Text = line;
                    else if (counter == 3)
                        database_name.Text = line;
                    else if (counter == 4)
                    {
                        Pracownicy_nazwa = line;
                        txtboxPracownicy.Text = line;
                    }
                    else if (counter == 5)
                    {
                        Ksiegowi_nazwa = line;
                        txtboxKsiegowi.Text = line;
                    }
                    else if (counter == 6)
                    {  Zwolnienia_nazwa = line;
                    txtboxZwolnienia.Text = line; }
                    else if (counter == 7)
                    {
                        NIP_pracodawcy = line;
                        textboxNIP_pracodawcy.Text = line;
                    }
                    counter++;
                }
                SR.Close();
            }
            catch (FileNotFoundException File)
            {
                MessageBox.Show("Nie można znaleźć pliku " + File.FileName.ToString());
            }

            try
            {
                DB = new DataBaseConnection(server_name.Text, user_id.Text, password.Text, database_name.Text, this);
                DB.OpenConnection();
                red_yellow_green.BackColor = Color.FromName("Green");
                Refresh_Data();
                Refresh_Data2();
                DataTable DT = new DataTable();
                DT = DB.ReadAllValues();
                // DT_2 = DB.ReadAllValues2();
                dataGridView1.DataSource = DT;
                DB.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Bład połączenia! Sprawdź połączenie z internetem oraz dane logowania do bazy danych...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log.Hide();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (temp == false)
            {
                if (!this.IsHandleCreated)
                {
                    value = false;
                    CreateHandle();
                }
                base.SetVisibleCore(value);
                Log = new Logowanie(this);
                Log.Show();
                temp = true;
            }
            else
            {
                if (!this.IsHandleCreated)
                {
                    value = false;
                    CreateHandle();
                }
                base.SetVisibleCore(value);
            }
        }

        public void Refresh_Data()
        {
            people = GetPeopleList();
            zwolnienia = GetZwoleniaList();
            listView1.Items.Clear();
            foreach (var Persons in people)
            {
                var row = new string[] { Persons.ID.ToString(), Persons.IMIE, Persons.NAZWISKO, Persons.PESEL.ToString(), Persons.PLEC, Persons.STANOWISKO, Persons.CZY_STUDENT, Persons.RODZAJ_ZATRUDNIENIA, Persons.PENSJA_BRUTTO };
                var lvi = new ListViewItem(row);
                lvi.Tag = Persons;
                listView1.Items.Add(lvi);

                for (int y=0;y<zwolnienia.Count;y++)        //Sprawdź czy na zwolnieniu i pokoloruj
                {
                    if (Persons.PESEL == zwolnienia[y].pesel)
                    {
                        string date = zwolnienia[y].ZwolnienieOd, date2 = zwolnienia[y].ZwolnienieDo;
                        int year = Convert.ToInt32(date.Substring(6, 4)), year2 = Convert.ToInt32(date2.Substring(6, 4));
                        int month = Convert.ToInt32(date.Substring(3, 2)), month2 = Convert.ToInt32(date2.Substring(3, 2));
                        int day = Convert.ToInt32(date.Substring(0, 2)),day2 = Convert.ToInt32(date2.Substring(0, 2));
                        DateTime dt1 = new DateTime(year, month, day), dt2 = new DateTime(year2,month2,day2);
                        DateTime now = DateTime.Now;
                        int result = DateTime.Compare(dt1, now), result2 = DateTime.Compare(dt2,now);
                        if (result <= 0 && result2 >=0)
                        {
                            string hex = "#b2b2ff";
                            Color color = System.Drawing.ColorTranslator.FromHtml(hex);
                            lvi.BackColor = color;
                        }         
                   }
                }
            }

            DataTable DT = new DataTable();
            DT = DB.ReadAllValues();
            dataGridView1.DataSource = DT;
        }

        public void Refresh_Data2()
        {
            Pracownicy_ksiegowi = GetKsiegowiList();
            listView2.Items.Clear();
            foreach (var Ksiegowi in Pracownicy_ksiegowi)
            {
                var row = new string[] { Ksiegowi.ID.ToString(), Ksiegowi.ID_Firmowy, Ksiegowi.IMIE, Ksiegowi.NAZWISKO, Ksiegowi.LOGIN, Ksiegowi.HASLO };
                var lvi = new ListViewItem(row);
                lvi.Tag = Ksiegowi;
                listView2.Items.Add(lvi);
            }
        }

        private List<Persons> GetPeopleList()
        {
            var list = new List<Persons>();
            DataTable DT = new DataTable();
            DT = DB.ReadAllValues();
            int row_counter = 0;
            while (DT != null && row_counter < DT.Rows.Count)
            {
                list.Add(new Persons() {ID = Convert.ToInt32(DT.Rows[row_counter]["Id"]),IMIE = DT.Rows[row_counter]["Imie"].ToString(), NAZWISKO = DT.Rows[row_counter]["Nazwisko"].ToString(), PESEL = DT.Rows[row_counter]["Numer_PESEL"].ToString(), PLEC = DT.Rows[row_counter]["Plec"].ToString() , STANOWISKO= DT.Rows[row_counter]["Stanowisko"].ToString() , CZY_STUDENT=DT.Rows[row_counter]["Czy_Student"].ToString(),RODZAJ_ZATRUDNIENIA=DT.Rows[row_counter]["Rodzaj_Zatrudnienia"].ToString(),PENSJA_BRUTTO=DT.Rows[row_counter]["Pensja_Brutto"].ToString()});
                row_counter++;
            }
            return list;
        }

        private List<Ksiegowi> GetKsiegowiList()
        {
            var list = new List<Ksiegowi>();
            DataTable DT = new DataTable();
            DT = DB.ReadAllValues2();
            int row_counter = 0;
            while (DT != null && row_counter < DT.Rows.Count)
            {
                try
                {
                    list.Add(new Ksiegowi() { ID = Convert.ToInt32(DT.Rows[row_counter]["ID"]), ID_Firmowy = DT.Rows[row_counter]["ID_Firmowy"].ToString(), IMIE = DT.Rows[row_counter]["Imie"].ToString(), NAZWISKO = DT.Rows[row_counter]["Nazwisko"].ToString(), LOGIN = DT.Rows[row_counter]["Login"].ToString(), HASLO = DT.Rows[row_counter]["Haslo"].ToString() });
                    row_counter++;
                }
                catch (Exception )
                {
                    MessageBox.Show("Nazwy kolumn z bazy danych się nie zgadzają!");
                    throw;
                }

            }
            return list;
        }

        private List<Zwolnienia> GetZwoleniaList()
        {
            var list = new List<Zwolnienia>();
            DataTable DT= new DataTable();
            DT = DB.ReadZwolnienia();
            int row_counter = 0;
            while (DT != null && row_counter < DT.Rows.Count)    //weryfkiacja NIP 
            {
                if(DT.Rows[row_counter]["NIP_Pracodawcy"].ToString()==NIP_pracodawcy)
                list.Add(new Zwolnienia() {id = Convert.ToInt32(DT.Rows[row_counter]["Id"]), pesel = DT.Rows[row_counter]["Numer_PESEL"].ToString(),nip = DT.Rows[row_counter]["NIP_Pracodawcy"].ToString(),typZwolnienia = DT.Rows[row_counter]["Typ_zwolnienia"].ToString(),ZwolnienieOd = DT.Rows[row_counter]["Zwolnienie_OD"].ToString(),ZwolnienieDo = DT.Rows[row_counter]["Zwolnienie_DO"].ToString()});
                row_counter++;
            }
            return list;
        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            readonly string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow(null, _caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void button2_Click(object sender, EventArgs e)      //POŁĄCZ
        {
            if (red_yellow_green.BackColor.Name == "Green")
                MessageBox.Show("Już połączono!");
            else
            {
                try
                {
                    System.Timers.Timer timer = new System.Timers.Timer();
                    DataTable DT = new DataTable();
                    red_yellow_green.BackColor = Color.FromName("Yellow");
                    AutoClosingMessageBox.Show("Łączenie z MySQL...", "Czekaj", 500);
                    DB = new DataBaseConnection(server_name.Text, user_id.Text, password.Text, database_name.Text, this);
                    DB.OpenConnection();
                    if (DB.Condition)
                    {
                        StreamWriter SW = new StreamWriter("ConnectingData.txt");
                        SW.Write(server_name.Text + "\r\n" + user_id.Text + "\r\n" + password.Text + "\r\n" + database_name.Text);
                        SW.Close();
                        red_yellow_green.BackColor = Color.FromName("Green");
                        MessageBox.Show("Połaczono!");
                        DT = DB.ReadAllValues();
                        dataGridView1.DataSource = DT;
                        listView1.Items.Clear();
                        foreach (var Persons in people)
                        {
                            var row = new string[] { Persons.ID.ToString(), Persons.IMIE, Persons.NAZWISKO, Persons.PESEL.ToString(), Persons.PLEC, Persons.STANOWISKO };
                            var lvi = new ListViewItem(row);
                            lvi.Tag = Persons;
                            listView1.Items.Add(lvi);
                        }
                    }
                    DB.CloseConnection();
                }
                catch (Exception )
                {
                    red_yellow_green.BackColor = Color.FromName("Red");
                    MessageBox.Show("Bład połączenia! Sprawdź dane i spróbuj ponownie...");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)      //RESET
        {
            StreamWriter SW = new StreamWriter("ConnectingData.txt");
            SW.Close();
            server_name.Text = "";
            user_id.Text = "";
            password.Text = "";
            database_name.Text = "";
            txtboxPracownicy.Text = "";
            txtboxKsiegowi.Text = "";
            txtboxZwolnienia.Text = "";
            SW.Close();
            DB.CloseConnection();
            dataGridView1.DataSource = null;
            listView1.Items.Clear();
            if (DB.Condition == false)
            {
                red_yellow_green.BackColor = Color.FromName("Red");
            }
        }

        private void button4_Click(object sender, EventArgs e)      //ROZŁĄCZ
        {
            DB.CloseConnection();
            red_yellow_green.BackColor = Color.FromName("Red");
            dataGridView1.DataSource = null;
            listView1.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)    //Temp usuń
        {
            ADD.Enabled = true;
            UPDATE.Enabled = true;
            Usun_temp.Visible = false;
            listView1.CheckBoxes = false;
            DELETE.Visible = true;
            USUN_2.Visible = false;
        }

        private void DELETE_Click(object sender, EventArgs e)       //Delete Person 1/3
        {
            if (listView1.Items.Count > 0)
            {
                UPDATE.Enabled = false;
                ADD.Enabled = false;
                listView1.CheckBoxes = true;
                DELETE.Visible = false;
                USUN_2.Visible = true;
                Usun_temp.Visible = true;
            }
            else
                MessageBox.Show("Baza pracowników jest pusta!");
        }

        private void button1_Click(object sender, EventArgs e)      //Delete Person 2/3
        {
            if (listView1.CheckedIndices.Count > 0)
            {
                List<int> indeksy = new List<int>(), pozostale = new List<int>();
                for (int i = 0; i < listView1.CheckedIndices.Count; i++)
                {
                    indeksy.Add(listView1.CheckedIndices[i]);
                }
                for (int i = 0; i < people.Count; i++)
                {
                    pozostale.Add(people[i].ID);
                }
                DialogResult DR = MessageBox.Show("Czy napewno chcesz usunąć?", "Potwierdzenie decyzji usunięcia pracowników", MessageBoxButtons.YesNo);
                for (int i = 0; i < indeksy.Count; i++)
                {
                    switch (DR)
                    {
                        case DialogResult.Yes: DB.Delete_Person(indeksy[i], Pracownicy_nazwa); pozostale.Remove(indeksy[i] + 1); break;
                        case DialogResult.No: break;
                    }

                }
                switch (DR)
                {
                    case DialogResult.Yes:
                        ;
                        for (int i = 0; i < pozostale.Count; i++)
                            DB.Change_Index_When_Deleted(pozostale[i], "Id", i + 1, Pracownicy_nazwa);
                        Refresh_Data();
                        USUN_2.Visible = false;
                        listView1.CheckBoxes = false;
                        Usun_temp.Visible = false;
                        DELETE.Visible = true; ADD.Enabled = true;
                        UPDATE.Enabled = true; break;
                }

            }
            else
                MessageBox.Show("Nikogo nie wybrano!");
        }

        private void UPDATE_Click(object sender, EventArgs e)       //Odśwież
        {
            Refresh_Data();
        }

        private void Refresh_K_Click(object sender, EventArgs e)    //Odśwież 2
        {
            Refresh_Data2();
        }

        private void ADD_Click(object sender, EventArgs e)      //Add Person 1/2
        {
            if (!IsFormOpen(typeof(Form3)))
            new Form3(this).Show();
        }

        private void Add_K_Click(object sender, EventArgs e)        //Add Ksiegowa 1/2
        {
            if (!IsFormOpen(typeof(Form4)))
                new Form4(this).Show();
        }

        private void button1_Click_2(object sender, EventArgs e)        //Logowanie Form
        {
            this.Hide();
            new Logowanie(this).Show();
        }

        private void Usuntemp_2_Click_1(object sender, EventArgs e)     //Temp delete
        {
            Add_K.Enabled = true;
            Refresh_K.Enabled = true;
            Usuntemp_2.Visible = false;
            listView2.CheckBoxes = false;
            Del1_K.Visible = true;
            Del2_K.Visible = false;
        }

        private void Del1_K_Click(object sender, EventArgs e)       //Delete Księgowa 1/3
        {
            if (listView2.Items.Count > 0)
            {
                Refresh_K.Enabled = false;
                Add_K.Enabled = false;
                listView2.CheckBoxes = true;
                Del1_K.Visible = false;
                Del2_K.Visible = true;
                Usuntemp_2.Visible = true;
            }
            else
                MessageBox.Show("Baza księgowych jest pusta!");
        }


        private void Del2_K_Click(object sender, EventArgs e)       //Delete Księgowa 2/3
        {
            if (listView2.CheckedIndices.Count > 0)
            {
                List<int> indeksy = new List<int>(), pozostale = new List<int>();
                for (int i = 0; i < listView2.CheckedIndices.Count; i++)
                {
                    indeksy.Add(listView2.CheckedIndices[i]);
                }
                for (int i = 0; i < Pracownicy_ksiegowi.Count; i++)
                {
                    pozostale.Add(Pracownicy_ksiegowi[i].ID);
                }
                DialogResult DR = MessageBox.Show("Czy napewno chcesz usunąć?", "Potwierdzenie decyzji usunięcia księgowego", MessageBoxButtons.YesNo);
                for (int i = 0; i < indeksy.Count; i++)
                {

                    switch (DR)
                    {
                        case DialogResult.Yes: DB.Delete_Person2(indeksy[i], Ksiegowi_nazwa); pozostale.Remove(indeksy[i] + 1); break;
                        case DialogResult.No: break;
                    }

                }
                switch (DR)
                {
                    case DialogResult.Yes:
                        for (int i = 0; i < pozostale.Count; i++)
                        DB.Change_Index_When_Deleted(pozostale[i], "ID", i + 1, Ksiegowi_nazwa);
                        Refresh_Data2();
                        Del2_K.Visible = false;
                        listView2.CheckBoxes = false;
                        Usuntemp_2.Visible = false;
                        Del1_K.Visible = true; Add_K.Enabled = true;
                        Refresh_K.Enabled = true; break;
                }

            }
            else
                MessageBox.Show("Nikogo nie wybrano!");
        }


        private List<Zwolnienia> GetZwolnieniaOsoby(Persons osoba)
        {
            List<Zwolnienia> wynik = new List<Zwolnienia>();
            for (int i=0;i<zwolnienia.Count;i++)
            {
                if (zwolnienia[i].pesel == osoba.PESEL)
                {
                    wynik.Add(zwolnienia[i]);
                }
            }
            return wynik;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)      //Wybieranie pracownika
        {
            try
            {
                if (PeopleData_Form.Visible == false && listView1.CheckBoxes == false)
                {
                    PeopleData_Form = new Form2(this);
                    Persons person = new Persons();
                    person = (Persons)listView1.SelectedItems[0].Tag;
                    var selectedItem = person;


                    if (selectedItem != null)
                    {

                        PeopleData_Form.Show();
                        PeopleData_Form.id.Text = selectedItem.ID.ToString();
                        PeopleData_Form.imie.Text = selectedItem.IMIE.ToString();
                        PeopleData_Form.nazwisko.Text = selectedItem.NAZWISKO.ToString();
                        PeopleData_Form.pesel.Text = selectedItem.PESEL.ToString();
                        PeopleData_Form.plec.Text = selectedItem.PLEC.ToString();
                        PeopleData_Form.stanowisko.Text = selectedItem.STANOWISKO.ToString();
                        PeopleData_Form.czyst.Text = selectedItem.CZY_STUDENT.ToString();
                        PeopleData_Form.zatrud.Text = selectedItem.RODZAJ_ZATRUDNIENIA.ToString();
                        PeopleData_Form.netto.Text = selectedItem.PENSJA_BRUTTO.ToString() + " zł";
                        PeopleData_Form.listView5.Items.Clear();
                        PeopleData_Form.listView6.Items.Clear();
                        List<Zwolnienia> lista = GetZwolnieniaOsoby(person);
                        string data = "";
                        int rok = 0;
                        int mies = 0;
                        
                        if (lista.Count >0 )
                        {
                            string datanow = DateTime.Now.ToString();
                            int miesnow = Convert.ToInt32(datanow.Substring(3, 2));
                            int roknow = Convert.ToInt32(datanow.Substring(6, 4));
                            string dataost = lista[lista.Count - 1].ZwolnienieDo;
                            int miesost = Convert.ToInt32(dataost.Substring(3, 2));
                            int rokost = Convert.ToInt32(dataost.Substring(6, 4));
                            for (int i = 0; i < zwolnienia.Count; i++)
                            {

                                if (zwolnienia[i].pesel == selectedItem.PESEL.ToString())
                                {
                                    var row = new string[] { zwolnienia[i].typZwolnienia.ToString(), zwolnienia[i].ZwolnienieOd.Substring(0, 10).ToString(), zwolnienia[i].ZwolnienieDo.Substring(0, 10).ToString() };
                                    var lvi = new ListViewItem(row);
                                    lvi.Tag = zwolnienia;
                                    PeopleData_Form.listView5.Items.Add(lvi);
                                }
                            }
                            if (miesnow == miesost && roknow == rokost)
                            { 
                                if (lista.Count > 0)
                                {
                                    int tempMies = 0; ;
                                    int tempRok = 0;
                                    for (int i = 0; i < lista.Count; i++)
                                    {
                                        data = lista[i].ZwolnienieDo;
                                        rok = Convert.ToInt32(data.Substring(6, 4));
                                        mies = Convert.ToInt32(data.Substring(3, 2));
                                        tempMies = mies;
                                        tempRok = rok;
                                    }
                                    List<Zwolnienia> listawielezw = new List<Zwolnienia>();
                                    for (int i = 0; i < lista.Count; i++)
                                    {

                                        data = lista[i].ZwolnienieDo;
                                        rok = Convert.ToInt32(data.Substring(6, 4));
                                        mies = Convert.ToInt32(data.Substring(3, 2));
                                        if (mies == tempMies && rok == tempRok)
                                        {
                                            listawielezw.Add(lista[i]);
                                        }
                                    }
                                    //for (int i = 0; i < listawielezw.Count; i++)   //poprawic akt zwolnienia w obecnym msc
                                    // {
                                    // if(listawielezw.Count>0)
                                    data = listawielezw[0].ZwolnienieDo;
                                    rok = Convert.ToInt32(data.Substring(6, 4));
                                    mies = Convert.ToInt32(data.Substring(3, 2));
                                    int dzien = Convert.ToInt32(data.Substring(0, 2));
                                    DateTime date_zwolnienie = new DateTime(rok, mies, dzien);

                                    Wynagrodzenia wynagrodzenia = new Wynagrodzenia(person, DateTime.DaysInMonth(date_zwolnienie.Year, date_zwolnienie.Month), listawielezw, mies);
                                    //if (i == lista.Count - 1)   //najnowsze wynagrodzenie 
                                    wyn = wynagrodzenia;
                                    string miesiac = "";
                                    switch (Convert.ToInt32(date_zwolnienie.Month))
                                    {
                                        case 1: miesiac = "Styczeń"; break;
                                        case 2: miesiac = "Luty"; break;
                                        case 3: miesiac = "Marzec"; break;
                                        case 4: miesiac = "Kwiecień"; break;
                                        case 5: miesiac = "Maj"; break;
                                        case 6: miesiac = "Czerwiec"; break;
                                        case 7: miesiac = "Lipiec"; break;
                                        case 8: miesiac = "Sierpien"; break;
                                        case 9: miesiac = "Wrzesień"; break;
                                        case 10: miesiac = "Październik"; break;
                                        case 11: miesiac = "Listopad"; break;
                                        case 12: miesiac = "Grudzień"; break;
                                    }
                                    var row2 = new string[] { miesiac, wynagrodzenia.PENSJA_NETTO.ToString() + " zł", wynagrodzenia.PENSJA_BRUTTO.ToString() + " zł", wynagrodzenia.PENSJA_BRUTTO_BRUTTO.ToString() + " zł", wynagrodzenia.SkładkiSuma.ToString() + " zł", date_zwolnienie.Year.ToString() };
                                    var lvi2 = new ListViewItem(row2);
                                    lvi2.Tag = zwolnienia;
                                    PeopleData_Form.listView6.Items.Add(lvi2);

                                    //}
                                }
                            }
                            else
                            {

                                {
                                    data = DateTime.Now.ToString();
                                    rok = Convert.ToInt32(data.Substring(6, 4));
                                    mies = Convert.ToInt32(data.Substring(3, 2));
                                    int dzien = Convert.ToInt32(data.Substring(0, 2));
                                    DateTime date_zwolnienie = new DateTime(rok, mies, dzien);
                                    Wynagrodzenia wynagrodzenia = new Wynagrodzenia(person, DateTime.DaysInMonth(date_zwolnienie.Year, date_zwolnienie.Month), mies);
                                    wyn = wynagrodzenia;
                                    string miesiac = "";
                                    switch (Convert.ToInt32(date_zwolnienie.Month))
                                    {
                                        case 1: miesiac = "Styczeń"; break;
                                        case 2: miesiac = "Luty"; break;
                                        case 3: miesiac = "Marzec"; break;
                                        case 4: miesiac = "Kwiecień"; break;
                                        case 5: miesiac = "Maj"; break;
                                        case 6: miesiac = "Czerwiec"; break;
                                        case 7: miesiac = "Lipiec"; break;
                                        case 8: miesiac = "Sierpien"; break;
                                        case 9: miesiac = "Wrzesień"; break;
                                        case 10: miesiac = "Październik"; break;
                                        case 11: miesiac = "Listopad"; break;
                                        case 12: miesiac = "Grudzień"; break;
                                    }
                                    var row2 = new string[] { miesiac, wynagrodzenia.PENSJA_NETTO.ToString() + " zł", wynagrodzenia.PENSJA_BRUTTO.ToString() + " zł", wynagrodzenia.PENSJA_BRUTTO_BRUTTO.ToString() + " zł", wynagrodzenia.SkładkiSuma.ToString() + " zł", date_zwolnienie.Year.ToString() };
                                    var lvi2 = new ListViewItem(row2);
                                    lvi2.Tag = zwolnienia;
                                    PeopleData_Form.listView6.Items.Add(lvi2);
                                }
                            }
                        }
                        else
                        {
                             data =DateTime.Now.ToString();
                             rok = Convert.ToInt32(data.Substring(6, 4));
                             mies = Convert.ToInt32(data.Substring(3, 2));
                            int dzien = Convert.ToInt32(data.Substring(0, 2));
                            DateTime date_zwolnienie = new DateTime(rok, mies, dzien);
                            Wynagrodzenia wynagrodzenia = new Wynagrodzenia(person, DateTime.DaysInMonth(date_zwolnienie.Year, date_zwolnienie.Month),mies);
                            wyn = wynagrodzenia;
                            string miesiac = "";
                            switch (Convert.ToInt32(date_zwolnienie.Month))
                            {
                                case 1: miesiac = "Styczeń"; break;
                                case 2: miesiac = "Luty"; break;
                                case 3: miesiac = "Marzec"; break;
                                case 4: miesiac = "Kwiecień"; break;
                                case 5: miesiac = "Maj"; break;
                                case 6: miesiac = "Czerwiec"; break;
                                case 7: miesiac = "Lipiec"; break;
                                case 8: miesiac = "Sierpien"; break;
                                case 9: miesiac = "Wrzesień"; break;
                                case 10: miesiac = "Październik"; break;
                                case 11: miesiac = "Listopad"; break;
                                case 12: miesiac = "Grudzień"; break;
                            }
                            var row2 = new string[] { miesiac, wynagrodzenia.PENSJA_NETTO.ToString() + " zł", wynagrodzenia.PENSJA_BRUTTO.ToString() + " zł", wynagrodzenia.PENSJA_BRUTTO_BRUTTO.ToString() + " zł", wynagrodzenia.SkładkiSuma.ToString() + " zł", date_zwolnienie.Year.ToString() };
                            var lvi2 = new ListViewItem(row2);
                            lvi2.Tag = zwolnienia;
                            PeopleData_Form.listView6.Items.Add(lvi2);
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {

                throw;
            }
        }

        public bool IsFormOpen(Type forma_sender)
        {
            bool Isopen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == forma_sender.Name)
                {
                    Isopen = true;
                    form.BringToFront();
                    break;
                }
            }
            return Isopen;
        }

    }
}
