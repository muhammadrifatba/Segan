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
    public partial class InputObat : Form
    {
        public InputObat()
        {
            InitializeComponent();
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
    }
}
