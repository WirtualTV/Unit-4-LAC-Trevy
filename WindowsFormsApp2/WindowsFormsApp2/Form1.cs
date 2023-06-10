using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public struct TeamScore
{
    public string TeamName;
    public int Score;

};

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        List<string> Player = new List<string>();
        List<string> Team = new List<string>();
        
        static List<TeamScore> TeamScoreList;


        void Showdata()
        {
            lstPlayer.Items.Clear();
            for (int counter  = 0; counter<Player.Count; counter++)
            {
                lstPlayer.Items.Add(Player[counter]);
            }
            lstPlayer.Show();

        }


        void ShowTeamdata()
        {
            lstTeam.Items.Clear();
            cboTeam.Items.Clear();
            for (int counter = 0; counter < Team.Count; counter++)
            {
                lstTeam.Items.Add(Team[counter]);
                cboTeam.Items.Add(Team[counter]);
            }
            lstTeam.Show();
            
            

        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
                MessageBox.Show("Please enter a player name");
            else
            {
                Player.Add(txtPlayerName.Text);
                txtPlayerName.Clear();
                Showdata();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Showdata();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTeam.Text == "")
                MessageBox.Show("Please enter a valid Team name");
            else
            {
                Team.Add(txtTeam.Text);
                txtTeam.Clear();
                ShowTeamdata();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           TeamScoreList = new List<TeamScore>();
            TeamScore newScore = new TeamScore();
            newScore.TeamName = cboTeam.SelectedItem.ToString();
            newScore.Score = Convert.ToInt32(txtTeamScore.Text);
            TeamScoreList.Add(newScore);
            //lstTeamScore.Items.Clear();
            for (int counter = 0; counter < TeamScoreList.Count; counter++)
            {
                lstTeamScore.Items.Add(TeamScoreList[counter].TeamName+": "+ TeamScoreList[counter].Score);
            }
            lstTeamScore.Show();
                       
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            //textbox clear mode//
            comboBox1.Items.Clear();

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please enter a event name");
            }
            else
            {

            }
        }

        private void Event_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTeamScore.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void lstPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
