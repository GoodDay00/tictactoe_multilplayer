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
    public partial class TeeUusiHuone : Form
    {
        int tarvitseeS;
        public TeeUusiHuone()
        {
            InitializeComponent();
        }

        private void tarvitsee_salasanan_Click(object sender, EventArgs e)
        {
            SalasanaTarkistus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu k = new Menu();
            k.Show();
            Close();
        }
        
        private void TeeUusiHuone_Load(object sender, EventArgs e)
        {
            //Salasanaa tarvitaan
            SalasanaTarkistus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tarkista onko tyhjiä kenttiä;
            if(huone_nimi.Text == "" || huoneMuoto.Text == "" || tarvitsee_salasanan.Checked && huone_salasana.Text == "")
            {
                MessageBox.Show("Täytä kaikki tiedot huoneellesi!");
            }
            else
            {
                Tiedot.TallennaPeliTiedot(sqlLause.PuhistaSQL(huone_nimi.Text), sqlLause.PuhistaSQL(huoneMuoto.Text), tarvitseeS, sqlLause.PuhistaSQL(huone_salasana.Text));
                sqlLause.query($"INSERT INTO `huoneet` ( `nimi`, `pelaaja1`, `pelaaja2`, `Peli`,`tarvitsee_salasanan` ,`password`) VALUES ('{Tiedot.peliNimi}', '{Tiedot.id}', '2', '{Tiedot.peliPeli}', '{Tiedot.tarvitseeSalasanan}','{Tiedot.peliPassword}'); ", "");
                //Vie huone odotukseen
                sqlLause.query($"SELECT * FROM huoneet WHERE `pelaaja1` ='{Tiedot.id}'", "HuoneId");
                Tiedot.pelaaja = 1;
                PeliOdotus k = new PeliOdotus();
                k.tekija = true;
                k.Show();
                Close();

            }
        }
        void SalasanaTarkistus()
        {
            if (tarvitsee_salasanan.Checked)
            {
                tarvitseeS = 1;
                huone_salasana_label.Enabled = true;
                huone_salasana.Enabled = true;
            }
            else
            {
                tarvitseeS = 0;
                huone_salasana_label.Enabled = false;
                huone_salasana.Enabled = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
