using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Controller : Form
    {
        NpgsqlConnection con;
        NpgsqlCommand cmd;
        string userId;
        public Controller(string uID)
        {
            dbConnection dbConnect = new dbConnection();
            (con, cmd) = dbConnect.InitializeConnection();
            userId = uID;
        }

        public void button_Clicked(object sender, EventArgs e)
        {
            actvShow(sender);
        }

        public void actvShow(object sender)
        {
            Button btn = sender as Button;
            string btnId = btn.Name;

            con.Open();
            cmd.Connection = con;
            cmd.CommandText = string.Format(
                "SELECT actv_obat_id, obat_dosage, obat_interval, consume_date, actv_name FROM actv_obat WHERE actv_id = '{0}';", btnId);

            

            NpgsqlDataReader reader = cmd.ExecuteReader();
            DataTable selectedActv = new DataTable();
            selectedActv.Load(reader);
            string actv_obat_id = selectedActv.Rows[0].ItemArray[0].ToString();
            string obat_dosage = selectedActv.Rows[0].ItemArray[1].ToString();
            string obat_interval = selectedActv.Rows[0].ItemArray[2].ToString();
            string consume_date = selectedActv.Rows[0].ItemArray[3].ToString();
            string actv_name = selectedActv.Rows[0].ItemArray[4].ToString();


            AddJadwalObat addJadwalObat = new AddJadwalObat(actv_obat_id, obat_dosage, obat_interval, consume_date, actv_name, btnId);
            addJadwalObat.ShowDialog();

            con.Close();
        }
    }
}
