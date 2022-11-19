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

    // TODO : Know Who is The Current USER
{
    public partial class AddJadwalObat : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        private NpgsqlDataReader dr;
        private DataTable dtObat;
        DataTable activeForm;

        public AddJadwalObat(string useri_id)
        {
            InitializeComponent();
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
            obatSeeding();
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
            string obat = ObatDropdown.Text;
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

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                    "INSERT INTO actv_obat (actv_name, actv_obat_id, obat_dosage, obat_interval, consume_date, actv_user_id) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", nama, obat, dosis, interval, tanggal);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil Input Aktivitas Obat");
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Insert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateDrugAct_Click(object sender, EventArgs e)
        {
            string nama = tbName.Text;
            string obat = ObatDropdown.Text;
            string dosis = tbDosis.Text;
            string interval = tbInterval.Text;
            string tanggal = tbTanggal.Text;

            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                     "UPDATE actv_obat SET actv_name = '{0}', actv_obat_id = '{1}', obat_dosage = '{2}', obat_interval = '{3}', consume_date = '{4}' WHERE actv_id = '{5}'",
                     nama, obat, dosis, interval, tanggal);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil Edit Aktivitas Obat");
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Update!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteDrugAct_Click(object sender, EventArgs e)
        {
            string nama = tbName.Text;
            string obat = ObatDropdown.Text;
            string dosis = tbDosis.Text;
            string interval = tbInterval.Text;
            string tanggal = tbTanggal.Text;
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                     "DELETE FROM actv_obat WHERE actv_id = '{0}'", nama);

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
