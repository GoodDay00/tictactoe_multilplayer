using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MoninPeli_Projekti
{
    class sqlLause
    {
        static MySqlDataAdapter sqlAdapter;
        public static void query(string lause, string muoto)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=demo;password=demo;database=uusi_moninpeli;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(lause, databaseConnection);
            sqlAdapter = new MySqlDataAdapter(lause, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            // Let's do it !
            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    TarkistaLöytyneet(muoto, reader);
                }
                else
                {
                    TarkistaEiLöytyneet(muoto, reader);
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                Console.WriteLine("SQL vika: " + ex.Message);
            }
        }
        public static string PuhistaSQL(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Ä') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public static void TarkistaLöytyneet(string muoto, MySqlDataReader reader)
        {
            switch (muoto)
            {
                case "uusi":
                    Uusi_käyttäjä.voiTehda = false;
                    break;
                case "tiedot":
                    while (reader.Read())
                    {
                        Tiedot.id = reader.GetInt32(0);
                        Tiedot.nimi = reader.GetString(1);
                    }
                    break;
                case "haeTiedot":
                    while (reader.Read())
                    {
                        Tiedot.voitot = reader.GetInt32(2);
                        Tiedot.haviot = reader.GetInt32(3);
                        Tiedot.tasapelit = reader.GetInt32(4);
                        Console.WriteLine("Tiedot otettu");
                    }
                    break;

                case "login":
                    Form1.voiKirjatua = true;
                    break;

                case "huoneetEtsi":
                    sqlAdapter.Fill(liityHuone.dset);
                    break;

                case "HuoneId":
                    while (reader.Read())
                    {
                        Tiedot.huoneId = reader.GetInt32(0);
                    }
                    break;
                case "liityHuone":
                    while (reader.Read())
                    {
                        Tiedot.huoneId = reader.GetInt32(0);
                        Tiedot.peliNimi = reader.GetString(1);
                        Tiedot.tarvitseeSalasanan = reader.GetInt16(5);
                        sqlLause.query($"UPDATE huoneet SET pelaaja2 = {Tiedot.id} WHERE id = {reader.GetInt32(0)}", "");
                    }


                    break;
                case "huoneEtsi":

                    if (reader.GetInt32(2) != Tiedot.id)
                    {
                        sqlLause.query($"UPDATE huoneet SET pelaaja2={Tiedot.id}", "");

                    }
                    break;

                case "odotus":
                    while (reader.Read())
                    {
                        if (reader.GetInt32(3) != 2 && reader.GetInt32(3) != Tiedot.id)
                        {
                            sqlLause.query($"SELECT * FROM peli_tiedot WHERE pelaaja_id={reader.GetInt32(3)}", "toisenPelaajanTiedot");
                        }
                        else if (reader.GetInt32(3) != 2 && reader.GetInt32(3) == Tiedot.id)
                        {
                            sqlLause.query($"SELECT * FROM peli_tiedot WHERE pelaaja_id={reader.GetInt32(2)}", "toisenPelaajanTiedot");
                        }
                    }
                    break;

                case "toisenPelaajanTiedot":
                    while (reader.Read())
                    {
                        PeliOdotus.toisenPelaajan_voitot = reader.GetInt32(2);
                        PeliOdotus.toisenPelaajan_haviot = reader.GetInt32(3);
                        PeliOdotus.toisenPelaajan_tasapelit = reader.GetInt32(4);
                        PeliOdotus.voiAloittaa = true;
                    }
                    break;

                case "salasanaTarvitsee":
                    liityHuone.salasanaTarvitsee = true;
                    break;
                case "salasanaTarkastastus":
                    liityHuone.tarkistettu = true;
                    break;
                case "paikatPäivitä":
                    while (reader.Read())
                    {
                        if (Tiedot.pelaaja == 1 && reader.GetInt32(3) == 1 && !Tic_tac_toe_game.vuoro)
                        {
                            string[] posis = reader.GetString(2).Split(null);
                            Tic_tac_toe_game.allChoise.Clear();
                            foreach (string pos in posis)
                            {
                                Tic_tac_toe_game.allChoise.Add(pos);
                            }
                            Tic_tac_toe_game.tarkista = true;
                            Tic_tac_toe_game.vuoro = true;
                        }
                        else if (Tiedot.pelaaja == 2 && reader.GetInt32(3) == 0 && !Tic_tac_toe_game.vuoro)
                        {
                            string[] posis = reader.GetString(2).Split(null);
                            Tic_tac_toe_game.allChoise.Clear();
                            foreach (string pos in posis)
                            {
                                Tic_tac_toe_game.allChoise.Add(pos);
                            }
                            Tic_tac_toe_game.tarkista = true;
                            Tic_tac_toe_game.vuoro = true;
                        }
                        if (reader.GetInt16(4) != 0)
                        {
                            Tic_tac_toe_game.voittajaPelaaja = reader.GetInt16(4);
                            Tic_tac_toe_game.loppu = true;
                        }
                    }
                    break;

                case "rematch":
                    Tic_tac_toe_game.huoneOlemassa = true;
                    while (reader.Read())
                    {
                        Tiedot.huoneId = reader.GetInt32(0);
                        Tiedot.peliNimi = reader.GetString(1);
                        sqlLause.query($"UPDATE huoneet SET pelaaja2 = {Tiedot.id} WHERE id = {reader.GetInt32(0)}", "");
                    }
                    
                    break;
                default:
                    break;
            }
        }
        public static void TarkistaEiLöytyneet(string muoto, MySqlDataReader reader)
        {
            switch (muoto)
            {
                case "uusi":
                    Uusi_käyttäjä.voiTehda = true;
                    break;
                case "haeTiedot":
                    Console.WriteLine("Tehdään tiedot");
                    query($"INSERT INTO `peli_tiedot` (`pelaaja_id`, `voitot`, `häviöt`, `tasapelit`) VALUES('{Tiedot.id}', '0', '0', '0')", "");
                    Tiedot.voitot = 0;
                    Tiedot.haviot = 0;
                    Tiedot.tasapelit = 0;
                    break;
                case "login":
                    Form1.voiKirjatua = false;
                    break;
                case "salasanaTarvitsee":
                    liityHuone.salasanaTarvitsee = false;
                    break;
                case "salasanaTarkastastus":
                    liityHuone.tarkistettu = false;
                    break;
                case "tallennaPaikka":

                    break;
                case "rematch":
                    Tic_tac_toe_game.huoneOlemassa = false;
                    break;
                default:
                    Console.WriteLine("Ei ole");
                    break;
            }
        }
    }
}
