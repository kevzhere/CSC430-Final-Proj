using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_5;
namespace Lab_5
{
    public partial class MakeReservation : Form
    {
        MainPage main = new MainPage();
        public MakeReservation()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BackToMp_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
           // try {
                checkIn.Format = DateTimePickerFormat.Custom;
                checkIn.CustomFormat = "yyyy-MM-dd";
                checkOut.Format = DateTimePickerFormat.Custom;
                checkOut.CustomFormat = "yyyy-MM-dd";

            if (checkOut.Value > checkIn.Value)
            {
                String qry = "select * from room_left where date >= '" + checkIn.Text + "' and date <= '" + checkOut.Text + "' and num_left  = '0';";
                Object value = MySqlConnector.Connector.query(qry).ExecuteScalar();
                if (value == null)
                {
                    String update = "update room_left set num_left = num_left -1 where date >= '" + checkIn.Text + "' and date < '" + checkOut.Text + "';";
                    MySqlConnector.Connector.update(update);
                    Random random = new Random();
                    int resNum = random.Next(10000, 99999);
                    String unique = "select * from reservation where Reservation_number = " + resNum + ";";
                    Object uniq = MySqlConnector.Connector.query(unique).ExecuteScalar();
                    if (value == null)
                    {
                        String insert = "insert into reservation value(" + resNum + ", '" + checkIn.Text + "', '" + checkOut.Text + "', '" + UserLogin.userName + "')";
                        MySqlConnector.Connector.update(insert);
                        MessageBox.Show("Thank you for your reservation!\n Your reservation number is: " + resNum.ToString());
                        this.Hide();
                        main.Show();
                    }
                }
                else
                {
                    DataTable data = new DataTable();
                    MySqlConnector.Connector.table(qry).Fill(data);
                    reservationTable.DataSource = data;
                    MessageBox.Show("No room available for the displayed date.");

                }

            }
            else
                MessageBox.Show("Error with selected date");
                

               // } catch (Exception)
            //{
                //MessageBox.Show("Please Try Again.");
            //}
        }

        private void checkIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
