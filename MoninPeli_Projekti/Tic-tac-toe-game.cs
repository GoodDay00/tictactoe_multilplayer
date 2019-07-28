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
    public partial class Tic_tac_toe_game : Form
    {
        public int game_id;
        public static int voittajaPelaaja;
        public static List<string> allChoise = new List<string>();
        public static bool vuoro, tarkista, loppu, tarkistaVoitto, huoneOlemassa;

        private List<string> myChoices = new List<string>();
        private string allPos;
        private int[,] grid = new int[3, 3];
        
        public Tic_tac_toe_game()
        {
            InitializeComponent();
        }

        private void Tic_tac_toe_game_Load(object sender, EventArgs e)
        {
            aloitusSetup();
        }

        void aloitusSetup()
        {
            allChoise.Clear();
            myChoices.Clear();
            timer1.Start();
            for (int x = 0; x < 3; x++)
            {
                for (int i = 0; i < 3; i++)
                {
                    grid[x, i] = 0;
                }
            }
            huoneOlemassa = false;
            voittajaPelaaja = 0;
            loppu = false;
            tarkistaVoitto = false;
            if (Tiedot.pelaaja == 1)
            {
                sqlLause.query($"INSERT INTO tick_tac_toe_games(`peli_id`, `otetut_paikat`, `pelaaja1_vuoro`) VALUES('{game_id}', '', 1)", "");
                vuoro = true;
            }
            else
            {
                vuoro = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sqlLause.query($"SELECT * FROM tick_tac_toe_games WHERE peli_id={game_id}", "paikatPäivitä");
            if (tarkista)
            {
                if (Tiedot.pelaaja == 1)
                {
                    TarkistaPaikatPelaaja1();
                }
                else if (Tiedot.pelaaja == 2)
                {
                    TarkistaPaikatPelaaja2();
                }
                TarkistaVoittoRivi();
            }
            else if (loppu)
            {
                if (voittajaPelaaja == 1 && Tiedot.pelaaja == 1)
                {
                    Tiedot.peliVoitot++;
                    Tiedot.voitot++;
                    Console.WriteLine("Pelaajalle lisättypiste");
                }
                else if (voittajaPelaaja == 2 && Tiedot.pelaaja == 1)
                {
                    Tiedot.peliHaviot++;
                    Tiedot.haviot++;
                    Console.WriteLine("Pelaajalle häviö");
                }

                if (voittajaPelaaja == 2 && Tiedot.pelaaja == 2)
                {
                    Tiedot.peliVoitot++;
                    Tiedot.voitot++;
                    Console.WriteLine("Pelaajalle lisättypiste");
                }
                else if (voittajaPelaaja == 1 && Tiedot.pelaaja == 2)
                {
                    Tiedot.peliHaviot++;
                    Tiedot.haviot++;
                    Console.WriteLine("Pelaajalle häviö");
                }
                else if (voittajaPelaaja == 3)
                {
                    Tiedot.peliTasapelit++;
                    Tiedot.tasapelit++;
                    Console.WriteLine("Pelaajalle tasapeli");
                }
                sqlLause.query($"UPDATE `peli_tiedot` SET `voitot` = '{Tiedot.voitot}', `häviöt` = '{Tiedot.haviot}', `tasapelit` = '{Tiedot.tasapelit}' WHERE `peli_tiedot`.`id` = {Tiedot.id};", "");
                LaitaLoppuTekstit();
                Console.WriteLine("Peli loppu!");
                timer1.Stop();
            }

            if (vuoro && Tiedot.pelaaja == 1)
            {
                vuoroKuva.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
            }
            else if(!vuoro && Tiedot.pelaaja == 1)
            {
                vuoroKuva.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
            }

            if (!vuoro && Tiedot.pelaaja == 2)
            {
                vuoroKuva.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
            }
            else if (vuoro && Tiedot.pelaaja == 2)
            {
                vuoroKuva.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
            }
        }
        //PAIKAN KLIKKAAMINEN
        private void button9_Click(object sender, EventArgs e)
        {
            if (vuoro && !loppu)
            {
                string btn = (sender as Button).Tag.ToString();
                Console.WriteLine("painoit paikaa " + btn);
                if (allChoise.Contains(btn))
                {
                    Console.WriteLine("Paikka on jo otettu");
                }
                else
                {

                    allChoise.Add(btn + " ");
                    allPos = "";
                    myChoices.Add(btn);
                    foreach (string pos in allChoise)
                    {
                        allPos += pos + " ";
                    }
                    if (Tiedot.pelaaja == 1)
                    {
                        (sender as Button).BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;

                        TarkistaVoittoRivi();
                        sqlLause.query($"UPDATE tick_tac_toe_games SET otetut_paikat= '{allPos}',  pelaaja1_vuoro = 0 WHERE peli_id ={game_id}", "tallennaPaikka");
                        Console.WriteLine("Toisen pelaajan vuoro");
                    }
                    else
                    {
                        (sender as Button).BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;

                        TarkistaVoittoRivi();
                        sqlLause.query($"UPDATE tick_tac_toe_games SET otetut_paikat= '{allPos}',  pelaaja1_vuoro = 1 WHERE peli_id ={game_id}", "tallennaPaikka");
                        Console.WriteLine("Ensimmäisen pelaajan vuoro");
                    }
                    TarkistaVoittoRivi();
                    vuoro = false;
                }
            }
        }
        void TarkistaVoittoRivi()
        {
            int p1pisteet;
            int p2pisteet;
            for (int i = 0; i < 3; i++)
            {
                p1pisteet = 0;
                p2pisteet = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        p1pisteet++;

                    }
                    else if (grid[i, j] == 2)
                    {
                        p2pisteet++;
                    }
                    if (p1pisteet == 3)
                    {
                        PeliLoppu(1);
                        Console.WriteLine("Pelaaja 1 voitti");

                    }
                    else if (p2pisteet == 3)
                    {
                        PeliLoppu(2);
                        Console.WriteLine("Pelaaja 2 voitti");

                    }
                    else
                    {
                        TarkistaVoittoSivuttain();
                    }
                }
            }
        }

        void TarkistaVoittoSivuttain()
        {
            int countforP1 = 0;
            int countforP2 = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j && grid[j, i] == 1)
                    {
                        countforP1++;
                    }

                    else if (i == j && grid[j, i] == 2)
                    {
                        countforP2++;
                    }

                    if(grid[0,2] == 1 && grid[1,1] == 1 && grid[2,0] == 1) {
                        PeliLoppu(1);
                        Console.WriteLine("Pelaaja 1 voitti");
                    }
                    else if (grid[0, 2] == 2 && grid[1, 1] == 2 && grid[2, 0] == 2)
                    {
                        PeliLoppu(2);
                        Console.WriteLine("Pelaaja 2 voitti");
                    }

                    if (countforP1 == 3)
                    {
                        PeliLoppu(1);
                        Console.WriteLine("Pelaaja 1 voitti");
                    }
                    else if (countforP2 == 3)
                    {
                        PeliLoppu(2);
                        Console.WriteLine("Pelaaja 2 voitti");
                    }
                    else
                    {
                        TarkistaVoittoAllekkain();
                    }
                }
            }
        }
        void TarkistaVoittoAllekkain()
        {
            int countforP1 = 0;
            int countforP2 = 0;

            for (int i = 0; i < 3; i++)
            {
                countforP1 = 0;
                countforP2 = 0;
                for (int j = 0; j < 3; j++)
                {
                    if ( grid[j, i] == 1)
                    {
                        countforP1++;
                    }

                    if ( grid[j, i] == 2)
                    {
                        countforP2++;
                    }

                    if (countforP1 == 3)
                    {
                        PeliLoppu(1);
                        Console.WriteLine("Pelaaja 1 voitti");
                    }
                    else if (countforP2 == 3)
                    {
                        PeliLoppu(2);
                        Console.WriteLine("Pelaaja 2 voitti");
                    }
                    else
                    {
                        TarkistaTasaPeli();
                    }
                }
            }
        }
        void TarkistaTasaPeli()
        {
            int tasapeliPisteet = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] != 0)
                    {
                        tasapeliPisteet++;
                    }
                }
            }
            if(tasapeliPisteet == 9)
            {
                PeliLoppu(3);
                Console.WriteLine("Tasapeli!");
            }
        }

        void PeliLoppu(int voittaja)
        {
            sqlLause.query($"UPDATE tick_tac_toe_games SET voittaja ={voittaja} WHERE peli_id={Tiedot.huoneId}", "");
        }

        private void Rematch_Click(object sender, EventArgs e)
        {
            if (loppu && Tiedot.pelaaja == 1)
            {
                sqlLause.query($"DELETE FROM tick_tac_toe_games WHERE peli_id ={Tiedot.huoneId}", "");
                sqlLause.query($"DELETE FROM huoneet WHERE id ={Tiedot.huoneId}", "");
                sqlLause.query($"INSERT INTO `huoneet` ( `nimi`, `pelaaja1`, `pelaaja2`, `Peli`,`tarvitsee_salasanan` ,`password`) VALUES ('{Tiedot.peliNimi}', '{Tiedot.id}', '2', '{Tiedot.peliPeli}', '{Tiedot.tarvitseeSalasanan}','{Tiedot.peliPassword}'); ", "");
                sqlLause.query($"SELECT * FROM huoneet WHERE `pelaaja1` ='{Tiedot.id}'", "HuoneId");
                Tiedot.pelaaja = 1;
                PeliOdotus k = new PeliOdotus();
                k.tekija = true;
                k.Show();
                Close();
            }
            else if(loppu && Tiedot.pelaaja == 2)
            {
                sqlLause.query($"SELECT * FROM huoneet WHERE nimi ='{Tiedot.peliNimi}' AND pelaaja2 = 2", "rematch");
                if (huoneOlemassa)
                {
                    Tiedot.pelaaja = 2;
                    PeliOdotus k = new PeliOdotus();
                    k.tekija = false;
                    k.Show();
                    Close();
                }
                else{
                    MessageBox.Show("Toisen pelaajan pitää tehdä huone ensiksi!");

                }

               
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            
            Tiedot.tyhjennäPelinTiedot();
            Menu m = new Menu();
            m.Show();
            Close();
        }

        void LaitaLoppuTekstit()
        {
            Winner.Visible = true;
            Rematch.Visible = true;
            back.Visible = true;
            Score.Visible = true;
            label6.Visible = true;
            if (voittajaPelaaja == 3)
            {
                Winner.Text = $"Tasapeli!";
            }
            else
            {
                Winner.Text = $"Pelaaja {voittajaPelaaja.ToString()} voitti!";
            }
            Score.Text = $"{Tiedot.peliVoitot} - {Tiedot.peliTasapelit} - {Tiedot.peliHaviot}";

        }
        void TarkistaPaikatPelaaja1()
        {
            foreach (string pos in allChoise)
            {
                switch (pos)
                {
                    case "A1":
                        if (A1.BackgroundImage == null)
                            A1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[0, 0] = 2;
                        break;
                    case "A2":
                        if (A2.BackgroundImage == null)
                            A2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[0, 1] = 2;
                        break;
                    case "A3":
                        if (A3.BackgroundImage == null)
                            A3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[0, 2] = 2;
                        break;
                    case "B1":
                        if (B1.BackgroundImage == null)
                            B1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[1, 0] = 2;
                        break;
                    case "B2":
                        if (B2.BackgroundImage == null)
                            B2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[1, 1] = 2;
                        break;
                    case "B3":
                        if (B3.BackgroundImage == null)
                            B3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[1, 2] = 2;
                        break;
                    case "C1":
                        if (C1.BackgroundImage == null)
                            C1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[2, 0] = 2;
                        break;
                    case "C2":
                        if (C2.BackgroundImage == null)
                            C2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[2, 1] = 2;
                        break;
                    case "C3":
                        if (C3.BackgroundImage == null)
                            C3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[2, 2] = 2;
                        break;
                    default:
                        break;
                }
            }
            foreach (string pos in myChoices)
            {
                switch (pos)
                {
                    case "A1":
                        A1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[0, 0] = 1;
                        break;
                    case "A2":
                        A2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[0, 1] = 1;
                        break;
                    case "A3":
                        A3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[0, 2] = 1;
                        break;
                    case "B1":
                        B1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[1, 0] = 1;
                        break;
                    case "B2":
                        B2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[1, 1] = 1;
                        break;
                    case "B3":
                        B3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[1, 2] = 1;
                        break;
                    case "C1":
                        C1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[2, 0] = 1;
                        break;
                    case "C2":
                        C2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[2, 1] = 1;
                        break;
                    case "C3":
                        C3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[2, 2] = 1;
                        break;
                    default:
                        break;
                }
            }
            tarkista = false;
        }
        void TarkistaPaikatPelaaja2()
        {
            foreach (string pos in allChoise)
            {
                switch (pos)
                {
                    case "A1":
                        if (A1.BackgroundImage == null)
                            A1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[0, 0] = 1;
                        break;
                    case "A2":
                        if (A2.BackgroundImage == null)
                            A2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[0, 1] = 1;
                        break;
                    case "A3":
                        if (A3.BackgroundImage == null)
                            A3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[0, 2] = 1;
                        break;
                    case "B1":
                        if (B1.BackgroundImage == null)
                            B1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[1, 0] = 1;
                        break;
                    case "B2":
                        if (B2.BackgroundImage == null)
                            B2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[1, 1] = 1;
                        break;
                    case "B3":
                        if (B3.BackgroundImage == null)
                            B3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[1, 2] = 1;
                        break;
                    case "C1":
                        if (C1.BackgroundImage == null)
                            C1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[2, 0] = 1;
                        break;
                    case "C2":
                        if (C2.BackgroundImage == null)
                            C2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[2, 1] = 1;
                        break;
                    case "C3":
                        if (C3.BackgroundImage == null)
                            C3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.x_letter;
                        grid[2, 2] = 1;
                        break;
                    default:
                        break;
                }
            }
            foreach (string pos in myChoices)
            {
                switch (pos)
                {
                    case "A1":
                        A1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[0, 0] = 2;
                        break;
                    case "A2":
                        A2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[0, 1] = 2;
                        break;
                    case "A3":
                        A3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[0, 2] = 2;
                        break;
                    case "B1":
                        B1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[1, 0] = 2;
                        break;
                    case "B2":
                        B2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[1, 1] = 2;
                        break;
                    case "B3":
                        B3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[1, 2] = 2;
                        break;
                    case "C1":
                        C1.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[2, 0] = 2;
                        break;
                    case "C2":
                        C2.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[2, 1] = 2;
                        break;
                    case "C3":
                        C3.BackgroundImage = MoninPeli_Projekti.Properties.Resources.icon;
                        grid[2, 2] = 2;
                        break;
                    default:
                        break;
                }
            }
            tarkista = false;
        }
    }
}
