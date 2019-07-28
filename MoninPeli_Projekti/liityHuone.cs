using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MoninPeli_Projekti
{
    public partial class liityHuone : Form
    {
        public static bool salasanaTarvitsee, tarkistettu;
        public static string pass;
        public static DataTable dset = new DataTable();

        public string a;
        public liityHuone()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void liityHuone_Load(object sender, EventArgs e)
        {

            UpdateHuoneet();
        }

        void UpdateHuoneet()
        {
            using (MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=demo;password=demo;database=uusi_moninpeli;"))
            using (MySqlCommand cmd = connection.CreateCommand())
                try
                {
                    connection.Open();
                    // KORJAA PLS TY
                    cmd.CommandText = "SELECT huoneet.nimi, käyttäjä.Name, huoneet.peli, huoneet.tarvitsee_salasanan FROM huoneet JOIN käyttäjä ON huoneet.pelaaja1 = käyttäjä.id WHERE huoneet.pelaaja2 = 2";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adap.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                catch
                {

                }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            UpdateHuoneet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PELIIN LIITYMINEN
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                a = Convert.ToString(selectedRow.Cells["Name"].Value);
                sqlLause.query($"SELECT * FROM huoneet WHERE nimi ='{a}' AND tarvitsee_salasanan=1", "salasanaTarvitsee");
                if (salasanaTarvitsee)
                {
                    SalasanaTarkastus s = new SalasanaTarkastus();
                    s.ShowDialog();
                    if(pass != "")
                    {
                        
                        sqlLause.query($"SELECT * FROM huoneet WHERE nimi ='{a}' AND password ='{sqlLause.PuhistaSQL(pass)}'", "salasanaTarkastastus");
                        if (tarkistettu)
                        {
                            sqlLause.query($"SELECT * FROM huoneet WHERE nimi ='{a}'", "liityHuone");
                            Tiedot.pelaaja = 2;
                            Close();
                            PeliOdotus p = new PeliOdotus();
                            p.tekija = false;
                            p.Show();
                        }
                        else
                        {
                            MessageBox.Show("Salasana on väärin!");
                        }
                    }
                }
                else
                {
                    sqlLause.query($"SELECT * FROM huoneet WHERE nimi ='{a}'", "liityHuone");
                    Console.WriteLine(a);
                    Tiedot.pelaaja = 2;
                    PeliOdotus p = new PeliOdotus();
                    p.tekija = false;
                    p.Show();
                    Close();
                }
               
            }
        }
        
    }
}
