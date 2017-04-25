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
    public partial class CheckIn : Form
    {
        public CheckIn()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "select * from reservation where reservation_number = '" + resNum.Text + "';";
            Object check = MySqlConnector.Connector.select(query).ExecuteScalar();
            if (check != null)
            {
                String checkin = "update daily_Room set reservation_number = " + resNum.Text + ", occupied = true where occupied = false limit 1;";
                MySqlConnector.Connector.update(checkin);
                this.Hide();
                String roomNum = "select room_number from daily_room where reservation_number = " + resNum.Text+";";
                Object room = MySqlConnector.Connector.select(roomNum).ExecuteScalar();
                MessageBox.Show("Thank you for checking in.\n Your room number is: " + room);
            }
            else
                MessageBox.Show("Invalid reservation number.\n Please try again.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.Show();
        }
    }
}
