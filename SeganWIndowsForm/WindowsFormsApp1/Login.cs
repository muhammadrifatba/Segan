using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        NpgsqlConnection con;
        NpgsqlCommand cmd;
        public Login()
        {
            InitializeComponent();
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.Show();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text;
                string password = tbPass.Text;

                if (username == "" || password == "")
                {
                    MessageBox.Show("Please input Username and Password");
                    return;
                }

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                    "SELECT id, name, role FROM users WHERE name = '{0}' AND password = '{1}';", username, password);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                

                if (dr.HasRows)
                {
                    DataTable dtUser = new DataTable();
                    dtUser.Load(dr);
                    this.Hide();
                    //Sched sched = new Sched(dtUser.Rows[0].ItemArray[0].ToString(), dtUser.Rows[0].ItemArray[1].ToString(), dtUser.Rows[0].ItemArray[2].ToString());
                    Home home = new Home(dtUser.Rows[0].ItemArray[0].ToString(), dtUser.Rows[0].ItemArray[1].ToString(), dtUser.Rows[0].ItemArray[2].ToString());

                    con.Close();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password! Login again!");
                    con.Close();
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Insert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
