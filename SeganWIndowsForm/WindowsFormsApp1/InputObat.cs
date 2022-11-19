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
    public partial class InputObat : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        DataGridViewRow dgRow;
        NpgsqlDataReader dr;
        DataTable dt;

        public InputObat()
        {
            InitializeComponent();
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
        }

        private void InputPBtoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hom = new Home();
            hom.Show();
        }

        private void InputPBtoSched_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule sche = new Schedule();
            sche.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Input Obat
        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tbNamaObat.Text;
                string type = tbTipeObat.Text;
                string desc = tbDescObat.Text;
                string gambar = tbImgObat.Text;

                if(nama == "" || type == "" || desc == "" || gambar == "")
                {
                    MessageBox.Show("Silahkan isi semua data");
                    return;
                }

                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                    "INSERT INTO obat (obat_nama, obat_type, obat_desc, obat_image) VALUES ('{0}','{1}','{2}','{3}');", nama, type, desc, gambar);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil Input Obat");
                con.Close();
                btnSearch.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Insert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void InputObat_Load(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        // Populate Obat
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                        "SELECT * FROM obat");// WHERE act_user_id = '{0}'", user);

                dgvObat.DataSource = null;
                dt = new DataTable();
                dr = cmd.ExecuteReader();

                dt.Load(dr);
                dgvObat.DataSource = dt;
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Search!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgRow == null)
            {
                MessageBox.Show("Pilih baris yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = string.Format(
                     "UPDATE obat SET obat_nama = '{0}', obat_type = '{1}', obat_desc = '{2}' WHERE obat_id = '{3}'",
                     tbNamaObat.Text, tbTipeObat.Text, tbDescObat.Text, dgRow.Cells["obat_id"].Value.ToString());// WHERE act_user_id = '{0}'", user);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Berhasil Edit Obat");
                con.Close();
                btnSearch.PerformClick();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Update!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgRow = dgvObat.Rows[e.RowIndex];
                tbNamaObat.Text = dgRow.Cells["obat_nama"].Value.ToString();
                tbTipeObat.Text = dgRow.Cells["obat_type"].Value.ToString();
                tbDescObat.Text = dgRow.Cells["obat_desc"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgRow == null)
            {
                MessageBox.Show("Pilih baris yang akan dihapus", "Hehe!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Konfirmasi penghapusan data "+dgRow.Cells["obat_nama"].Value.ToString()+" ?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format(
                         "DELETE FROM obat WHERE obat_id = '{0}'", dgRow.Cells["obat_id"].Value.ToString());// WHERE act_user_id = '{0}'", user);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Berhasil Hapus Obat");
                    con.Close();
                    btnSearch.PerformClick();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "FAIL Delete!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
