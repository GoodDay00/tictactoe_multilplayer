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
    public partial class Form1 : Form
    {
        public static bool voiKirjatua;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uusi_käyttäjä k = new Uusi_käyttäjä();
            k.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nimi = sqlLause.PuhistaSQL(name.Text.ToLower());
            string salasana = sqlLause.PuhistaSQL(password.Text);
            sqlLause.query($"SELECT * FROM `käyttäjä` WHERE `Name` = '{nimi}' AND `password` = '{salasana}'", "login");
            if (voiKirjatua)
            {
                sqlLause.query($"SELECT * FROM `käyttäjä` WHERE `Name` = '{nimi}'", "tiedot");
                Menu m = new Menu();
                m.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Käyttäjänimi tai salasana on väärin!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tiedot.id = 0;
            Tiedot.nimi = "";
            Tiedot.tasapelit = 0;
            Tiedot.voitot = 0;
            Tiedot.haviot = 0;
        }
    }
}
