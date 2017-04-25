using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class MainPage : Form
    {
        public static MakeReservation mkRes = new MakeReservation();
        public static MyReservation myRes = new MyReservation();
        public static CheckIn ckIn = new CheckIn();
        public static SelfCheckOut ckOut = new SelfCheckOut();

        public MainPage()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mkRes.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            String query = "select * from reservation where username = '" + UserLogin.userName + "';";
            DataTable table = new DataTable();
            MySqlConnector.Connector.table(query).Fill(table);
            myRes.resTable.DataSource = table;
            myRes.Show();
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            ckIn.ShowDialog();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            ckOut.ShowDialog();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin user = new UserLogin();
            user.Show(); 
        }
    }
}
