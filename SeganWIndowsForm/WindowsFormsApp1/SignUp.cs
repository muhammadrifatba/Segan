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
    public partial class SignUp : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        public SignUp()
        {
            InitializeComponent();
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text;
                string password = tbPass.Text;

                if (username == "" || password=="")
                {
                    MessageBox.Show("Please input Username and Password");
                    return;
                }

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                    "INSERT INTO users (name, password) VALUES ('{0}','{1}');", username, password);
                cmd.ExecuteNonQuery();

                MessageBox.Show("SignUp Berhasil");
                con.Close();

                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Insert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
