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
        public Home()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule sched = new Schedule();
            sched.Show();
        }

        private void drugpbhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputObat inputdrag = new InputObat();
            inputdrag.Show();
        }

        private void closepbhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
