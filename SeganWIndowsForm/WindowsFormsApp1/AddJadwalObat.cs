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
    public partial class AddJadwalObat : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        private NpgsqlDataReader dr;
        private DataTable obatList;
        public AddJadwalObat()
        {
            InitializeComponent();
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
        }

        private void obatSeeding()
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = string.Format(
                "SELECT obat_nama FROM obat;");


            dr = cmd.ExecuteReader();
            obatList = new DataTable();
            obatList.Load(dr);
            //DataRow[] dataRows = obatList;
            //foreach(string obat in dr)
            //{
            //    ObatDropdown.Items.
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void submitDrugAct_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = tbName.Text;
                string obat = ObatDropdown.Text;
                string dosis = tbDosis.Text;
                string interval = tbInterval.Text;
                string tanggal = tbTanggal.Text;

                if (nama == "" || obat == "" || dosis == "" || interval == "" || tanggal == "")
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
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "FAIL Insert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
