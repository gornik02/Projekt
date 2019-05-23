using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace Projekt
{

    public class DataBaseConnection
    {
        //  Set Data to Connecting
        private string _connectionData, server_name, user_id, password, database_name;
        bool connect_condition = false;

        private MySqlConnection connectionstring;

        Main_Form main_Form;

        public string _ConnectionData
        {
            set { _connectionData = value; }
            get { return _connectionData; }
        }

        public DataBaseConnection(string server_name, string user_id, string password, string database_name, Main_Form form)
        {
            this.server_name = server_name;
            this.user_id = user_id;
            this.password = password;
            this.database_name = database_name;
            this._ConnectionData = "server=" + server_name + ";user id=" + user_id + ";password=" + password + ";database=" + database_name;
            connectionstring = new MySqlConnection(_connectionData);
            this.main_Form = form;
            //connectionstring = new MySqlConnection("server=localhost;user id=root;password=;database=Pracownicy");
        }

        //  Connecting
        //  MySqlConnection connectionstring = new MySqlConnection("server=localhost;user id=root;database=pracownicy");

        public void OpenConnection()
        {
            connectionstring.Open();
            connect_condition = true;
        }

        public void CloseConnection()
        {
            connectionstring.Close();
            connect_condition = false;
        }

        public bool Condition
        {
            get { return connect_condition; }
        }

        public DataTable ReadAllValues()
        {
            DataTable DT = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter("select* from " + main_Form.Pracownicy_nazwa, connectionstring);
            DA.Fill(DT);
            return DT;
        }

        public DataTable ReadAllValues2()
        {
            DataTable DT = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter("select* from " + main_Form.Ksiegowi_nazwa, connectionstring);
            DA.Fill(DT);
            return DT;
        }

        public DataTable ReadZwolnienia()
        {
            DataTable DT = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter("select * from " + main_Form.Zwolnienia_nazwa, connectionstring);
            DA.Fill(DT);
            return DT;
        }

        public void Add_Person(int id,string imie,string nazwisko,string pesel,string plec,string stanowisko,string czystu,string rodzajzatr,string pensja_brutto)      //Add Person 2/2
        {
            using (var connection = new MySqlConnection(_connectionData))
            {
                connection.Open();
                var sql = "INSERT INTO " + main_Form.Pracownicy_nazwa + "(Id,Imie, Nazwisko,Numer_PESEL,Plec,Stanowisko,Czy_Student,Rodzaj_Zatrudnienia,Pensja_Brutto) VALUES(@Id, @Imie, @Nazwisko,@Numer_PESEL,@Plec,@Stanowisko,@Czy_Student,@Rodzaj_Zatrudnienia,@Pensja_Brutto)";
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Imie", imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    cmd.Parameters.AddWithValue("@Numer_PESEL", pesel);
                    cmd.Parameters.AddWithValue("@Plec", plec);
                    cmd.Parameters.AddWithValue("@Stanowisko", stanowisko);
                    cmd.Parameters.AddWithValue("@Czy_Student", czystu);
                    cmd.Parameters.AddWithValue("@Rodzaj_Zatrudnienia", rodzajzatr);
                    cmd.Parameters.AddWithValue("@Pensja_Brutto", pensja_brutto);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void Add_Person2(int id,string iden_firmowy, string imie, string nazwisko, string login, string haslo)      //Add Ksiegowa 2/2
        {
            using (var connection = new MySqlConnection(_connectionData))
            {
                connection.Open();
                var sql = "INSERT INTO " + main_Form.Ksiegowi_nazwa + "(ID, ID_Firmowy, Imie, Nazwisko, Login, Haslo) VALUES(@ID, @ID_Firmowy, @Imie, @Nazwisko, @Login, @Haslo)";
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@ID_Firmowy", iden_firmowy);
                    cmd.Parameters.AddWithValue("@Imie", imie);
                    cmd.Parameters.AddWithValue("@Nazwisko", nazwisko);
                    cmd.Parameters.AddWithValue("@Login", login);
                    cmd.Parameters.AddWithValue("@Haslo", haslo);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void Delete_Person(int indeks, string nazwaBazyDanych)      //Delete Person 3/3
        {
            using (var connection = new MySqlConnection(_connectionData))
            {
                connection.Open();
                var sql = "Delete From " + nazwaBazyDanych + " Where Imie = @Imie AND Nazwisko = @Nazwisko AND Numer_PESEL = @Numer_PESEL AND Plec = @Plec And Stanowisko = @Stanowisko";
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Imie", main_Form.people[indeks].IMIE);
                    cmd.Parameters.AddWithValue("@Nazwisko", main_Form.people[indeks].NAZWISKO);
                    cmd.Parameters.AddWithValue("@Numer_PESEL", main_Form.people[indeks].PESEL);
                    cmd.Parameters.AddWithValue("@Plec", main_Form.people[indeks].PLEC);
                    cmd.Parameters.AddWithValue("@Stanowisko", main_Form.people[indeks].STANOWISKO);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void Delete_Person2(int indeks, string nazwaBazyDanych)      //Delete Ksiegowa 3/3
        {
            using (var connection = new MySqlConnection(_connectionData))
            {
                connection.Open();
                var sql = "Delete From " + nazwaBazyDanych + " Where ID_Firmowy = @ID_Firmowy AND Imie = @Imie AND Nazwisko = @Nazwisko AND Login = @Login AND Haslo = @Haslo";
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_Firmowy", main_Form.Pracownicy_ksiegowi[indeks].ID_Firmowy);
                    cmd.Parameters.AddWithValue("@Imie", main_Form.Pracownicy_ksiegowi[indeks].IMIE);
                    cmd.Parameters.AddWithValue("@Nazwisko", main_Form.Pracownicy_ksiegowi[indeks].NAZWISKO);
                    cmd.Parameters.AddWithValue("@Login", main_Form.Pracownicy_ksiegowi[indeks].LOGIN);
                    cmd.Parameters.AddWithValue("@Haslo", main_Form.Pracownicy_ksiegowi[indeks].HASLO);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void Change_Index_When_Deleted(int stary, string nazwaID, int nowy, string nazwabazydanych)      //Ustawianie indeksów po usuwaniu
        {

            using (var connection = new MySqlConnection(_connectionData))
            {
                connection.Open();
                var sql = "UPDATE " + nazwabazydanych + " SET " + nazwaID + " = @incid Where " + nazwaID + " = @autoid";
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@incid", nowy);
                    cmd.Parameters.AddWithValue("@autoid", stary);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }
    }
}
