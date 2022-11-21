using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddJadwalObat : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        private NpgsqlDataReader dr;
        private DataTable dtObat;

        private string userId_var;
        private string actv_id;

        public AddJadwalObat(string userId)
        {
            InitializeComponent();
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
            userId_var = userId;
            obatSeeding();
        }

        public AddJadwalObat(string obat,string dosis,string interval,string tanggal, string nama, string actvId)
        {
            InitializeComponent();
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
            actv_id = actvId;
            obatSeeding();

            tbName.Text = nama;
            cbObat.Text = obat;
            tbDosis.Text = dosis;
            tbInterval.Text = interval;
            tbTanggal.Text = tanggal;
            
            con.Close();
        }

        private void obatSeeding()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = string.Format(
                "SELECT obat_id, obat_nama FROM obat;");


            dr = cmd.ExecuteReader();

            dtObat = new DataTable();

            dtObat.Load(dr);

            cbObat.DisplayMember = "Text";
            cbObat.ValueMember = "Value";

            for (int i =0; i < dtObat.Rows.Count; i++)
            {
                string obat_id = dtObat.Rows[i].ItemArray[0].ToString();
                string obat_name = dtObat.Rows[i].ItemArray[1].ToString();
                cbObat.Items.Add(new { Text = obat_name, Value = obat_id });
            }
        }


        private void submitDrugAct_Click(object sender, EventArgs e)
        {
            string nama = tbName.Text;
            string obat = cbObat.Text;
            string dosis = tbDosis.Text;
            string interval = tbInterval.Text;
            string tanggal = tbTanggal.Text;
            try
            {
                if (nama == "" || obat == "" || dosis == "" || interval == "" || tanggal == "")
                {
                    MessageBox.Show("Silahkan isi semua data");
                    return;
                }
                
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                    "INSERT INTO actv_obat (actv_name, actv_obat_id, obat_dosage, obat_interval, consume_date, actv_user_id) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", nama, obat, dosis, interval, tanggal, userId_var);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil Input Aktivitas Obat");

                con.Close();
                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Insert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateDrugAct_Click(object sender, EventArgs e)
        {
            string nama = tbName.Text;
            string obat = cbObat.Text;
            string dosis = tbDosis.Text;
            string interval = tbInterval.Text;
            string tanggal = tbTanggal.Text;

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                     "UPDATE actv_obat SET actv_name = '{0}', actv_obat_id = '{1}', obat_dosage = '{2}', obat_interval = '{3}', consume_date = '{4}' WHERE actv_id = '{5}'",
                     nama, obat, dosis, interval, tanggal, actv_id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil Edit Aktivitas Obat");
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Update!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddJadwalObat_Load(object sender, EventArgs e)
        {
            tbTanggal.Text = Sched.static_year + "/" +  Sched.static_month + "/" +  UserControlDays.static_day ;
        }

        private void deleteDrugAct_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                     "DELETE FROM actv_obat WHERE actv_id = '{0}'", actv_id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil Hapus Obat");
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Delete!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
