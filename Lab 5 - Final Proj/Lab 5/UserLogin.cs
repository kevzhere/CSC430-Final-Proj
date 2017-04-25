using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace Lab_5
{
    public partial class UserLogin : Form
    {
       public static String userName;
       public static String passWord;
        public UserLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Connector.login(txtUser.Text, txtPas.Text) != null)
            {
                userName = txtUser.Text;
                passWord = txtPas.Text;
                MessageBox.Show("Welcome " + txtUser.Text + "!");
                this.Hide();
                MainPage main = new MainPage();
                main.Show();
            }
            else
                MessageBox.Show("Please Try Again");
        }

        private void btnNewAct_Click(object sender, EventArgs e)
        {

        }
    }
}
