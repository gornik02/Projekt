using System;
using System.Collections.Generic;
namespace Projekt
{
    public class Ksiegowi
    {
        public int ID { get; set; }
        public Ksiegowi()
        {

        }

        public string ID_Firmowy { get; set; }

        public string IMIE { get; set; }

        public string NAZWISKO { get; set; }

        public string LOGIN { get; set; }

        public string HASLO { get; set; }

        public override string ToString()
        {
            return ID + " " + ID_Firmowy + " " + NAZWISKO + " " + LOGIN + " " + HASLO;
        }
    }
}