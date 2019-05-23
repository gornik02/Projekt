using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Wynagrodzenia      //PRZEROBIĆ NA DECIMALE
    {
        Persons person;
        int ILOSC_DNI_MIESIAC;
        int miesiac;
        float WYNAGRODZENIE_ZASADNICZE;
        List<Zwolnienia> ZWOLNIENIA_W_DANYM_MIESIACU;               //tej konkretnej osoby
        int ILOSC_DNI_PRZEPRACOWANE;//,ILOSC_DNI_URLOP;
        float G, H, I, J,J1, K,K1,L1, L, M,M1, N, O,O1, P,P1, Q, R, S, T, V;        //Nazwy odpowiednich kolumn z pliku Excela "Przelicznik wynagrodzeń wzór"        
        
        //DOKOŃCZYĆ JEŚLI STUDENT ??
        int U, W;   //do pełnych

        public Wynagrodzenia(Persons OSOBA, int ILOSC_DNI_MIESIAC, List<Zwolnienia> ZWOLNIENIA_W_DANYM_MIESIACU,int miesiac)
        {
            this.person = OSOBA;
            this.ILOSC_DNI_MIESIAC = ILOSC_DNI_MIESIAC;
            this.ZWOLNIENIA_W_DANYM_MIESIACU = ZWOLNIENIA_W_DANYM_MIESIACU;
            this.miesiac = miesiac;
           // this.ILOSC_DNI_URLOP = iloscDniUrlop(ZWOLNIENIA_W_DANYM_MIESIACU);
            Set();
        }
        public Wynagrodzenia(Persons OSOBA, int ILOSC_DNI_MIESIAC,int miesiac)
        {
            this.person = OSOBA;
            this.ILOSC_DNI_MIESIAC = ILOSC_DNI_MIESIAC;
            this.ZWOLNIENIA_W_DANYM_MIESIACU = new List<Zwolnienia>();
            this.miesiac = miesiac;
           // this.ILOSC_DNI_URLOP =0;
            Set2();
        }
        public float PENSJA_BRUTTO { get; set; }
        public float PENSJA_NETTO { get; set; }
        public float PENSJA_BRUTTO_BRUTTO { get; set; }
        public float SkładkiSuma
        {
            get { return J + K + L + P; }
        }
        public float SKŁADKA_EMERYTALNA
        {
            get { return J; }
        }
        public float SKŁADKA_RENTOWA
        {
            get { return K; }
        }
        public float SKŁADKA_CHOROBOWA
        {
            get { return L; }
        }
        public float SKŁADKA_ZDROWOTNA
        {
            get { return P; }
        }
        private void Set()
        {
            PENSJA_BRUTTO = (float)Math.Round((float)Convert.ToDecimal(person.PENSJA_BRUTTO), 2);
            float pensja_start= (float)Math.Round((float)Convert.ToDecimal(person.PENSJA_BRUTTO), 2);
            float emerytalna, rentowa, wypadkowa, fundusz_pracy, sumaPracodawca=0;
            if (person.RODZAJ_ZATRUDNIENIA=="Umowa o prace")
            {

                J = (float)Math.Round(pensja_start * (float)0.0976, 2);
                K = (float)Math.Round(pensja_start * (float)0.015, 2);
                L = (float)Math.Round(pensja_start * (float)0.0245, 2);
                M1 = (float)Math.Round(J + K + L, 2);            
                O1 = (float)Math.Round(pensja_start - M1, 2);
                P = (float)Math.Round(O1 * (float)0.09, 2); 

                //emerytalna = (float)Math.Round(PENSJA_BRUTTO * (float)0.0976, 2);
                //rentowa = (float)Math.Round(PENSJA_BRUTTO * (float)0.085, 2);
                //wypadkowa = (float)Math.Round(PENSJA_BRUTTO * (float)0.017, 2);
                //fundusz_pracy = (float)Math.Round(PENSJA_BRUTTO * (float)0.0245, 2);
                //sumaPracodawca = (float)Math.Round(emerytalna + rentowa + wypadkowa + fundusz_pracy, 2);
            }
            for (int i = 0; i < ZWOLNIENIA_W_DANYM_MIESIACU.Count; i++)
            {
                int ILOSC_DNI_URLOP=iloscDniUrlop(ZWOLNIENIA_W_DANYM_MIESIACU[i]);
                this.WYNAGRODZENIE_ZASADNICZE = PENSJA_BRUTTO; ;
                this.ILOSC_DNI_PRZEPRACOWANE = ILOSC_DNI_MIESIAC - ILOSC_DNI_URLOP;
                if (ZWOLNIENIA_W_DANYM_MIESIACU[i].typZwolnienia == "L10")
                {
                    G = (float)Math.Round(WYNAGRODZENIE_ZASADNICZE / ILOSC_DNI_MIESIAC, 2);
                    H = (float)Math.Round(WYNAGRODZENIE_ZASADNICZE, 2);
                }
                else
                {
                    G = (float)Math.Round(WYNAGRODZENIE_ZASADNICZE / ILOSC_DNI_MIESIAC * (ILOSC_DNI_URLOP), 2);
                    H = (float)Math.Round(WYNAGRODZENIE_ZASADNICZE - G, 2);
                }
                    if (ZWOLNIENIA_W_DANYM_MIESIACU[i].typZwolnienia == "L4" && person.RODZAJ_ZATRUDNIENIA == "Umowa o prace")
                    {
                        I = (float)Math.Round((G - ((float)0.1871 * G)) / ILOSC_DNI_MIESIAC * (float)0.8 * ILOSC_DNI_URLOP, 2);
                        J1 = (float)Math.Round(H * (float)0.0976, 2);
                        K1 = (float)Math.Round(H * (float)0.015, 2);
                        L1 = (float)Math.Round(H * (float)0.0245, 2);
                        M = (float)Math.Round(J1 + K1 + L1, 2);
                        N = (float)Math.Round(M, 2);
                        O = (float)Math.Round(I + H - M, 2);
                        P1 = (float)Math.Round(O * (float)0.09, 2);
                        Q = (float)Math.Round(P1, 2);
                        R = (float)Math.Round(O * (float)0.0775, 2);

                        S = (float)111.25;  //Stała kwota
                        T = (float)46.33;   //Stała kwota
                        U = (int)(H + I - M - S);
                        V = (float)Math.Round(U * (float)0.18 - T, 2);
                        W = (int)(V - R);
                        PENSJA_NETTO = (float)Math.Round(H + I - N - Q - W, 2);
                        PENSJA_BRUTTO = (float)Math.Round(I + H, 2);
                    //Składki pracodawcy by obliczyć brutto brutto
                       // float emerytalna, rentowa, wypadkowa, fundusz_pracy, sumaPracodawca;
                     emerytalna = (float)Math.Round(H * (float)0.0976, 2);
                     rentowa = (float)Math.Round(H * (float)0.085, 2);
                     wypadkowa = (float)Math.Round(H * (float)0.017, 2);
                     fundusz_pracy = (float)Math.Round(H * (float)0.0245, 2);
                     sumaPracodawca = (float)Math.Round(emerytalna + rentowa + wypadkowa + fundusz_pracy, 2);
                     PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO + sumaPracodawca, 2);
                    }
                    else if (ZWOLNIENIA_W_DANYM_MIESIACU[i].typZwolnienia == "L10" && person.RODZAJ_ZATRUDNIENIA == "Umowa o prace")
                    {
                       // I = (float)Math.Round((G - ((float)0.1871 * G)) / ILOSC_DNI_MIESIAC * 1 * ILOSC_DNI_URLOP, 2);
                        J1 = (float)Math.Round(H * (float)0.0976, 2);
                        K1 = (float)Math.Round(H * (float)0.015, 2);
                        L1 = (float)Math.Round(H * (float)0.0245, 2);
                        M = (float)Math.Round(J1 + K1 + L1, 2);
                        N = (float)Math.Round(M, 2);
                        O = (float)Math.Round( H - M, 2);
                        P1 = (float)Math.Round(O * (float)0.09, 2);
                        Q = (float)Math.Round(P1, 2);
                        R = (float)Math.Round(O * (float)0.0775, 2);

                        S = (float)111.25;  //Stała kwota
                        T = (float)46.33;   //Stała kwota
                        U = (int)(H  - M - S);
                        V = (float)Math.Round(U * (float)0.18 - T, 2);
                        W = (int)(V - R);
                        PENSJA_NETTO = (float)Math.Round(H  - N - Q - W, 2);
                        PENSJA_BRUTTO = (float)Math.Round( H, 2);
                        //Składki pracodawcy by obliczyć brutto brutto
                        //float emerytalna, rentowa, wypadkowa, fundusz_pracy, sumaPracodawca;
                        emerytalna = (float)Math.Round(H * (float)0.0976, 2);
                        rentowa = (float)Math.Round(H * (float)0.085, 2);
                        wypadkowa = (float)Math.Round(H * (float)0.017, 2);
                        fundusz_pracy = (float)Math.Round(H * (float)0.0245, 2);
                      sumaPracodawca = (float)Math.Round(emerytalna + rentowa + wypadkowa + fundusz_pracy, 2);
                      PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO + sumaPracodawca, 2);
                    }
                    else if (person.RODZAJ_ZATRUDNIENIA == "Umowa zlecenie" && person.CZY_STUDENT == "TAK")
                    {
                      O = (float)Math.Round(H, 2);
                     R = (float)Math.Round(O * (float)0.0775, 2);
                     S = (float)Math.Round((float)0.2 * H, 2);
                     U = (int)(H - S);
                     V = (float)Math.Round((H - S) * (float)0.18, 2);
                     W = (int)(V - R);
                     PENSJA_NETTO = (float)Math.Round(H - V, 2);
                     PENSJA_BRUTTO = (float)Math.Round(H, 2);
                     PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO, 2);
                    }
                    else if (person.RODZAJ_ZATRUDNIENIA == "Umowa zlecenie" && person.CZY_STUDENT == "NIE")
                    {
                     O = (float)Math.Round(pensja_start, 2);
                     P = (float)Math.Round(O * (float)0.09, 2);
                     R = (float)Math.Round(O * (float)0.0775, 2);
                     S = (float)Math.Round((float)0.2 * H, 2);
                     U = (int)(H - R);
                     V = (float)Math.Round((H - S) * (float)0.18, 2);
                     if ((int)V - R < 0)
                        W = (int)0;
                     else
                        W = (int)(V - R);
                     PENSJA_NETTO = (float)Math.Round(H - P - W, 2);
                     PENSJA_BRUTTO = (float)Math.Round(H, 2);
                     PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO, 2);
                    }
                    else if (person.RODZAJ_ZATRUDNIENIA == "Umowa o dzieło")
                    {
                        //S = (float)Math.Round((float)0.5 * H, 2);
                        //U = (int)(H-S);
                        //V = (float)Math.Round(U * (float)0.18, 2);
                        //W = (int)(V - R);
                        float X = (float)Math.Round((float)0.144 * H, 2);
                        PENSJA_NETTO = (float)Math.Round(H - X, 2);
                        PENSJA_BRUTTO = (float)Math.Round(H, 2);
                        PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO, 2);
                    }
                
            }
            
            
        }

        private void Set2()
        {


            this.WYNAGRODZENIE_ZASADNICZE = (float)Math.Round((float)Convert.ToDecimal(person.PENSJA_BRUTTO), 2);
            this.ILOSC_DNI_PRZEPRACOWANE = ILOSC_DNI_MIESIAC;
            G = (float)Math.Round(WYNAGRODZENIE_ZASADNICZE /ILOSC_DNI_MIESIAC, 2);
            H = (float)Math.Round(WYNAGRODZENIE_ZASADNICZE, 2);
            
            
                if (person.RODZAJ_ZATRUDNIENIA == "Umowa o prace")
                {
                    //I = (float)Math.Round((G - ((float)0.1871 * G)) / ILOSC_DNI_MIESIAC, 2);
                    J = (float)Math.Round(H * (float)0.0976, 2);
                    K = (float)Math.Round(H * (float)0.015, 2);
                    L = (float)Math.Round(H * (float)0.0245, 2);
                    M = (float)Math.Round(J + K + L, 2);
                    N = (float)Math.Round(M, 2);
                    O = (float)Math.Round(H - M, 2);
                    P = (float)Math.Round(O * (float)0.09, 2);
                    Q = (float)Math.Round(P, 2);
                    R = (float)Math.Round(O * (float)0.0775, 2);

                    S = (float)111.25;  //Stała kwota
                    T = (float)46.33;   //Stała kwota
                    U = (int)(H - M - S);
                    V = (float)Math.Round(U * (float)0.18 - T, 2);
                    W = (int)(V - R);
                    PENSJA_NETTO = (float)Math.Round(H - N - Q - W, 2);
                    PENSJA_BRUTTO = (float)Math.Round(H, 2);
                    //Składki pracodawcy by obliczyć brutto brutto
                    float emerytalna, rentowa, wypadkowa, fundusz_pracy, sumaPracodawca;
                    emerytalna = (float)Math.Round(H * (float)0.0976, 2);
                    rentowa = (float)Math.Round(H * (float)0.085, 2);
                    wypadkowa = (float)Math.Round(H * (float)0.017, 2);
                    fundusz_pracy = (float)Math.Round(H * (float)0.0245, 2);
                    sumaPracodawca = (float)Math.Round(emerytalna + rentowa + wypadkowa + fundusz_pracy, 2);
                    PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO + sumaPracodawca, 2);
                }
                
                else if (person.RODZAJ_ZATRUDNIENIA == "Umowa zlecenie" && person.CZY_STUDENT == "TAK")
                {
                    O = (float)Math.Round(H, 2);
                    R = (float)Math.Round(O * (float)0.0775, 2);
                    S = (float)Math.Round((float)0.2 * H, 2);
                    U = (int)(H - S);
                    V = (float)Math.Round((H - S) * (float)0.18, 2);
                    W = (int)(V - R);
                    PENSJA_NETTO = (float)Math.Round(H - V, 2);
                    PENSJA_BRUTTO = (float)Math.Round(H, 2);
                    PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO, 2);
                }
                else if (person.RODZAJ_ZATRUDNIENIA == "Umowa zlecenie" && person.CZY_STUDENT == "NIE")
                {
                    O = (float)Math.Round(H, 2);
                    P = (float)Math.Round(O * (float)0.09, 2);
                    R = (float)Math.Round(O * (float)0.0775, 2);
                    S = (float)Math.Round((float)0.2 * H, 2);
                    U = (int)(H - R);
                    V = (float)Math.Round((H - S) * (float)0.18, 2);
                    if ((int)V - R < 0)
                        W = (int)0;
                    else
                        W = (int)(V - R);
                    PENSJA_NETTO = (float)Math.Round(H - P - W, 2);
                    PENSJA_BRUTTO = (float)Math.Round(H, 2);
                    PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO, 2);
                }
                else if (person.RODZAJ_ZATRUDNIENIA == "Umowa o dzieło")
                {
                   // S = (float)Math.Round((float)0.5 * H, 2);
                  //U = (int)(H - S);
                  //V = (float)Math.Round(U * (float)0.18, 2);
                  //W = (int)(V - R);
                  float X = (float)Math.Round((float)0.144 * H, 2);
                    PENSJA_NETTO = (float)Math.Round(H - X, 2);
                    PENSJA_BRUTTO = (float)Math.Round(H, 2);
                    PENSJA_BRUTTO_BRUTTO = (float)Math.Round(PENSJA_BRUTTO, 2);
                }
            
            
        }
        private int iloscDniUrlop(Zwolnienia z)
        {
            int ileDni = 0;
           // for (int i=0;i<z.Count;i++)
            //{
                //if (miesiac == Convert.ToInt32(z[i].ZwolnienieDo.Substring(3, 2)))
                //{
                    int zw_od = Convert.ToInt32(z.ZwolnienieOd.Substring(0, 2)), zw_do = Convert.ToInt32(z.ZwolnienieDo.Substring(0, 2));
                    ileDni += zw_do - zw_od + 1;
               // }
           // }
            return ileDni;
        }


    }
}
