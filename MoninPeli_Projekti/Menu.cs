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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            name.Text = Tiedot.nimi;
            sqlLause.query($"SELECT * FROM peli_tiedot WHERE `pelaaja_id` = '{Tiedot.id}' ", "haeTiedot");
            wins.Text = Tiedot.voitot.ToString();
            haviot.Text = Tiedot.haviot.ToString();
            tasapelit.Text = Tiedot.tasapelit.ToString();
            Tiedot.tyhjennäPelinTiedot();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tyhjennäTiedot();
            Form1 k = new Form1();
            k.Show();
            Close();
        }

        void tyhjennäTiedot()
        {
            Tiedot.id = 0;
            Tiedot.nimi = "";
            Tiedot.tasapelit = 0;
            Tiedot.voitot = 0;
            Tiedot.haviot = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liityHuone k = new liityHuone();
            k.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeeUusiHuone k = new TeeUusiHuone();
            k.Show();
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
