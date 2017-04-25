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
    public partial class CancelReservation : Form
    {
        public CancelReservation()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "select * from reservation where username = '" + UserLogin.userName + "';";
            DataTable table = new DataTable();
            MySqlConnector.Connector.table(query).Fill(table);
            MainPage.myRes.resTable.DataSource = table;
            String qry = "delete from reservation where reservation_number = '" + resNum.Text + "';";
            try
            {
                MySqlConnector.Connector.update(qry);
                this.Hide();
            }catch (Exception)
            {
                MessageBox.Show("Error with reservation number.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.Show();
        }
    }
}
