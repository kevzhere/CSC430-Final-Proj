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
    public partial class ServerLogin : Form
    {
        public ServerLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Connector.con(textBoxServer.Text, textBoxUser.Text, textBoxPassword.Text, textBoxData.Text);
                Connector.con("localhost", "root", "2181989", "hotel");
                MessageBox.Show("Connected to Server");
                this.Hide();
                UserLogin log = new UserLogin();
                log.Show();

            }catch (Exception)
            {
                MessageBox.Show("Error Connecting To Database.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
