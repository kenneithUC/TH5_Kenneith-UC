using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4_kenneith_Wijaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Team> teamlist = new List<Team>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Team sampleteam1 = new Team("Bayern Munich", "Germany", "Munich");
            teamlist.Add(sampleteam1);
            Team sampleteam2 = new Team("Manchester United", "England", "Manchester");
            teamlist.Add(sampleteam2);
            Team sampleteam3 = new Team("Chelsea", "England", "London");
            teamlist.Add(sampleteam3);
            foreach (Team team in teamlist)
            {
                if (!comboBox1.Items.Contains(team.teamcountry))
                {
                    comboBox1.Items.Add(team.teamcountry);
                }
            }
            Player player1 = new Player("Manuel Neuer", "01", "GK");
            sampleteam1.player2.Add(player1);
            Player player2 = new Player("Dayot Upamecano", "02", "DF");
            sampleteam1.player2.Add(player2);
            Player player3 = new Player("Matthjis de Ligt", "04", "DF");
            sampleteam1.player2.Add(player3);
            Player player4 = new Player("Benjamin Pavard", "05", "DF");
            sampleteam1.player2.Add(player4);
            Player player5 = new Player("Joshua Kimmich", "06", "MF");
            sampleteam1.player2.Add(player5);
            Player player6 = new Player("Serge Gnarby", "07", "FW");
            sampleteam1.player2.Add(player6);
            Player player7 = new Player("Leon Goretzka", "08", "MF");
            sampleteam1.player2.Add(player7);
            Player player8 = new Player("Leroy Sane", "10", "FW");
            sampleteam1.player2.Add(player8);
            Player player9 = new Player("Paul Wanner", "14", "MF");
            sampleteam1.player2.Add(player9);
            Player player10 = new Player("Lucas Hernandez", "21", "DF");
            sampleteam1.player2.Add(player10);
            Player player11 = new Player("Thomas Muller", "25", "FW");
            sampleteam1.player2.Add(player11);

            Player playerr1 = new Player("David De Gea", "01", "GK");
            sampleteam2.player2.Add(playerr1);
            Player playerr2 = new Player("Victor Lindelof", "02", "DF");
            sampleteam2.player2.Add(playerr2);
            Player playerr3 = new Player("Phil Jones", "04", "DF");
            sampleteam2.player2.Add(playerr3);
            Player playerr4 = new Player("Harry Maguire", "05", "DF");
            sampleteam2.player2.Add(playerr4);
            Player playerr5 = new Player("Lisandro Martinez", "06", "DF");
            sampleteam2.player2.Add(playerr5);
            Player playerr6 = new Player("Bruno Fernandez", "08", "MF");
            sampleteam2.player2.Add(playerr6);
            Player playerr7 = new Player("Anthony Martial", "09", "FW");
            sampleteam2.player2.Add(playerr7);
            Player playerr8 = new Player("Marcus Rashford", "10", "FW");
            sampleteam2.player2.Add(playerr8);
            Player playerr9 = new Player("Tyrell Malacia", "12", "DF");
            sampleteam2.player2.Add(playerr9);
            Player playerr10 = new Player("Christian Eriksen", "14", "MF");
            sampleteam2.player2.Add(playerr10);
            Player playerr11 = new Player("Casemiro", "18", "MF");
            sampleteam2.player2.Add(playerr11);

            Player playerrr1 = new Player("Kepa Amizabalaga", "01", "GK");
            sampleteam3.player2.Add(playerrr1);
            Player playerrr2 = new Player("Benoit Badiashile", "04", "DF");
            sampleteam3.player2.Add(playerrr2);
            Player playerrr3 =new Player("Enzo Fernandez", "05", "MF");
            sampleteam3.player2.Add(playerrr3);
            Player playerrr4 = new Player("Thiago Silva", "06", "DF");
            sampleteam3.player2.Add(playerrr4);
            Player playerrr5 = new Player("N'Golo Kante", "07", "MF");
            sampleteam3.player2.Add(playerrr5);
            Player playerrr6 = new Player("Mateo Kovacic", "08", "MF");
            sampleteam3.player2.Add(playerrr6);
            Player playerrr7 = new Player("Pierre-Emerick Aubameyang", "09", "FW");
            sampleteam3.player2.Add(playerrr7);
            Player playerrr8 = new Player("Christian Pulisic", "10", "MF");
            sampleteam3.player2.Add(playerrr8);
            Player playerrr9 = new Player("Joao Felix", "11", "FW");
            sampleteam3.player2.Add(playerrr9);
            Player playerrr10 = new Player("Ruben Loftus-Cheek", "12", "MF");
            sampleteam3.player2.Add(playerrr10);
            Player playerrr11 = new Player("Raheem Sterling", "17", "MF");
            sampleteam3.player2.Add(playerrr11);
            
        }

        private void comboboxcountry()
        {
            foreach(Team country1 in teamlist)
            {
                if(!comboBox1.Items.Contains(country1.teamcountry))
                {
                    comboBox1.Items.Add(country1.teamcountry);
                }

            }
        }

        private void comboboxteam()
        {
            foreach(Team team in teamlist)
            {
                if(!comboBox2.Items.Contains(team.teamname)&& (team.teamcountry==comboBox1.Text))
                {
                    comboBox2.Items.Add(team.teamname);
                }
            }
        }

        private void addplayer()
        {
            Player player1 = new Player(textBox4.Text, textBox5.Text, comboBox3.Text);
            bool isi= true;
            foreach(Team team in teamlist)
            {
                if(comboBox2.Text==team.teamname)
                {
                    foreach(Player player in team.player2)
                    {
                        if (player1.playernumber == player.playernumber)
                        {
                            isi = false;
                            break;
                        }

                    }
                    if(isi==true)
                    {
                        team.player2.Add(player1);
                        listBox1.Items.Clear();
                        foreach (Team a in teamlist)
                        {
                            if (a.teamname == comboBox2.Text&&a.teamcountry==comboBox1.Text)
                            {
                                foreach (Player players in a.player2)
                                {
                                    listBox1.Items.Add("(" + players.playernumber + ") " + players.playername + ", " + players.playerposition);
                                    listBox1.Sorted = true;
                                }
                                break;
                            }
                        }

                    }
                    if (isi==false)
                    {
                        MessageBox.Show("Player with same number is found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("All fields needs to be filled", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Team Team = new Team(textBox1.Text, textBox2.Text, textBox3.Text);
                teamlist.Add(Team);
                comboboxcountry();
                comboboxteam();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "" || comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("All fields needs to be filled", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addplayer();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            listBox1.Items.Clear();
            comboboxteam();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Team team in teamlist)
            {
                if (team.teamname == comboBox2.Text&&team.teamcountry==comboBox1.Text)
                {
                    foreach (Player players in team.player2)
                    {
                        listBox1.Items.Add("(" + players.playernumber + ") " + players.playername + ", " + players.playerposition);
                        listBox1.Sorted = true;
                    }
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count<11)
            {
                MessageBox.Show("Players must be more than 11 or equal to 11", ",", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach(Team team in teamlist)
                {
                    if(team.teamname == comboBox2.Text)
                    {
                        foreach(Player players in team.player2)
                        {
                            if(listBox1.SelectedItem.ToString().Contains(players.playername))
                            {
                                team.player2.Remove(players);
                                break;
                            }
                        }
                    }
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }
    }
}
