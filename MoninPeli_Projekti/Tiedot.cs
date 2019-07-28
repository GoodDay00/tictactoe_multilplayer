using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoninPeli_Projekti
{
    class Tiedot
    {
        public static int id;
        public static string nimi;
        public static int voitot;
        public static int haviot;
        public static int tasapelit;

        public static List<string> huoneNimi = new List<string>();
        public static List<string> huoneTekijä = new List<string>();
        public static List<string> huonePeli = new List<string>();
        public static List<bool> huoneSalasanan = new List<bool>();

        public static int huoneId;
        public static string peliNimi;
        public static string peliPeli;
        public static int tarvitseeSalasanan;
        public static string peliPassword;
        public static int peliVoitot;
        public static int peliHaviot;
        public static int peliTasapelit;

        public static int pelaaja;


        public static void tyhjennäPelinTiedot()
        {
            huoneId = 0;
            peliVoitot = 0;
            peliHaviot = 0;
            peliTasapelit = 0;
        }
        public static void TallennaPeliTiedot(string nimi, string peli, int salasanaTarve, string salasana)
        {
            peliNimi = nimi;
            peliPeli = peli;
            tarvitseeSalasanan = salasanaTarve;
            peliPassword = salasana;
    }
    }
}
