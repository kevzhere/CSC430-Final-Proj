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
    public partial class SelfCheckOut : Form
    {
        public SelfCheckOut()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "select * from daily_room where reservation_number = '" + resNum.Text + "';";
            Object check = MySqlConnector.Connector.select(query).ExecuteScalar();
            if (check != null)
            {
                String checkin = "update daily_Room set reservation_number = null, occupied = false where occupied = true limit 1;";
                MySqlConnector.Connector.update(checkin);
                this.Hide();
                String roomNum = "select room_number from daily_room where reservation_number = " + resNum.Text + ";";
                Object room = MySqlConnector.Connector.select(roomNum).ExecuteScalar();
                MessageBox.Show("Thank you come again!");
                this.Hide();
            }
            else
                MessageBox.Show("Invalid reservation number.\n Please try again.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.Show();
        }
    }
}
