using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MoninPeli_Projekti
{
    public partial class Uusi_käyttäjä : Form
    {
        public static bool voiTehda;
        public Uusi_käyttäjä()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(password_conf.Text != password.Text)
            {
                MessageBox.Show("Passwords dosen't match!");
            }
            else
            {
                sqlLause.query($"SELECT * FROM `käyttäjä` WHERE `Name` = '{sqlLause.PuhistaSQL(name.Text.ToLower())}' OR `Email` = '{sqlLause.PuhistaSQL(email.Text.ToLower())}'", "uusi");
                if (voiTehda)
                {
                    
                    sqlLause.query($"INSERT INTO `Käyttäjä` (`Name`, `Email`, `Password`) VALUES ( '{sqlLause.PuhistaSQL(name.Text.ToLower())}', '{sqlLause.PuhistaSQL(email.Text.ToLower())}', '{sqlLause.PuhistaSQL(password.Text)}')", "Tallenna");
                    
                    MessageBox.Show("Uusi käyttäjä luotu!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Käyttäjä tai sähköposti on jo olemassa!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
