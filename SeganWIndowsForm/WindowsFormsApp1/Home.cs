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
    public partial class Home : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        NpgsqlDataReader dr;
        DataTable dt;
        public string userId_var, username_var, role_var;
        public Home(string userId, string username, string role)
        {
            InitializeComponent();
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
            userId_var = userId;
            username_var = username;
            role_var = role;

            if (role_var == "2")
            {
                drugpbhome.Hide();
            }
            
            lblUsername.Text = username_var;
            lblWelcome.Text = "Welcome " + username_var;

            dataFill();
            upcoming();
        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sched sched = new Sched(userId_var, username_var, role_var);
            sched.Show();
        }

        private void upcoming()
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format("SELECT consume_date, actv_obat_id FROM actv_obat WHERE actv_user_id = '{0}' AND consume_date = '{1}'", userId_var, DateTime.Now.ToString("yyyy/MM/dd"));

                dt = new DataTable();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);

                    lblTanggal.Text = dt.Rows[0].ItemArray[0].ToString();
                    lblActv.Text = dt.Rows[0].ItemArray[1].ToString();
                }
                else
                {
                    lblTanggal.Text = "";
                    lblActv.Text = "No medication schedule";
                }

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Search!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataFill()
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format("SELECT * FROM actv_obat WHERE actv_user_id = '{0}'", userId_var);

                dgvActive.DataSource = null;
                dt = new DataTable();
                dr = cmd.ExecuteReader();

                dt.Load(dr);

                dgvActive.DataSource = dt;

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Search!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drugpbhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputObat inputdrag = new InputObat(userId_var, username_var, role_var);
            inputdrag.Show();
        }

        private void closepbhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
