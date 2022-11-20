using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControlDays : UserControl
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        public static string static_day;
        private NpgsqlDataReader dr;
        private DataTable dtAtcObat;
        private string userId_var;
        private int myDays;

        public UserControlDays(string userId, int daynow)
        {
            InitializeComponent();
            
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
            userId_var = userId;
            myDays = daynow;

            displayActObat();
        }
        public void days(int numday)
        {
            labelday.Text= numday+"";   
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = labelday.Text;
            AddJadwalObat addJadwalObat = new AddJadwalObat(userId_var);
            addJadwalObat.Show();
        }

        private void displayActObat()
        {
            con.Open();
            cmd.Connection = con;
            string currentDate = Sched.static_year + "-" + Sched.static_month + "-" + myDays.ToString();
            cmd.CommandText = string.Format(
                "SELECT * FROM actv_obat WHERE actv_user_id = '{0}' AND consume_date = '{1}';", userId_var, currentDate);
            dr = cmd.ExecuteReader();
            dtAtcObat = new DataTable();
            dtAtcObat.Load(dr);

            for (int i = 0; i < dtAtcObat.Rows.Count; i++)
            {
                Button button = new Button();
                button.Text = dtAtcObat.Rows[i].ItemArray[6].ToString();
                //MessageBox.Show(dtAtcObat.Rows[i].ItemArray[0].ToString());
                Controller controller = new Controller(userId_var);
                button.Click += new EventHandler(controller.button_Clicked);
                button.Font = new Font("Segoe UI", 6);
                button.Name = dtAtcObat.Rows[i].ItemArray[0].ToString();
                button.Dock = DockStyle.Bottom;
                //button.Margin = new Padding(5,5,5,5);
                button.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(button);
            }
            con.Close();
        }

    }
}
