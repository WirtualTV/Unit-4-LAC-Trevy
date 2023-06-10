using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string user, pass;
            user = textUser.Text;
            pass = textPass.Text;
            if (user == "trevy" && pass == "trevy")
            {
                MessageBox.Show("successful");
                Form1 frm1 = new Form1(); // Form1 is the form you need to nagigate to

                frm1.Show();
            }
            else
            {
                MessageBox.Show("Unsucessful Try again!");
            }
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
