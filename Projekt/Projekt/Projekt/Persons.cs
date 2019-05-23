using System;
using System.Collections.Generic;

namespace Projekt
{
    public class Persons //: IDisposable
    {
        // Automatic ID Setter
        private static List<bool> UsedCounter = new List<bool>();
        private static object Lock = new object();
        public int ID { get; set; }
        public Persons()
        { }
           /* lock (Lock)
            {
                int nextIndex = GetAvailableIndex();
                if (nextIndex == -1)
                {
                    nextIndex = UsedCounter.Count;
                    UsedCounter.Add(true);
                }

                ID = nextIndex;
           
        }
        public void Dispose()
        {
            lock (Lock)
            {
                UsedCounter[ID] = false;
            }
        }


        private int GetAvailableIndex()
        {
            for (int i = 0; i < UsedCounter.Count; i++)
            {
                if (UsedCounter[i] == false)
                {
                    return i;
                }
            }

            // Nothing available.
            return -1;
        }
        //*/

        public string IMIE { get; set; }

        public string PESEL { get; set; }

        public string NAZWISKO { get; set; }

        public string PLEC { get; set; }

        public string STANOWISKO { get; set; }
        
        public string CZY_STUDENT { get; set; }

        public string RODZAJ_ZATRUDNIENIA { get; set; }

        public string PENSJA_BRUTTO { get;set; }

        public override string ToString()
        {
            return ID + " " + IMIE + " " + PESEL + " " + NAZWISKO + " " + PLEC + " " + STANOWISKO+" "+ CZY_STUDENT+" "+RODZAJ_ZATRUDNIENIA+" "+PENSJA_BRUTTO;
        }


    }
}
