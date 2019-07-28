using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MoninPeli_Projekti
{
    public partial class PeliOdotus : Form
    {
        public static bool voiAloittaa;
        public bool tekija;
        public static string toisenPelaajan_nimi;
        public static int toisenPelaajan_voitot, toisenPelaajan_haviot, toisenPelaajan_tasapelit;
        public PeliOdotus()
        {
            InitializeComponent();
            
        }

        private void PeliOdotus_Load(object sender, EventArgs e)
        {
            voiAloittaa = false;
            sqlLause.query($"SELECT * FROM huoneet WHERE id={Tiedot.huoneId}", "huoneStart");

            toisenPelaajan_voitot = 0;
            toisenPelaajan_haviot = 0;
            toisenPelaajan_tasapelit = 0;
            timer1.Start();
            PistaTekstit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tic_tac_toe_game t = new Tic_tac_toe_game();
            t.game_id = Tiedot.huoneId;
            t.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlLause.query($"DELETE FROM huoneet WHERE id={Tiedot.huoneId}","");
            Menu f = new Menu();
            f.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sqlLause.query($"SELECT * FROM huoneet WHERE id={Tiedot.huoneId}", "odotus");
            PistaTekstit();
            if (voiAloittaa)
            {
                aloitaNappi.Visible = true;
            }

        }

        void PistaTekstit()
        {
            if (tekija)
            {
                pelaaja2_wins.Text = toisenPelaajan_voitot.ToString();
                pelaaja2_haviot.Text = toisenPelaajan_haviot.ToString();
                pelaaja2_tasapelit.Text = toisenPelaajan_tasapelit.ToString();

                pelaaja1_wins.Text = Tiedot.voitot.ToString();
                pelaaja1_haviot.Text = Tiedot.haviot.ToString();
                pelaaja1_tasapelit.Text = Tiedot.tasapelit.ToString();
            }
            else
            {
                pelaaja1_wins.Text = toisenPelaajan_voitot.ToString();
                pelaaja1_haviot.Text = toisenPelaajan_haviot.ToString();
                pelaaja1_tasapelit.Text = toisenPelaajan_tasapelit.ToString();

                pelaaja2_wins.Text = Tiedot.voitot.ToString();
                pelaaja2_haviot.Text = Tiedot.haviot.ToString();
                pelaaja2_tasapelit.Text = Tiedot.tasapelit.ToString();
            }
        }
    }
}
